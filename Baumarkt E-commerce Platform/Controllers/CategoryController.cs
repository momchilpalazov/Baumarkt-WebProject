using BaumarktSystem.Services.Data.Interaces;
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




       
    }
}
