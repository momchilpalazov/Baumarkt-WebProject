using BaumarktSystem.Data;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Services.Data
{
    public class SupplierServices : ISupplierInterface
    {
        public readonly BaumarktSystemDbContext dbContext;  

        public SupplierServices(BaumarktSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> BeASupplierAsync(Guid userId)
        {

            bool isDealer = await this.dbContext.Suppliers.AnyAsync(x => x.CreatorId == userId);

            return isDealer;



        }

        public async Task CreateSupplier(Guid userId, SupplierIndexViewModel supplier)
        {

            var suppliers= new Supplier
            {
                PhoneNumber = supplier.PhoneNumber,
                CreatorId = userId,
                
            }; 
            
           await this.dbContext.Suppliers.AddAsync(suppliers);
            await this.dbContext.SaveChangesAsync();      



           
        }

        public async Task<bool> ExistSupplierByPhoneNumber(string phoneNumber)
        {

            bool existDealer = await  this.dbContext.Suppliers.AnyAsync(x => x.PhoneNumber == phoneNumber);

            return existDealer;


           
        }
    }
}
