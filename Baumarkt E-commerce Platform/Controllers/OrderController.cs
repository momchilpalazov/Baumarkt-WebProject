
using Baumarkt_E_commerce_Platform.Utility.BrainTree;
using BaumarktSystem.Common;
using BaumarktSystem.Data;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.Utility;
using BaumarktSystem.Web.ViewModels.Order;
using BaumarktSystem.Web.ViewModels.ShoppingCart;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace BaumarktSystem.Admin.Controllers
{
    public class OrderController : Controller
    {


        private readonly BaumarktSystemDbContext dbContext;

       

        private readonly IOrderHeaderInterface orderHeaderInterface;

        private readonly IOrderDetailsInterface orderDetailsInterface;      

      

        [BindProperty]
        public  OrderViewModel OrderViewModel { get; set; }

        public OrderController( BaumarktSystemDbContext dbContext
            , IOrderDetailsInterface orderDetails, IOrderHeaderInterface orderHeader)
        {

            this.dbContext = dbContext;
         
            this.orderHeaderInterface = orderHeader;
            this.orderDetailsInterface = orderDetails;
            
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
    }
}
