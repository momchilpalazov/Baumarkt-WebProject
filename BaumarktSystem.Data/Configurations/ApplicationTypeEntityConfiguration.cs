using BaumarktSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst;
using ApplicationType = BaumarktSystem.Data.Models.ApplicationType;
using Category = BaumarktSystem.Data.Models.Category;

namespace BaumarktSystem.Data.Configurations
{
    public class ApplicationTypeEntityConfiguration : IEntityTypeConfiguration<ApplicationType>
    {
        public void Configure(EntityTypeBuilder<ApplicationType> builder)
        {
            builder.HasData(AddApplicationType());
        }


        private ApplicationType[] AddApplicationType()
        {

            ICollection<ApplicationType> applicationTypes = new HashSet<ApplicationType>();

            ApplicationType applicationType;

            applicationType = new ApplicationType()
            {
                Id = 1,
                Name = "Admin"


            };

            applicationTypes.Add(applicationType);

            return applicationTypes.ToArray();





        }


    }
}
