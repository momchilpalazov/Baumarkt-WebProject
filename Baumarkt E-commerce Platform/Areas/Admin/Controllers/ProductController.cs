using BaumarktSystem.Areas.Admin.ViewModels.Baumarkt;
using BaumarktSystem.Areas.Admin.Controllers;
using BaumarktSystem.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BaumarktSystem.Web.ViewModels.Home;

namespace BaumarktSystem.Areas.Admin.Controllers
{
    public class ProductController : BaseAdminController
    {

        private readonly IProductInterface productInterface;


        public ProductController(IProductInterface productInterface)
        {
            this.productInterface = productInterface;
        }       

        

        public async Task<IActionResult> IndexAll(int? categoryId)
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
    }
}




   

