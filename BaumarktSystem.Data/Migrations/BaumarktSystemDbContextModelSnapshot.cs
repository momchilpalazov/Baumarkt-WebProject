﻿// <auto-generated />
using System;
using Baumarkt_E_commerce_Platform.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    [DbContext(typeof(BaumarktSystemDbContext))]
    partial class BaumarktSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BaumarktSystem.Data.Models.ApplicationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("ApplicationType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4213),
                            CreatorId = new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"),
                            Name = "Haus"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4299),
                            CreatorId = new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"),
                            Name = "Werkstatt"
                        });
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShowOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4641),
                            CreatorId = new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"),
                            Name = "Bodenbeläge",
                            ShowOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4652),
                            CreatorId = new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"),
                            Name = "Farben",
                            ShowOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4656),
                            CreatorId = new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"),
                            Name = "Werkzeuge",
                            ShowOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4658),
                            CreatorId = new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"),
                            Name = "Garten",
                            ShowOrder = 4
                        });
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.Dealer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ApplicationTypeId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CartItemId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortProductDescription")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationTypeId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CartItemId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationTypeId = 1,
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9507),
                            Description = "Parkettmuster Eiche",
                            FullName = "Laminat",
                            ImageUrl = "https://media.cdn.bauhaus/m/736748-1/15.webp",
                            Price = 10.00m,
                            ShortProductDescription = "Das Laminat Mühltal Eiche besitzt durch markant eingefärbte Äste eine besondere Natürlichkeit und Rustikalität. Der natürliche Farbton des Bodens ist mit vielen Wohnstilen kombinierbar. "
                        },
                        new
                        {
                            Id = 2,
                            ApplicationTypeId = 1,
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9550),
                            Description = "Mit dem Handmuster dieses Fertigparketts können Sie zu Hause ganz in Ruhe über die Gestaltung Ihrer Wohnräume entscheiden.",
                            FullName = "Parkett",
                            ImageUrl = "https://media.cdn.bauhaus/m/1103405-1/12.webp",
                            Price = 20.55m,
                            ShortProductDescription = "Parkettmuster Eiche Vaduz"
                        },
                        new
                        {
                            Id = 3,
                            ApplicationTypeId = 1,
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9554),
                            Description = "Der Kayoom Teppich Cocktail 400 fasziniert mit seiner weichen Haptik in jederlei Hinsicht. Durch die schöne Struktur, die herrlichen Farben und dem natürlichen Material ist dieser handgewebte Teppich eine ideale Bereicherung für ein gemütliches Wohnambiente.",
                            FullName = "Teppich",
                            ImageUrl = "https://media.cdn.bauhaus/m/425344/12.webp",
                            Price = 30.49m,
                            ShortProductDescription = "Kayoom Teppich Cocktail 300"
                        },
                        new
                        {
                            Id = 4,
                            ApplicationTypeId = 1,
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9557),
                            Description = "Die SCHÖNER WOHNEN-Farbe Wandfarbe Universalweiß ist eine waschbeständige Dispersionsfarbe für wasserdampfdurchlässige Neu- und Renovierungsanstriche mit normaler Beanspruchung im Innenbereich. Die Farbe zeichnet sich durch gutes Deckvermögen, leichte Verarbeitung und einer matten Oberfläche aus.",
                            FullName = "Farbe",
                            ImageUrl = "https://media.cdn.bauhaus/m/730803/12.webp",
                            Price = 40.89m,
                            ShortProductDescription = "SCHÖNER WOHNEN-Farbe Wandfarbe Universalweiß"
                        },
                        new
                        {
                            Id = 5,
                            ApplicationTypeId = 2,
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9563),
                            Description = "Das Pinsel-Set ist ein umfangreiches, 10-teiliges Set. Enthalten sind neben verschiedenen Schulmalpinseln bzw.",
                            FullName = "Pinsel",
                            ImageUrl = "https://media.cdn.bauhaus/m/502545/12.webp",
                            Price = 10.49m,
                            ShortProductDescription = "Pinsel-Set"
                        },
                        new
                        {
                            Id = 6,
                            ApplicationTypeId = 2,
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9566),
                            Description = "Der swingcolor Lammfell-Roller überzeugt durch seine gute Farbaufnahme sowie -abgabe und sorgt für ein strukturarmes Streichergebnis",
                            FullName = "Rolle",
                            ImageUrl = "https://media.cdn.bauhaus/m/575332/12.webp",
                            Price = 5.69m,
                            ShortProductDescription = "swingcolor Lammfell-Roller"
                        },
                        new
                        {
                            Id = 7,
                            ApplicationTypeId = 2,
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9569),
                            Description = "Der Schlosserhammer von Wisent ist der ideale Hammer für jeden Heim- und Handwerker.",
                            FullName = "Hammer",
                            ImageUrl = "https://media.cdn.bauhaus/m/493758/12.webp",
                            Price = 12.78m,
                            ShortProductDescription = "Wisent Schlosserhammer"
                        },
                        new
                        {
                            Id = 8,
                            ApplicationTypeId = 2,
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9572),
                            Description = "Das Schraubendreher- und Bit-Set von Alpha Tools ist ein praktisches 70-teiliges Set für anspruchsvolle Heim- und Handwerker. Mit ihm kann nahezu jede Schraubenart problemlos gelöst und festgedreht werden.",
                            FullName = "Schraubenzieher",
                            ImageUrl = "https://media.cdn.bauhaus/m/1211103/12.webp",
                            Price = 15.99m,
                            ShortProductDescription = "Alpha Tools Schraubendreher-Set"
                        },
                        new
                        {
                            Id = 9,
                            ApplicationTypeId = 2,
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9576),
                            Description = "Die Mehrzweckschraube Turbo Drill ist für verschiedenste Holzverbindungen geeignet. Der TX-Kopf für TORX-Antriebe sorgt für eine gute Kraftübertragung vom Eindrehwerkzeug auf die Schraube.",
                            FullName = "Schrauben",
                            ImageUrl = "https://media.cdn.bauhaus/m/338101/12.webp",
                            Price = 7.49m,
                            ShortProductDescription = "Profi Depot Mehrzweck-Schraube Turbo Drill"
                        },
                        new
                        {
                            Id = 10,
                            ApplicationTypeId = 1,
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9580),
                            Description = "Der Beistelltisch kommt mit einem urbanen, an dem Minimalismus angelehnten, Design daher. Das Trendmaterial Mangoholz kommt hier sehr gut zur Geltung und ergänzt das schlichte Gestell aus Metall ideal.",
                            FullName = "Tisch",
                            ImageUrl = "https://media.cdn.bauhaus/m/136478-1/12.webp",
                            Price = 59.99m,
                            ShortProductDescription = "Beistelltisch"
                        },
                        new
                        {
                            Id = 11,
                            ApplicationTypeId = 1,
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9582),
                            Description = "Der Diningsessel Sonja aus strapazierfähigem Kunststoff zeichnet sich durch seine ergonomisch geformte Sitzschale mit Regenwasserablauf-Spalten aus.",
                            FullName = "Stuhl",
                            ImageUrl = "https://media.cdn.bauhaus/m/632456/12.webp",
                            Price = 99.99m,
                            ShortProductDescription = "Sunfun Gartensessel Falun"
                        },
                        new
                        {
                            Id = 12,
                            ApplicationTypeId = 1,
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9587),
                            Description = "Das Melina Loungesofa von Sunfun verfügt über ein robustes Aluminiumgestell, welches stabil aber zugleich angenehm leicht ist. So kann das Sofa bei Bedarf ohne große Anstrengungen umgestellt werden.",
                            FullName = "Sofa",
                            ImageUrl = "https://media.cdn.bauhaus/m/1114013/12.webp",
                            Price = 249.49m,
                            ShortProductDescription = "Sunfun Melina Loungesofa"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.ApplicationType", b =>
                {
                    b.HasOne("BaumarktSystem.Data.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.Category", b =>
                {
                    b.HasOne("BaumarktSystem.Data.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.Dealer", b =>
                {
                    b.HasOne("BaumarktSystem.Data.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.Product", b =>
                {
                    b.HasOne("BaumarktSystem.Data.Models.ApplicationType", "ApplicationType")
                        .WithMany("Products")
                        .HasForeignKey("ApplicationTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BaumarktSystem.Data.Models.ApplicationUser", null)
                        .WithMany("Products")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("BaumarktSystem.Data.Models.CartItem", null)
                        .WithMany("Products")
                        .HasForeignKey("CartItemId");

                    b.HasOne("BaumarktSystem.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationType");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("BaumarktSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("BaumarktSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaumarktSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("BaumarktSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.ApplicationType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.CartItem", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BaumarktSystem.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
