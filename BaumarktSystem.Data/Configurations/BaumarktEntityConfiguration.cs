using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaumarktSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaumarktSystem.Data.Configurations
{
    public  class BaumarktEntityConfiguration:IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasOne(p => p.Category)
           .WithMany(c => c.Products)
           .HasForeignKey(p => p.CategoryId)
           .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.ApplicationType)
                .WithMany()
                .HasForeignKey(p => p.ApplicationTypeId)
                .OnDelete(DeleteBehavior.Restrict); 

        }



    }
}
