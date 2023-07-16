using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace Baumarkt_E_commerce_Platform.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryInterface categoryInterface;

        public CategoryController(ICategoryInterface categoryInterface)
        {
            this.categoryInterface = categoryInterface;
        }



        
        public async Task<IActionResult> AllCategory()
        {

            var categories = await this.categoryInterface.GetAllCategoriesAsync();

            return this.View(categories);            
        }




        [HttpGet]
        public async Task<IActionResult> Create()
        {
           //var categories = await this.categoryInterface.GetAllCategoriesAsync();

            return this.View();          

           
        }





        [HttpPost]
        public async Task<IActionResult> Create(CategoryIndexViewModel category)
        {

            
            if (!this.ModelState.IsValid)
            {
                return this.View(category);
            }

            await this.categoryInterface.CreateCategoryAsync(category);

            return this.RedirectToAction("AllCategory");



            
        }




       
    }
}
