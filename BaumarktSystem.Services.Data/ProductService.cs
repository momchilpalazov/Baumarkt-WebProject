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
    public  class ProductService: IProductInterface 
    {

        private readonly BaumarktSystemDbContext dbContext;

        

       
        



        public ProductService(BaumarktSystemDbContext dbContext  )
        {
            this.dbContext = dbContext;          
           

        }

        public async Task<IEnumerable<ProductIndexViewModel>> CreateProductAsync(ProductIndexViewModel product)
        {
            var newProduct = new Product 
            {
                Id = product.Id,
                FullName = product.Name, 
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                ShortProductDescription = product.ShortProductDescription,
                Description = product.Description
            };

            this.dbContext.Product.Add(newProduct); 
            await this.dbContext.SaveChangesAsync(); 

            
            return new List<ProductIndexViewModel> { new ProductIndexViewModel
            {
            Id = newProduct.Id,
            Name = newProduct.FullName,
            Price = newProduct.Price,
            ImageUrl = newProduct.ImageUrl,
            ShortProductDescription = newProduct.ShortProductDescription,
             Description = newProduct.Description
             }};
        }


        public async Task<IEnumerable<ProductIndexViewModel>> GetAllProductsAsync()
        {
            var products = await this.dbContext.Product
                .Include(x => x.Category) // Load the related Category entity
                .Include(x => x.ApplicationType) // Load the related ApplicationType entity
                .Select(x => new ProductIndexViewModel
                {
                    Id = x.Id,
                    Name = x.FullName,
                    Price = x.Price,
                    ImageUrl = x.ImageUrl,
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
