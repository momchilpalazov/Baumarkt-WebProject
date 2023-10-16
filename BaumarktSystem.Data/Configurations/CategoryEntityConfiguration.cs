using BaumarktSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst;
using Category = BaumarktSystem.Data.Models.Category;

namespace BaumarktSystem.Data.Configurations
{
    //public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    //{
    //    public void Configure(EntityTypeBuilder<Category> builder)
    //    {
    //        builder.HasData(AddCategories());
    //    }


    //    private Category[] AddCategories()
    //    {

    //        ICollection<Category> categories = new HashSet<Category>();



    //        Category category;

    //        Guid adminUserId = new Guid("ae6cebee-8421-4d00-8213-35b95ab97239");


    //        category = new Category()
    //        {
    //            Id = 1,
    //            Name = "Bodenbeläge",
    //            ShowOrder = 1,
    //            CreatedOn = DateTime.Now,
    //            CreatorId = adminUserId





    //        };

    //        categories.Add(category);

    //        category = new Category()
    //        {
    //            Id = 2,
    //            Name = "Farben",
    //            ShowOrder = 2,
    //            CreatedOn = DateTime.Now,
    //            CreatorId = adminUserId


    //        };
    //        categories.Add(category);

    //        category = new Category()
    //        {
    //            Id = 3,
    //            Name = "Werkzeuge",
    //            ShowOrder = 3,
    //            CreatedOn = DateTime.Now,
    //            CreatorId = adminUserId




    //        };

    //        categories.Add(category);

    //        category = new Category()
    //        {
    //            Id = 4,
    //            Name = "Garten",
    //            ShowOrder = 4,
    //            CreatedOn = DateTime.Now,
    //            CreatorId = adminUserId




    //        };
    //        categories.Add(category);

    //        return categories.ToArray();



    //    }


    //}
}
