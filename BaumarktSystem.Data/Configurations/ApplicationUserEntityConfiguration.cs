using BaumarktSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst;
using ApplicationUser = BaumarktSystem.Data.Models.ApplicationUser;

namespace BaumarktSystem.Data.Configurations
{
    //public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    //{
    //    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    //    {



    //        //builder
    //        //    .Property(x => x.Name)
    //        //    .HasDefaultValue("UserUserov");

    //        builder.HasData(AddApplicationUser());



           
    //    }

    //    private ApplicationUser[] AddApplicationUser()
    //    {

    //        ICollection<ApplicationUser> applicationUsers = new HashSet<ApplicationUser>();

    //        ApplicationUser applicationUser;

    //        //Guid adminUserId = new Guid("ae6cebee-8421-4d00-8213-35b95ab97239");

    //        applicationUser = new ApplicationUser()
    //        {
    //            //Id = adminUserId,
    //            FullName = "UserUserov",
              
    //        };

    //        applicationUsers.Add(applicationUser);

    //        return applicationUsers.ToArray();
    //    }


       

    //}
}
