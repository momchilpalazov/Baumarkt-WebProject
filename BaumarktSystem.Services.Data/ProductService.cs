using Baumarkt_E_commerce_Platform.Data;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaumarktSystem.Services.Data;
using BaumarktSystem.Data.Models;

namespace BaumarktSystem.Services.Data
{
    public class ProductService : IProductInterface
    {

        private readonly BaumarktSystemDbContext dbContext;   


        public ProductService(BaumarktSystemDbContext dbContext  )
        {
            this.dbContext = dbContext;          
           

        }

        public async Task CreateProductAsync(ProductIndexViewModel product)
        {




            var newProduct = new Product
            {
                FullName = product.Name,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                ShortProductDescription = product.ShortProductDescription,
                Description = product.Description,
                CategoryId = product.CategoryId,
                ApplicationTypeId = product.ApplicationType.Id
            };

            this.dbContext.Product.Add(newProduct);
            await this.dbContext.SaveChangesAsync();
        }

        public  Task DeleteProductByIdAsync(int id)
        {
           
            var productToDelete= this.dbContext.Product.Where(x => x.Id == id).FirstOrDefault();


            if (productToDelete != null)
            {
                this.dbContext.Product.Remove(productToDelete);
                this.dbContext.SaveChanges();
            }

            return Task.CompletedTask;      

            
        }

        public async Task<List<ApplicationTypeViewModel>> GetAllApplicationTypesListAsync()
        {
            var applicationTypesList = await this.dbContext.ApplicationType
           .Select(x => new ApplicationTypeViewModel
           {
               Id = x.Id,
               Name = x.Name
           })
           .ToListAsync();

            return applicationTypesList;
        }

        public async Task<List<CategoryIndexViewModel>> GetAllFilteredCategoriesAsync()
        {
            var categories = await this.dbContext.Category
         .Select(x => new CategoryIndexViewModel
         {
             Id = x.Id,
             Name = x.Name
         }).ToListAsync();

            return categories;
        }

        public async Task<List<CategoryViewModel>> GetAllCategoriesListAsync()
        {
            var categoriesList = await this.dbContext.Category
           .Select(x => new CategoryViewModel
           {
               Id = x.Id,
               Name = x.Name
           })
           .ToListAsync();

            return categoriesList;
        }

       


            
        

        public async Task<IEnumerable<ProductIndexViewModel>> GetAllProductsAsync()
        {
            var products = await this.dbContext.Product
                .Include(x => x.Category)
                .Include(x => x.ApplicationType)
                .Select(x => new ProductIndexViewModel
                {
                    Id = x.Id,
                    Name = x.FullName,
                    Price = x.Price,                    
                    ImageUrl = Uri.IsWellFormedUriString(x.ImageUrl, UriKind.Absolute)// Check if the ImageUrl is it starts with http or https
                        ? x.ImageUrl // If it's a URL, use it 
                        : $"/images/{x.ImageUrl}", // If it's not a URL, go to the "images" folder 
                    ShortProductDescription = x.ShortProductDescription,
                    Description = x.Description,
                    Category = new CategoryIndexViewModel
                    {
                        Id = x.CategoryId,
                        Name = x.Category.Name
                    },
                    ApplicationType = new ApplicationTypeIndexViewModel
                    {
                        Id = x.ApplicationTypeId,
                        Name = x.ApplicationType.Name
                    }
                }).ToListAsync();

            return products;
        }






        public async Task<ProductIndexViewModel> GetProductByIdAsync(int id)
        {
            var product = await this.dbContext.Product
                .Include(x => x.Category)
                .Include(x => x.ApplicationType)
                .Where(x => x.Id == id)
                .Select(x => new ProductIndexViewModel
                {
                    Id = x.Id,
                    Name = x.FullName,
                    Price = x.Price,
                    ImageUrl = Uri.IsWellFormedUriString(x.ImageUrl, UriKind.Absolute)
                        ? x.ImageUrl
                        : $"/images/{x.ImageUrl}",
                    ShortProductDescription = x.ShortProductDescription,
                    Description = x.Description,
                    CategoryId = x.CategoryId,
                    ApplicationTypeId = x.ApplicationTypeId
                })
                .FirstOrDefaultAsync();

            if (product != null)
            {
                var categories = await this.dbContext.Category
                    .Select(c => new CategoryViewModel
                    {
                        Id = c.Id,
                        Name = c.Name
                    })
                    .ToListAsync();

                var applicationTypes = await this.dbContext.ApplicationType
                    .Select(at => new ApplicationTypeViewModel
                    {
                        Id = at.Id,
                        Name = at.Name
                    })
                    .ToListAsync();

                product.Categories = categories;
                product.ApplicationTypes = applicationTypes;
            }

            return product;
        }


        public async Task<List<ProductIndexViewModel>> GetFilteredProductsAsync(int categoryId)
        {
            var products = await this.dbContext.Product
       .Include(x => x.Category)
       .Include(x => x.ApplicationType)
       .Where(x => x.CategoryId == categoryId)
       .Select(x => new ProductIndexViewModel
       {
           Id = x.Id,
           Name = x.FullName,
           Price = x.Price,
           ImageUrl = Uri.IsWellFormedUriString(x.ImageUrl, UriKind.Absolute)
               ? x.ImageUrl
               : $"/images/{x.ImageUrl}",
           ShortProductDescription = x.ShortProductDescription,
           Description = x.Description,
           Category = new CategoryIndexViewModel
           {
               Id = x.Category.Id,
               Name = x.Category.Name
           },
           ApplicationType = new ApplicationTypeIndexViewModel
           {
               Id = x.ApplicationType.Id,
               Name = x.ApplicationType.Name
           }
       }).ToListAsync();

            return products;





        }

        public async Task EditProductAsync(ProductIndexViewModel model)
        {
            var productToEdit = await this.dbContext.Product.FirstOrDefaultAsync(x => x.Id == model.Id);

            if (productToEdit != null)
            {
                productToEdit.FullName = model.Name;
                productToEdit.Price = model.Price;
                productToEdit.ShortProductDescription = model.ShortProductDescription;
                productToEdit.Description = model.Description;
                productToEdit.CategoryId = model.CategoryId;
                productToEdit.ApplicationTypeId = model.ApplicationTypeId;

                // Check if the ImageUrl is an absolute URL or a local path
                if (Uri.IsWellFormedUriString(model.ImageUrl, UriKind.Absolute))
                {
                    productToEdit.ImageUrl = model.ImageUrl;
                }
                else if (!string.IsNullOrEmpty(model.ImageUrl))
                {
                    // If the ImageUrl is not an absolute URL, it is a local path, so we save the filename only
                    string fileName = Path.GetFileName(model.ImageUrl);
                    productToEdit.ImageUrl = $"/images/{fileName}";
                }

                await this.dbContext.SaveChangesAsync();
            }
        }

    }
}
