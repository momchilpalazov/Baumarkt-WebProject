using Microsoft.AspNetCore.Mvc;

namespace Baumarkt_E_commerce_Platform.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
