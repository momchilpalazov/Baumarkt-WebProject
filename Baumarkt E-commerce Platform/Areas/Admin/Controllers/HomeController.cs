using BaumarktSystem.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BaumarktSystem.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }


        


    }
}
