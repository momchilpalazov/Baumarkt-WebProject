using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace Baumarkt_E_commerce_Platform.Controllers
{
    public class ProductController : Controller
    {


        private readonly IProductInterface productInterface;


        public ProductController(IProductInterface productInterface)
        {
            this.productInterface = productInterface;
        }

        [HttpGet]
        public async Task<IActionResult> AllProducts()
        {

            var products = await this.productInterface.GetAllProductsAsync();

            return this.View(products);



        }

        [HttpGet]

        public async Task<IActionResult> Create()
        {

            var products = await this.productInterface.GetAllProductsAsync();

            return this.View(products);

           



           
        }

        [HttpPost]

        public async Task<IActionResult> Create(ProductIndexViewModel product)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(product);
            }

            await this.productInterface.CreateProductAsync(product);

            return this.RedirectToAction("AllProducts");
        }

       




       
    }
}
