using BaumarktSystem.Data;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

        private readonly UserManager<ApplicationUser> userManager;

        private readonly IHttpContextAccessor _httpContextAccessor;



        public CategoryService(BaumarktSystemDbContext dbContext, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }


        public Task<IEnumerable<CategoryIndexViewModel>> CreateCategoryAsync(CategoryIndexViewModel category)
        {

            try
            {
                var newCategory = new Category
                {
                    Name = category.Name,
                    ShowOrder = category.ShowOrder,

                    CreatedOn = DateTime.UtcNow,
                    Creator = this.userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result
                };

                this.dbContext.Category.Add(newCategory);
                this.dbContext.SaveChanges();





                return Task.FromResult(this.dbContext.Category.Select(x => new CategoryIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ShowOrder = x.ShowOrder,
                    CreatedOn = DateTime.UtcNow,
                    Creator = x.Creator.UserName


                }).ToList().AsEnumerable());

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
                
            }     


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

        public async Task<CategoryIndexViewModel> GetDetailsCategoryByIdAsync(int id)
        {

            var category = await this.dbContext.Category.Where(x => x.Id == id).Select(x => new CategoryIndexViewModel
            {
                Id = x.Id,
                Name = x.Name,
                ShowOrder = x.ShowOrder,
                CreatedOn = x.CreatedOn,
                Creator = x.Creator.UserName
            }).FirstOrDefaultAsync();

            return category;






            
        }

        Task<CategoryIndexViewModel?> ICategoryInterface.GetCategoryByIdAsync(int id)
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
