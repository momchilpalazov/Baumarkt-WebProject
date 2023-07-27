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
                ApplicationTypeId = product.ApplicationTypeId
            };

            this.dbContext.Product.Add(newProduct);
            await this.dbContext.SaveChangesAsync();
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

        //public async Task<IEnumerable<ProductIndexViewModel>> GetAllProductsAsync()
        //{
        //    var products = await this.dbContext.Product
        //        .Include(x => x.Category) 
        //        .Include(x => x.ApplicationType) 
        //        .Select(x => new ProductIndexViewModel
        //        {
        //            Id = x.Id,
        //            Name = x.FullName,
        //            Price = x.Price,
        //            ImageUrl = x.ImageUrl,
        //            ShortProductDescription = x.ShortProductDescription,
        //            Description = x.Description,
        //            Category = new CategoryIndexViewModel
        //            {
        //                Id = x.Category.Id,
        //                Name = x.Category.Name
        //            },
        //            ApplicationType = new ApplicationTypeIndexViewModel
        //            {
        //                Id = x.ApplicationType.Id,
        //                Name = x.ApplicationType.Name
        //            }
        //        }).ToListAsync();

        //    return products;
        //}


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
                    // Check if the ImageUrl is a valid URL (it starts with "http" or "https")
                    ImageUrl = Uri.IsWellFormedUriString(x.ImageUrl, UriKind.Absolute)
                        ? x.ImageUrl // If it's a URL, use it as is
                        : $"/images/{x.ImageUrl}", // If it's not a URL, prepend it with the "images" folder path
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


    }
}
