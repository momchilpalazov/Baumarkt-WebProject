using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class SeedCategories30072023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Name", "ShowOrder" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 30, 11, 51, 3, 783, DateTimeKind.Local).AddTicks(2268), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Bodenbeläge", 1 },
                    { 2, new DateTime(2023, 7, 30, 11, 51, 3, 783, DateTimeKind.Local).AddTicks(2327), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Farben", 2 },
                    { 3, new DateTime(2023, 7, 30, 11, 51, 3, 783, DateTimeKind.Local).AddTicks(2331), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Werkzeuge", 3 },
                    { 4, new DateTime(2023, 7, 30, 11, 51, 3, 783, DateTimeKind.Local).AddTicks(2334), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Garten", 4 }
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
