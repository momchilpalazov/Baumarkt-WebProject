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
    //public class ApplicationTypeEntityConfiguration : IEntityTypeConfiguration<ApplicationType>
    //{
    //    public void Configure(EntityTypeBuilder<ApplicationType> builder)
    //    {
    //        builder.HasData(AddApplicationType());
    //    }


    //    private ApplicationType[] AddApplicationType()
    //    {

    //        ICollection<ApplicationType> applicationTypes = new HashSet<ApplicationType>();

    //        ApplicationType applicationType;

    //        Guid guidId = new Guid("BE0238D0-D746-4B53-B196-7E0C60DFE84B");
    //        Guid adminUserId = new Guid("3F442614-2DB4-4F9C-8C19-50BC2EE3D01E");

    //        applicationType = new ApplicationType()
    //        {
    //            Id = guidId, 
    //            Name = "Admin",
    //            CreatedOn = DateTime.Now,
    //            CreatorId = adminUserId



    //        };

    //        applicationTypes.Add(applicationType);

    //        return applicationTypes.ToArray();





    //    }


    //}
}
