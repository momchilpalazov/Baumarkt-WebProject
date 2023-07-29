using BaumarktSystem.Services.Data;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Baumarkt_E_commerce_Platform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly  IProductInterface productInterface;

        public HomeController(ILogger<HomeController> logger, IProductInterface productInterface       )
        {
            _logger = logger;
           this. productInterface = productInterface;
        }


        //public async Task<IActionResult> Index(int? categoryId)
        //{
        //    if (categoryId.HasValue)
        //    {
        //        var filteredProducts = await productInterface.GetFilteredProductsAsync(categoryId.Value);
        //        var allCategories = await productInterface.GetAllFilteredCategoriesAsync();

        //        var viewModel = new FilteredProductsViewModel
        //        {
        //            CategoryId = categoryId.Value,
        //            FilteredProducts = filteredProducts,
        //            AllCategories = allCategories
        //        };

        //        return View(viewModel);
        //    }
        //    else
        //    {
        //        // If categoryId is null, display all products without filtering
        //        var allProducts = await productInterface.GetAllProductsAsync();
        //        var allCategories = await productInterface.GetAllFilteredCategoriesAsync();

        //        var viewModel = new FilteredProductsViewModel
        //        {
        //            CategoryId = 0, // 0 represents "All Categories"
        //            FilteredProducts = allProducts.ToList(),
        //            AllCategories = allCategories
        //        };

        //        return View(viewModel);
        //    }
        //}

        public async Task<IActionResult> Index(int? categoryId)
        {
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