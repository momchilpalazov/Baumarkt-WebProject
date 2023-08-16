using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using BaumarktSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaumarktSystem.Data.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {




        public void Configure(EntityTypeBuilder<Product> builder)
        {



            builder.HasOne(p => p.Category)
             .WithMany(c => c.Products)
             .HasForeignKey(p => p.CategoryId)
             .OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(p => p.ApplicationType)
                .WithMany(at => at.Products)
                .HasForeignKey(p => p.ApplicationTypeId)
                .OnDelete(DeleteBehavior.Restrict);



            builder.HasData(AddProducts());
        }

        private Product[] AddProducts()
        {
            Product product;

            ICollection<Product> products = new HashSet<Product>();

            Guid adminUserCreatorId = new Guid("16F1007B-C5D3-4990-9B89-81C614ABBC84");

            product = new Product()
            {
                Id = 1,
                FullName = "Laminat",
                Price = 10.00M,
                ShortProductDescription = "Das Laminat Mühltal Eiche besitzt durch markant eingefärbte Äste eine besondere Natürlichkeit und Rustikalität. Der natürliche Farbton des Bodens ist mit vielen Wohnstilen kombinierbar. ",
                Description = "Parkettmuster Eiche",
                ImageUrl = "https://media.cdn.bauhaus/m/736748-1/15.webp",
                CategoryId = 1,
                ApplicationTypeId = 1,
                CreatedOn = DateTime.Now,




            };

            products.Add(product);

            product = new Product()
            {
                Id = 2,
                FullName = "Parkett",
                Price = 20.55M,
                ShortProductDescription = "Parkettmuster Eiche Vaduz",
                Description = "Mit dem Handmuster dieses Fertigparketts können Sie zu Hause ganz in Ruhe über die Gestaltung Ihrer Wohnräume entscheiden.",
                ImageUrl = "https://media.cdn.bauhaus/m/1103405-1/12.webp",
                CategoryId = 1,
                ApplicationTypeId = 1,
                CreatedOn = DateTime.Now

            };

            products.Add(product);

            product = new Product()
            {
                Id = 3,
                FullName = "Teppich",
                Price = 30.49M,
                ShortProductDescription = "Kayoom Teppich Cocktail 300",
                Description = "Der Kayoom Teppich Cocktail 400 fasziniert mit seiner weichen Haptik in jederlei Hinsicht. Durch die schöne Struktur, die herrlichen Farben und dem natürlichen Material ist dieser handgewebte Teppich eine ideale Bereicherung für ein gemütliches Wohnambiente.",
                ImageUrl = "https://media.cdn.bauhaus/m/425344/12.webp",
                CategoryId = 1,
                ApplicationTypeId = 1,
                CreatedOn = DateTime.Now

            };

            products.Add(product);

            product = new Product()
            {
                Id = 4,
                FullName = "Farbe",
                Price = 40.89M,
                ShortProductDescription = "SCHÖNER WOHNEN-Farbe Wandfarbe Universalweiß",
                Description = "Die SCHÖNER WOHNEN-Farbe Wandfarbe Universalweiß ist eine waschbeständige Dispersionsfarbe für wasserdampfdurchlässige Neu- und Renovierungsanstriche mit normaler Beanspruchung im Innenbereich. Die Farbe zeichnet sich durch gutes Deckvermögen, leichte Verarbeitung und einer matten Oberfläche aus.",
                ImageUrl = "https://media.cdn.bauhaus/m/730803/12.webp",
                CategoryId = 2,
                ApplicationTypeId = 1,
                CreatedOn = DateTime.Now

            };

            products.Add(product);

            product = new Product()
            {
                Id = 5,
                FullName = "Pinsel",
                Price = 10.49M,
                ShortProductDescription = "Pinsel-Set",
                Description = "Das Pinsel-Set ist ein umfangreiches, 10-teiliges Set. Enthalten sind neben verschiedenen Schulmalpinseln bzw.",
                ImageUrl = "https://media.cdn.bauhaus/m/502545/12.webp",
                CategoryId = 2,
                ApplicationTypeId = 2,
                CreatedOn = DateTime.Now

            };

            products.Add(product);

            product = new Product()
            {
                Id = 6,
                FullName = "Rolle",
                Price = 5.69M,
                ShortProductDescription = "swingcolor Lammfell-Roller",
                Description = "Der swingcolor Lammfell-Roller überzeugt durch seine gute Farbaufnahme sowie -abgabe und sorgt für ein strukturarmes Streichergebnis",
                ImageUrl = "https://media.cdn.bauhaus/m/575332/12.webp",
                CategoryId = 2,
                ApplicationTypeId = 2,
                CreatedOn = DateTime.Now

            };

            products.Add(product);

            product = new Product()
            {
                Id = 7,
                FullName = "Hammer",
                Price = 12.78M,
                ShortProductDescription = "Wisent Schlosserhammer",
                Description = "Der Schlosserhammer von Wisent ist der ideale Hammer für jeden Heim- und Handwerker.",
                ImageUrl = "https://media.cdn.bauhaus/m/493758/12.webp",
                CategoryId = 3,
                ApplicationTypeId = 2,
                CreatedOn = DateTime.Now

            };

            products.Add(product);

            product = new Product()
            {
                Id = 8,
                FullName = "Schraubenzieher",
                Price = 15.99M,
                ShortProductDescription = "Alpha Tools Schraubendreher-Set",
                Description = "Das Schraubendreher- und Bit-Set von Alpha Tools ist ein praktisches 70-teiliges Set für anspruchsvolle Heim- und Handwerker. Mit ihm kann nahezu jede Schraubenart problemlos gelöst und festgedreht werden.",
                ImageUrl = "https://media.cdn.bauhaus/m/1211103/12.webp",
                CategoryId = 3,
                ApplicationTypeId = 2,
                CreatedOn = DateTime.Now

            };

            products.Add(product);

            product = new Product()
            {
                Id = 9,
                FullName = "Schrauben",
                Price = 7.49M,
                ShortProductDescription = "Profi Depot Mehrzweck-Schraube Turbo Drill",
                Description = "Die Mehrzweckschraube Turbo Drill ist für verschiedenste Holzverbindungen geeignet. Der TX-Kopf für TORX-Antriebe sorgt für eine gute Kraftübertragung vom Eindrehwerkzeug auf die Schraube.",
                ImageUrl = "https://media.cdn.bauhaus/m/338101/12.webp",
                CategoryId = 3,
                ApplicationTypeId = 2,
                CreatedOn = DateTime.Now

            };

            products.Add(product);

            product = new Product()
            {
                Id = 10,
                FullName = "Tisch",
                Price = 59.99M,
                ShortProductDescription = "Beistelltisch",
                Description = "Der Beistelltisch kommt mit einem urbanen, an dem Minimalismus angelehnten, Design daher. Das Trendmaterial Mangoholz kommt hier sehr gut zur Geltung und ergänzt das schlichte Gestell aus Metall ideal.",
                ImageUrl = "https://media.cdn.bauhaus/m/136478-1/12.webp",
                CategoryId = 4,
                ApplicationTypeId = 1,
                CreatedOn = DateTime.Now

            };

            products.Add(product);

            product = new Product()
            {
                Id = 11,
                FullName = "Stuhl",
                Price = 99.99M,
                ShortProductDescription = "Sunfun Gartensessel Falun",
                Description = "Der Diningsessel Sonja aus strapazierfähigem Kunststoff zeichnet sich durch seine ergonomisch geformte Sitzschale mit Regenwasserablauf-Spalten aus.",
                ImageUrl = "https://media.cdn.bauhaus/m/632456/12.webp",
                CategoryId = 4,
                ApplicationTypeId = 1,
                CreatedOn = DateTime.Now

            };

            products.Add(product);

            product = new Product()
            {
                Id = 12,
                FullName = "Sofa",
                Price = 249.49M,
                ShortProductDescription = "Sunfun Melina Loungesofa",
                Description = "Das Melina Loungesofa von Sunfun verfügt über ein robustes Aluminiumgestell, welches stabil aber zugleich angenehm leicht ist. So kann das Sofa bei Bedarf ohne große Anstrengungen umgestellt werden.",
                ImageUrl = "https://media.cdn.bauhaus/m/1114013/12.webp",
                CategoryId = 4,
                ApplicationTypeId = 1,
                CreatedOn = DateTime.Now


            };

            products.Add(product);

            return products.ToArray();





        }



    }
    
}