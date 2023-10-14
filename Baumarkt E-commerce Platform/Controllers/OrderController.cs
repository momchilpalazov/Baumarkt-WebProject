
using Baumarkt_E_commerce_Platform.Utility.BrainTree;
using BaumarktSystem.Common;
using BaumarktSystem.Data;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.ViewModels.Order;
using Braintree;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace BaumarktSystem.Admin.Controllers
{
    [Authorize(Roles = GeneralApplicationConstants.roleAdmin)]
    public class OrderController : Controller
    {


        private readonly BaumarktSystemDbContext dbContext;

       

        private readonly IOrderHeaderInterface orderHeaderInterface;

        private readonly IOrderDetailsInterface orderDetailsInterface;    
        
        private readonly IBrainTreeGateInterface brainTreeGateInterface;

      

        [BindProperty]
        public  OrderViewModel OrderViewModel { get; set; }

        public OrderController( BaumarktSystemDbContext dbContext
            , IOrderDetailsInterface orderDetails, IOrderHeaderInterface orderHeader,IBrainTreeGateInterface brainTreeGateInterface)
        {

            this.dbContext = dbContext;
         
            this.orderHeaderInterface = orderHeader;
            this.orderDetailsInterface = orderDetails;
            this.brainTreeGateInterface = brainTreeGateInterface;
            
        }




        public IActionResult Order()
        {
            
            OrderListViewModel orderListViewModel = new OrderListViewModel()
            {
                //OrderHeadersList = dbContext.OrderHeader.Include(o => o.CreatedBy)
                //.OrderByDescending(o => o.OrderDate),

                OrderHeadersList = orderHeaderInterface.GetAll(),
                StatusList = GeneralApplicationConstants.StatusList.ToList().Select(s => new Microsoft.AspNetCore.Mvc.Rendering. SelectListItem
                {
                    Text = s,
                    Value = s
                })
            };



            return View(orderListViewModel);

            
        }


        public async Task<IActionResult> OrderDetails(int id)
        {

            OrderViewModel  = new OrderViewModel()
            {
                OrderHeader = orderHeaderInterface.GetById(id).FirstOrDefault(x=>x.Id==id),
                OrderDetails = orderDetailsInterface.GetAll().Where(o => o.OrderHeaderId == id).ToList(),
                Products = dbContext.Product.ToList()
            };

            return View(OrderViewModel);
        }


        [HttpPost]
        public IActionResult StartProces()
        {
            var orderHeader = orderHeaderInterface.GetAll().FirstOrDefault(x => x.Id == OrderViewModel.OrderHeader.Id);
            orderHeader.OrderStatus = GeneralApplicationConstants.StatusInProcess;
            dbContext.SaveChanges();
            TempData["Success"] = "Order started successfully"; 
            return RedirectToAction(nameof(Order));
        }

        [HttpPost]
        public IActionResult ShipOrder()
        {
            var orderHeader = orderHeaderInterface.GetAll().FirstOrDefault(x => x.Id == OrderViewModel.OrderHeader.Id);
            orderHeader.OrderStatus = GeneralApplicationConstants.StatusShipped;
            orderHeader.ShippingDate = System.DateTime.Now;
            dbContext.SaveChanges();
            TempData["Success"] = "Order shipped successfully";
            return RedirectToAction(nameof(Order));
        }

        [HttpPost]
        public IActionResult CancelOrder()
        {
            var orderHeader = orderHeaderInterface.GetAll().FirstOrDefault(x => x.Id == OrderViewModel.OrderHeader.Id);

            var gateway = brainTreeGateInterface.GetGateway();  
            Transaction transaction = gateway.Transaction.Find(orderHeader.TransactionId);
            if (transaction.Status == TransactionStatus.AUTHORIZED || transaction.Status == TransactionStatus.SUBMITTED_FOR_SETTLEMENT)
            {
                // No refund
                Result<Transaction> resultVoid = gateway.Transaction.Void(orderHeader.TransactionId);
            }
            else
            {
                // Refund
                Result<Transaction> resultRefund = gateway.Transaction.Refund(orderHeader.TransactionId);
            }

            orderHeader.OrderStatus = GeneralApplicationConstants.StatusRefunded;           
            dbContext.SaveChanges();
            TempData["Success"] = "Order cancelled successfully";
            return RedirectToAction(nameof(Order));
        }

        [HttpPost]

        public IActionResult UpdateOrderDetails()
        {
            var orderHeaderDb = orderHeaderInterface.GetAll().FirstOrDefault(x => x.Id == OrderViewModel.OrderHeader.Id);
            
            orderHeaderDb.FullName= OrderViewModel.OrderHeader.FullName;
            orderHeaderDb.PhoneNumber = OrderViewModel.OrderHeader.PhoneNumber;
            orderHeaderDb.StreetAddress = OrderViewModel.OrderHeader.StreetAddress;
            orderHeaderDb.City = OrderViewModel.OrderHeader.City;
            orderHeaderDb.State = OrderViewModel.OrderHeader.State;
            orderHeaderDb.PostalCode = OrderViewModel.OrderHeader.PostalCode;
            orderHeaderDb.Email = OrderViewModel.OrderHeader.Email;

            dbContext.SaveChanges();
            TempData["Success"] = "Order details updated successfully";
            return RedirectToAction(nameof(OrderDetails), new { id = orderHeaderDb.Id });
        }

    }
}
