
using Baumarkt_E_commerce_Platform.Utility.BrainTree;
using BaumarktSystem.Data;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data;

using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Utility;
using BaumarktSystem.Web.Infrastructure.Extensions;
using BaumarktSystem.Web.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
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

            //Emeil Sender registrations
            builder.Services.AddScoped<MailJetSettings>();
            builder.Services.AddTransient<IEmailSender, EmailSender>(); 

            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;

            });

           

            //BrainTree
            builder.Services.Configure<BrainTreePropertySettings>(builder.Configuration.GetSection("BrainTree"));
            builder.Services.AddSingleton<IBrainTreeGateInterface, BrainTreeGate>();
            

            builder.Services.AddScoped<ICategoryInterface,CategoryService  >();
            builder.Services.AddScoped<IApplicationTypeInterface,ApplicationTypeService>();
            builder.Services.AddScoped<IProductInterface,ProductService>();
            builder.Services.AddScoped<ISupplierInterface,SupplierServices>();
            builder.Services.AddScoped<IUserInterface,UserService>();
            builder.Services.AddScoped<IInquiryHeaderInterface, InquiryHeaderService>();
            builder.Services.AddScoped<IInquiryDetailsInterface, InquiryDetailsService>();
            builder.Services.AddScoped<IOrderHeaderInterface, OrderHeaderService>();
            builder.Services.AddScoped<IOrderDetailsInterface, OrderDetailsService>();  

            builder.Services.AddScoped<UserSession>();
           
            builder.Services.AddAuthentication().AddFacebook(options =>
            {
                options.AppId = "269829345892609";
                options.AppSecret = "10d596b782ef2ed2f64037aa476ddb3f";
            });


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
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "/{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "/{controller=Home}/{action=Index}/{id?}"
                );
            });




            app.MapDefaultControllerRoute();

            app.MapRazorPages();

            app.Run();
        }
    }
}