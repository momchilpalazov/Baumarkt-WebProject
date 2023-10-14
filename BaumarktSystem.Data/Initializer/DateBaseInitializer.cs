using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BaumarktSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst;
using BaumarktSystem.Data.Models;
using ApplicationUser = BaumarktSystem.Data.Models.ApplicationUser;

namespace BaumarktSystem.Data.Initializer
{
    public class DateBaseInitializer : IDateBaseInitializerInterface
    {

        private readonly BaumarktSystemDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public DateBaseInitializer(BaumarktSystemDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;

        }


      


        public void Initialize()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count()>0)
                {
                    _context.Database.Migrate();

                }

            }
            catch (Exception)
            {

                throw;
            }


            if (!_roleManager.RoleExistsAsync(GeneralApplicationConstants.roleAdmin).GetAwaiter().GetResult())
            {
                 _roleManager.CreateAsync(new IdentityRole<Guid> (GeneralApplicationConstants.roleAdmin)).GetAwaiter().GetResult();
                 _roleManager.CreateAsync(new IdentityRole<Guid>(GeneralApplicationConstants.roleCustomer)).GetAwaiter().GetResult();

            }

            else
            {
                return;
            }

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin@admin.bg",
                Email = "admin@admin.bg",
                EmailConfirmed = true,                
                PhoneNumber = "0888888888",
                FullName = "Admin Adminov",
                

            },"123456").GetAwaiter().GetResult();


            ApplicationUser? applicationUser = _context.ApplicationUser.FirstOrDefault(x => x.Email == "admin@admin.bg");
            _userManager.AddToRoleAsync(applicationUser, GeneralApplicationConstants.roleAdmin).GetAwaiter().GetResult();

            
           
        }

        
    }
}
