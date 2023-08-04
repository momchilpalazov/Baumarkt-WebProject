using System.Reflection;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using static BaumarktSystem.Common.GeneralApplicationConstants;


using BaumarktSystem.Data.Models;

namespace BaumarktSystem.Web.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {






        public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app, string email)
        {
            using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

            IServiceProvider serviceProvider = scopedServices.ServiceProvider;

            UserManager<ApplicationUser> userManager =
                serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole<Guid>> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            Task.Run(async () =>
            {
                if (await roleManager.RoleExistsAsync(roleAdmin))
                {
                    return;
                }

                IdentityRole<Guid> adminRole =
                    new IdentityRole<Guid>(roleAdmin);

                IdentityRole<Guid> customerRole =
                    new IdentityRole<Guid>(roleCustomer);

                await roleManager.CreateAsync(adminRole);
                await roleManager.CreateAsync(customerRole);



                ApplicationUser adminUser =
                    await userManager.FindByEmailAsync(email);

                await userManager.AddToRoleAsync(adminUser,roleAdmin);
                await userManager.AddToRoleAsync(adminUser,roleCustomer);

            })
            .GetAwaiter()
            .GetResult();

            return app;
        }

       
    }





}

