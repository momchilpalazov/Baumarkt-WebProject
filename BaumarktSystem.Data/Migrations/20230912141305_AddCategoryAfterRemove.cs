using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class AddCategoryAfterRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "CreatorId", "Name", "ShowOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 9, 12, 16, 13, 5, 407, DateTimeKind.Local).AddTicks(677), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Bodenbeläge", 1 },
                    { 2, null, new DateTime(2023, 9, 12, 16, 13, 5, 407, DateTimeKind.Local).AddTicks(786), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Farben", 2 },
                    { 3, null, new DateTime(2023, 9, 12, 16, 13, 5, 407, DateTimeKind.Local).AddTicks(796), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Werkzeuge", 3 },
                    { 4, null, new DateTime(2023, 9, 12, 16, 13, 5, 407, DateTimeKind.Local).AddTicks(803), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Garten", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
