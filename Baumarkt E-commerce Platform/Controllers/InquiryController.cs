using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.Utility;
using BaumarktSystem.Web.ViewModels.Inquiry;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BaumarktSystem.Common.GeneralApplicationConstants;
using static BaumarktSystem.Common.UserSessionConstantsKey;

namespace Baumarkt_E_commerce_Platform.Controllers.Admin
{
    [Authorize(Roles = roleAdmin)]
    public class InquiryController : Controller
    {

        private readonly IInquiryDetailsInterface inquiryDetailsInterface;

        private readonly IInquiryHeaderInterface inquiryHeaderInterface;

        private readonly UserSession userSession;

        [BindProperty]
        public InquiryViewModel InquiryViewModel { get; set; }


        public InquiryController(IInquiryDetailsInterface inquiryDetailsInterface,IInquiryHeaderInterface inquiryHeaderInterface,UserSession userSession)
        {
            this.inquiryDetailsInterface = inquiryDetailsInterface;
            this.inquiryHeaderInterface = inquiryHeaderInterface; 
            this.userSession = userSession;
        }

        public IActionResult Index()
        {
            return View();
        }


        //#region API CALLS
        [HttpGet]
        public IActionResult GetInquiryLIst()
        {
            return Json(new { data = inquiryHeaderInterface.GetAll() });
        }

        //#endregion

        [HttpGet]
       public IActionResult Details(int id)
        {
            var inquiryDetails = inquiryDetailsInterface.GetInquiryDetails(id);
            return View(inquiryDetails);
        }


        [HttpPost]
      
        [ActionName("Details")]
        public IActionResult DetailsPost(int id)
        {
            List<CartItem> cartItems = new List<CartItem>();

         
            var inquiryDetails = inquiryDetailsInterface.GetDetailsByHeaderId(id);
            

            foreach (var detail in inquiryDetails)
            {
                CartItem cartItem = new CartItem
                {
                    Id = detail.ProductId
                    
                };
                cartItems.Add(cartItem);
            }



            userSession.Clear();
            userSession.Set(SessionKey, cartItems);
            userSession.Set(SessionKeyForInquiry,id);

            TempData[SuccessMessage] = "Product Added To Cart Successfully";
            return RedirectToAction("GetCartProducts", "ShoppingCart");
        }







        [HttpPost]
        public IActionResult Delete(int id)
        {
           
            inquiryDetailsInterface.Delete(id);
            TempData[SuccessMessage] = "Inquiry Deleted Successfully";
            return RedirectToAction("Index");
        }






    }
}
