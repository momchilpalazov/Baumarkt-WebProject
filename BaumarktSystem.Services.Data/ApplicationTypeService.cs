using Baumarkt_E_commerce_Platform.Data;
using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst;

namespace BaumarktSystem.Services.Data
{
    public class ApplicationTypeService : IApplicationTypeInterface
    {



        private readonly BaumarktSystemDbContext dbContext;

        public ApplicationTypeService(BaumarktSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
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
