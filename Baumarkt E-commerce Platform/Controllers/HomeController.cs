using BaumarktSystem.Common;
using BaumarktSystem.Services.Data;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.Utility;
using BaumarktSystem.Web.ViewModels.Home;
using static BaumarktSystem.Common.GeneralApplicationConstants;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace BaumarktSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly  IProductInterface productInterface;

        private readonly UserSession userSession;

        public HomeController(ILogger<HomeController> logger, IProductInterface productInterface, UserSession userSession)
        {
            _logger = logger;
            this.productInterface = productInterface;
            this.userSession = userSession;
        }



        public async Task<IActionResult> Index(int? categoryId)
        {

            if (this.User.IsInRole(AdminAreaName))             
            {

                return RedirectToAction("Index", "Home", new { area = AdminAreaName });          
            
            
            }



            IEnumerable<ProductIndexViewModel> filteredProducts;

            if (categoryId.HasValue && categoryId != 0)
            {
                filteredProducts = await productInterface.GetFilteredProductsAsync(categoryId.Value);
            }
            else
            {
                filteredProducts = await productInterface.GetAllProductsAsync();
            }

            var allCategories = await productInterface.GetAllFilteredCategoriesAsync();

            var viewModel = new FilteredProductsViewModel
            {
                CategoryId = categoryId ?? 0,
                FilteredProducts = filteredProducts.ToList(),
                AllCategories = allCategories
            };

            return View(viewModel);
        }










        public IActionResult Privacy()
        {
            return View();
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}