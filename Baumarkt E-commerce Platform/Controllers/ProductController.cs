using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing;

namespace Baumarkt_E_commerce_Platform.Controllers
{
    public class ProductController : Controller
    {


        private readonly IProductInterface productInterface;

        private readonly IWebHostEnvironment hostingEnvironment;


        public ProductController(IProductInterface productInterface, IWebHostEnvironment hostingEnvironment)
        {
            this.productInterface = productInterface;
            this.hostingEnvironment = hostingEnvironment;
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
            var model = new ProductIndexViewModel
            {
                Categories = await this.productInterface.GetAllCategoriesListAsync(),
                ApplicationTypes = await this.productInterface.GetAllApplicationTypesListAsync()
            };

            return this.View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Create(ProductIndexViewModel model,IFormFile image  )
        {
            if (!this.ModelState.IsValid)
            {

                model.Categories = await this.productInterface.GetAllCategoriesListAsync();
                model.ApplicationTypes = await this.productInterface.GetAllApplicationTypesListAsync();

               // return this.View(model);
                
            }

            model.ImageUrl = await this.SaveImageAsync(image);

            await this.productInterface.CreateProductAsync(model);

            return this.RedirectToAction("AllProducts");        


        }

        private Task<string> SaveImageAsync(IFormFile image)
        {
            string uploadsFolder = Path.Combine(this.hostingEnvironment.WebRootPath, "images");

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            if (image != null&& image.Length>0)
            {

                try
                {
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        image.CopyTo(fileStream);
                    }

                    return Task.FromResult(uniqueFileName);
                }
                catch (Exception)
                {

                    throw;
                }





               
            }

            return Task.FromResult(string.Empty);

           
        }
    }
}
