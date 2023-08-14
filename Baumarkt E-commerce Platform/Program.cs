using BaumarktSystem.Data;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data;
using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.Infrastructure.Extensions;
using BaumarktSystem.Web.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static BaumarktSystem.Common.GeneralApplicationConstants;

namespace Baumarkt_E_commerce_Platform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = 
                builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<BaumarktSystemDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>

            {
                options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                options.Password.RequireLowercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                options.Password.RequireUppercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");

            }).AddRoles<IdentityRole<Guid>>().
            AddEntityFrameworkStores<BaumarktSystemDbContext>();

            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;

            });

            //builder.Services.AddSingleton<SessionExtensions>();

            

            builder.Services.AddScoped<ICategoryInterface,CategoryService  >();
            builder.Services.AddScoped<IApplicationTypeInterface,ApplicationTypeService>();
            builder.Services.AddScoped<IProductInterface,ProductService>();
            builder.Services.AddScoped<ISupplierInterface,SupplierServices>();
            builder.Services.AddScoped<IUserInterface,UserService>();  
           

            builder.Services.AddScoped<UserSession>();


            //builder.Services.AddApplicationServices(typeof());


            builder.Services.AddControllersWithViews();

            builder.Services.AddRazorPages();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");               
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            if (app.Environment.IsDevelopment())
            {
                app.SeedAdministrator(EmeilDevelopment);

            }
           
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
               
                endpoints.MapControllers();
            });



            app.MapDefaultControllerRoute();

            app.MapRazorPages();

            app.Run();
        }
    }
}