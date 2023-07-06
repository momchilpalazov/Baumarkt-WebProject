using BaumarktSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Baumarkt_E_commerce_Platform.Data
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

        public DbSet<CartItem> CartItem { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Product)
                .HasForeignKey(p => p.CategoryId);

            builder.Entity<Product>()
                .HasOne(p => p.Type)
                .WithMany(t => t.Product)
                .HasForeignKey(p => p.TypeId);

            builder.Entity<Product>()
                .HasOne(p => p.ApplicationUser)
                .WithMany(u => u.CartItem)
                .HasForeignKey(p => p.UserId);

            builder.Entity<CartItem>()
                .HasOne(c => c.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(c => c.ProductId);

            builder.Entity<CartItem>()
                .HasOne(c => c.ApplicationUser)
                .WithMany(u => u.CartItem)
                .HasForeignKey(c => c.UserId);

        }





    }
}