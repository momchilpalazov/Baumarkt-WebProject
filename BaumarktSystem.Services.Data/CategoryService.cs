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

        public Task<IEnumerable<CategoryIndexViewModel>> CreateCategoryAsync(CategoryIndexViewModel category)
        {

            var newCategory = new Category
            {
                Name = category.Name,
                ShowOrder = category.ShowOrder
            };

            this.dbContext.Category.Add(newCategory);
            this.dbContext.SaveChanges();

            return Task.FromResult(this.dbContext.Category.Select(x => new CategoryIndexViewModel
            {
                Id = x.Id,
                Name = x.Name,
                ShowOrder = x.ShowOrder
            }).ToList().AsEnumerable());




            
        }

        public Task DeleteCategoryByIdAsync(int id)
        {

            var categoryToDelete = this.dbContext.Category.Where(x => x.Id == id).FirstOrDefault();

            if (categoryToDelete == null)
            {
                return Task.CompletedTask;
            }



            this.dbContext.Category.Remove(categoryToDelete);
            this.dbContext.SaveChanges();

            return Task.CompletedTask;


            
        }

        public Task EditCategorySaveAsync(CategoryIndexViewModel category)
        {
            var categoryToEdit = this.dbContext.Category.Where(x => x.Id == category.Id).FirstOrDefault();

            if (categoryToEdit == null)
            {
                return Task.CompletedTask;
            }

            categoryToEdit.Name = category.Name;
            categoryToEdit.ShowOrder = category.ShowOrder;

            this.dbContext.SaveChanges();

            return Task.CompletedTask;

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

       

        Task<CategoryIndexViewModel> ICategoryInterface.GetCategoryByIdAsync(int id)
        {

            


            var category = this.dbContext.Category.Where(x => x.Id == id).Select(x => new CategoryIndexViewModel
            {
                Id = x.Id,
                Name = x.Name,
                ShowOrder = x.ShowOrder
            }).FirstOrDefault();

            return Task.FromResult(category);



        }
    }
}
