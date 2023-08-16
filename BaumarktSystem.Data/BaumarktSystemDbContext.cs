using BaumarktSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace BaumarktSystem.Data
{
    public class BaumarktSystemDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public BaumarktSystemDbContext(DbContextOptions<BaumarktSystemDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Product { get; set; } = null!;
       

        public DbSet<Category> Category { get; set; } = null!;

        public DbSet<ApplicationType> ApplicationType { get; set; } = null!;

        public DbSet<ApplicationUser> ApplicationUser { get; set; } = null!;

        public DbSet<CartItem> CartItem { get; set; } = null!;

        public DbSet<Supplier> Suppliers { get; set; } = null!;

        public DbSet<InquiryHedaer> InquiryHedaer { get; set; } = null!;

        public DbSet<InquiryDetails> InquiryDetails { get; set; } = null!;


       


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfigurationsFromAssembly (typeof(BaumarktSystemDbContext).Assembly);

           
            base.OnModelCreating(builder);

          
        }





    }
}