using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BaumarktSystem.Common.GeneralApplicationConstants;

namespace Baumarkt_E_commerce_Platform.Controllers
{

    [Authorize(Roles = roleAdmin)]
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
        public IActionResult Create()
        {
           

            return  this.View();          

           
        }





        [HttpPost]
        public async Task<IActionResult> Create(CategoryIndexViewModel category)
        {


            

            await this.categoryInterface.CreateCategoryAsync(category);

            return this.RedirectToAction("AllCategory");

            
        }

        [HttpGet]
       
        public async Task<IActionResult> EditCategory(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.NotFound();
            }

            var category = await this.categoryInterface.GetCategoryByIdAsync(id);

            return this.View(category);
        }


        [HttpPost]
        public async Task<IActionResult> EditCategory(CategoryIndexViewModel category)
        {
            if (this.ModelState.IsValid)
            {
                return this.View(category);
            }

            await this.categoryInterface.EditCategorySaveAsync(category);

            return this.RedirectToAction("AllCategory");
        }


        [HttpGet]

        public async Task<IActionResult> Delete(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.NotFound();
            }

            var category = await this.categoryInterface.GetCategoryByIdAsync(id);

            return this.View(category);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategoryById(int id)
        {



            await this.categoryInterface.DeleteCategoryByIdAsync(id);

            return this.RedirectToAction("AllCategory");          

            
        }


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var category = await this.categoryInterface.GetDetailsCategoryByIdAsync(id);

            if (category == null)
            {
                return NotFound();
            }


          
            return this.View(category);



        }




    }
}
