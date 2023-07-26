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
using BaumarktSystem.Services.Data.Interfaces;

namespace BaumarktSystem.Services.Data
{
    public class ApplicationTypeService : IApplicationTypeInterface
    {



        private readonly BaumarktSystemDbContext dbContext;

        public ApplicationTypeService(BaumarktSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreateApplicationTypeAsync(ApplicationTypeIndexViewModel applicationType)
        {

            

            var newApplicationType = new ApplicationType
            {
                Name = applicationType.Name,
                CreatedOn = DateTime.UtcNow,
                Creator = this.dbContext.Users.FirstOrDefault(),
            };

            this.dbContext.ApplicationType.Add(newApplicationType);
            this.dbContext.SaveChanges();

            return Task.CompletedTask;






        }

        public async Task DeleteApplicationTypeAsync(ApplicationTypeIndexViewModel applicationType)
        {

            var applicationTypeToDelete = await this.dbContext.ApplicationType.FirstOrDefaultAsync(x => x.Id == applicationType.Id);

            
            this.dbContext.ApplicationType.Remove(applicationTypeToDelete);
            await this.dbContext.SaveChangesAsync();




        }

        public Task EditApplicationTypePostAsync(ApplicationTypeIndexViewModel applicationType)
        {


            var applicationTypeToEdit = this.dbContext.ApplicationType.FirstOrDefault(x => x.Id == applicationType.Id);

            applicationTypeToEdit.Name = applicationType.Name;
            applicationTypeToEdit.CreatedOn = DateTime.UtcNow;
            applicationTypeToEdit.Creator= this.dbContext.Users.FirstOrDefault();

            this.dbContext.SaveChanges();

            return Task.CompletedTask;
            
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

        public Task<ApplicationTypeIndexViewModel?> GetApplicationTypeByIdAsync(Guid id)
        {

            var applicationType = this.dbContext.ApplicationType.Where(x => x.Id == id).Select(x => new ApplicationTypeIndexViewModel
            {
                Id = x.Id,
                Name = x.Name,

                
            }).FirstOrDefault();

            return Task.FromResult(applicationType);




           
        }

      

        //public Task<ApplicationTypeIndexViewModel?> GetApplicationTypeDetailsByIdAsync(Gu id)
        //{

        //    var applicationType = this.dbContext.ApplicationType.Where(x => x.Id. == id).Select(x => new ApplicationTypeIndexViewModel
        //    {
        //        Id = x.Id,
        //        Name = x.Name,
        //        CreatedOn = x.CreatedOn,
        //        Creator = x.Creator.UserName
            
              
        //    }).FirstOrDefault();

        //    return Task.FromResult(applicationType);






           
        //}

        public Task<ApplicationTypeIndexViewModel?> GetApplicationTypeDetailsByIdAsync(Guid id)
        {

            var applicationType = this.dbContext.ApplicationType.Where(x => x.Id == id).Select(x => new ApplicationTypeIndexViewModel
            {
                
                Name = x.Name,
                CreatedOn = x.CreatedOn,
                Creator = x.Creator.UserName

            }).FirstOrDefault();

            return Task.FromResult(applicationType);






           
        }
    }
}
