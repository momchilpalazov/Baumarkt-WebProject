using BaumarktSystem.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Baumarkt_E_commerce_Platform.Controllers.Admin
{
    public class InquiryController : Controller
    {

        private readonly IInquiryDetailsInterface inquiryDetailsInterface;

        private readonly IInquiryHeaderInterface inquiryHeaderInterface;

        public InquiryController(IInquiryDetailsInterface inquiryDetailsInterface,IInquiryHeaderInterface inquiryHeaderInterface)
        {
            this.inquiryDetailsInterface = inquiryDetailsInterface;
            this.inquiryHeaderInterface = inquiryHeaderInterface;   
        }

        public IActionResult Index()
        {
            return View();
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetInquiryLIst()
        {
            return Json(new { data = inquiryHeaderInterface.GetAll() });
        }

        #endregion





    }
}
