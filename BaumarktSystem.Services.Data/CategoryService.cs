using Baumarkt_E_commerce_Platform.Data;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data
{
    public class CategoryService : ICategoryInterface
    {

        private readonly BaumarktSystemDbContext dbContext;

        public CategoryService(BaumarktSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


       

        public Task<IEnumerable<CategoryIndexViewModel>> GetAllCategoriesAsync()
        {

            var categories = this.dbContext.Category.Select(x => new CategoryIndexViewModel
            {
                Id = x.Id,
                Name = x.Name,
                ShowOrder = x.ShowOrder
            }).ToList();

            return Task.FromResult(categories.AsEnumerable());
            
        }
    }
}
