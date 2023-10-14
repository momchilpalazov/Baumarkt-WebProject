using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class ChangeAspNetRolesIdNullableFalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationType",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 13, 20, 13, 0, 283, DateTimeKind.Local).AddTicks(6995), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Haus" },
                    { 2, new DateTime(2023, 9, 13, 20, 13, 0, 283, DateTimeKind.Local).AddTicks(7067), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Werkstatt" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "CreatorId", "Name", "ShowOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 9, 13, 20, 13, 0, 283, DateTimeKind.Local).AddTicks(7432), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Bodenbeläge", 1 },
                    { 2, null, new DateTime(2023, 9, 13, 20, 13, 0, 283, DateTimeKind.Local).AddTicks(7441), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Farben", 2 },
                    { 3, null, new DateTime(2023, 9, 13, 20, 13, 0, 283, DateTimeKind.Local).AddTicks(7444), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Werkzeuge", 3 },
                    { 4, null, new DateTime(2023, 9, 13, 20, 13, 0, 283, DateTimeKind.Local).AddTicks(7448), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Garten", 4 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ApplicationTypeId", "ApplicationUserId", "CategoryId", "CreatedOn", "Description", "FullName", "ImageUrl", "Price", "ShortProductDescription" },
                values: new object[,]
                {
                    { 1, 1, null, 1, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(969), "Parkettmuster Eiche", "Laminat", "https://media.cdn.bauhaus/m/736748-1/15.webp", 10.00m, "Das Laminat Mühltal Eiche besitzt durch markant eingefärbte Äste eine besondere Natürlichkeit und Rustikalität. Der natürliche Farbton des Bodens ist mit vielen Wohnstilen kombinierbar. " },
                    { 2, 1, null, 1, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(990), "Mit dem Handmuster dieses Fertigparketts können Sie zu Hause ganz in Ruhe über die Gestaltung Ihrer Wohnräume entscheiden.", "Parkett", "https://media.cdn.bauhaus/m/1103405-1/12.webp", 20.55m, "Parkettmuster Eiche Vaduz" },
                    { 3, 1, null, 1, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(994), "Der Kayoom Teppich Cocktail 400 fasziniert mit seiner weichen Haptik in jederlei Hinsicht. Durch die schöne Struktur, die herrlichen Farben und dem natürlichen Material ist dieser handgewebte Teppich eine ideale Bereicherung für ein gemütliches Wohnambiente.", "Teppich", "https://media.cdn.bauhaus/m/425344/12.webp", 30.49m, "Kayoom Teppich Cocktail 300" },
                    { 4, 1, null, 2, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(997), "Die SCHÖNER WOHNEN-Farbe Wandfarbe Universalweiß ist eine waschbeständige Dispersionsfarbe für wasserdampfdurchlässige Neu- und Renovierungsanstriche mit normaler Beanspruchung im Innenbereich. Die Farbe zeichnet sich durch gutes Deckvermögen, leichte Verarbeitung und einer matten Oberfläche aus.", "Farbe", "https://media.cdn.bauhaus/m/730803/12.webp", 40.89m, "SCHÖNER WOHNEN-Farbe Wandfarbe Universalweiß" },
                    { 5, 2, null, 2, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(1003), "Das Pinsel-Set ist ein umfangreiches, 10-teiliges Set. Enthalten sind neben verschiedenen Schulmalpinseln bzw.", "Pinsel", "https://media.cdn.bauhaus/m/502545/12.webp", 10.49m, "Pinsel-Set" },
                    { 6, 2, null, 2, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(1006), "Der swingcolor Lammfell-Roller überzeugt durch seine gute Farbaufnahme sowie -abgabe und sorgt für ein strukturarmes Streichergebnis", "Rolle", "https://media.cdn.bauhaus/m/575332/12.webp", 5.69m, "swingcolor Lammfell-Roller" },
                    { 7, 2, null, 3, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(1009), "Der Schlosserhammer von Wisent ist der ideale Hammer für jeden Heim- und Handwerker.", "Hammer", "https://media.cdn.bauhaus/m/493758/12.webp", 12.78m, "Wisent Schlosserhammer" },
                    { 8, 2, null, 3, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(1012), "Das Schraubendreher- und Bit-Set von Alpha Tools ist ein praktisches 70-teiliges Set für anspruchsvolle Heim- und Handwerker. Mit ihm kann nahezu jede Schraubenart problemlos gelöst und festgedreht werden.", "Schraubenzieher", "https://media.cdn.bauhaus/m/1211103/12.webp", 15.99m, "Alpha Tools Schraubendreher-Set" },
                    { 9, 2, null, 3, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(1017), "Die Mehrzweckschraube Turbo Drill ist für verschiedenste Holzverbindungen geeignet. Der TX-Kopf für TORX-Antriebe sorgt für eine gute Kraftübertragung vom Eindrehwerkzeug auf die Schraube.", "Schrauben", "https://media.cdn.bauhaus/m/338101/12.webp", 7.49m, "Profi Depot Mehrzweck-Schraube Turbo Drill" },
                    { 10, 1, null, 4, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(1020), "Der Beistelltisch kommt mit einem urbanen, an dem Minimalismus angelehnten, Design daher. Das Trendmaterial Mangoholz kommt hier sehr gut zur Geltung und ergänzt das schlichte Gestell aus Metall ideal.", "Tisch", "https://media.cdn.bauhaus/m/136478-1/12.webp", 59.99m, "Beistelltisch" },
                    { 11, 1, null, 4, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(1023), "Der Diningsessel Sonja aus strapazierfähigem Kunststoff zeichnet sich durch seine ergonomisch geformte Sitzschale mit Regenwasserablauf-Spalten aus.", "Stuhl", "https://media.cdn.bauhaus/m/632456/12.webp", 99.99m, "Sunfun Gartensessel Falun" },
                    { 12, 1, null, 4, new DateTime(2023, 9, 13, 20, 13, 0, 284, DateTimeKind.Local).AddTicks(1025), "Das Melina Loungesofa von Sunfun verfügt über ein robustes Aluminiumgestell, welches stabil aber zugleich angenehm leicht ist. So kann das Sofa bei Bedarf ohne große Anstrengungen umgestellt werden.", "Sofa", "https://media.cdn.bauhaus/m/1114013/12.webp", 249.49m, "Sunfun Melina Loungesofa" }
                });
        }
    }
}
