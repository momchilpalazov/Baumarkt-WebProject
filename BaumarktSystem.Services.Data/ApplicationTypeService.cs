using Baumarkt_E_commerce_Platform.Data;
using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst;
using ApplicationType = BaumarktSystem.Data.Models.ApplicationType;

namespace BaumarktSystem.Services.Data
{
    public class ApplicationTypeService : IApplicationTypeInterface
    {



        private readonly BaumarktSystemDbContext dbContext;

        public ApplicationTypeService(BaumarktSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ApplicationTypeIndexViewModel>> CreateApplicationTypeAsync(ApplicationTypeIndexViewModel applicationType)
        {

           
            var newApplicationType = new ApplicationType
            {
                Name = applicationType.Name,
                
            };

            this.dbContext.ApplicationType.Add(newApplicationType);
            await this.dbContext.SaveChangesAsync();

            return await this.dbContext.ApplicationType.Select(x => new ApplicationTypeIndexViewModel
            {
                Id = x.Id,
                Name = x.Name,
                
            }).ToListAsync();       



        }

        public Task<IEnumerable<ApplicationTypeIndexViewModel>> GetAllApplicationTypesAsync()
        {

            var applicationTypes = this.dbContext.ApplicationType.Select(x => new ApplicationTypeIndexViewModel
            {
                Id = x.Id,
                Name = x.Name,
               
            }).ToList();

            return Task.FromResult(applicationTypes.AsEnumerable());



            
        }

       
    }
}
