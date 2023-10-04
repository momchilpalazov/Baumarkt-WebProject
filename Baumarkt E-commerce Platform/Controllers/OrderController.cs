
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

        private readonly IWebHostEnvironment webHostEnvironment;

        private readonly IEmailSender emailSender;

        private readonly IOrderHeaderInterface orderHeaderInterface;

        private readonly IOrderDetailsInterface orderDetailsInterface;

        private readonly IBrainTreeGateInterface brainTreeGateInterface;        

        private readonly UserSession userSession;

        public OrderController(UserSession userSession, BaumarktSystemDbContext dbContext, IWebHostEnvironment webHostEnvironment,
            IEmailSender emailSender, IOrderDetailsInterface orderDetails, IOrderHeaderInterface orderHeader, IBrainTreeGateInterface brainTreeGateInterface)
        {

            this.userSession = userSession;
            this.dbContext = dbContext;
            this.webHostEnvironment = webHostEnvironment;
            this.emailSender = emailSender;
            this.orderHeaderInterface = orderHeader;
            this.orderDetailsInterface = orderDetails;
            this.brainTreeGateInterface = brainTreeGateInterface;
        }




        public IActionResult Order()
        {
            
            OrderListViewModel orderListViewModel = new OrderListViewModel()
            {
                OrderHeadersList = dbContext.OrderHeader.Include(o => o.CreatedBy)
                .OrderByDescending(o => o.OrderDate),
                StatusList = GeneralApplicationConstants.StatusList.Select(s => new SelectListItem
                {
                    Text = s,
                    Value = s
                })
            };



            return View(orderListViewModel);

            
        }
    }
}
