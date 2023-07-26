using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class SeedCategoryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Name", "ShowOrder" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 25, 19, 38, 44, 202, DateTimeKind.Local).AddTicks(2878), new Guid("3f442614-2db4-4f9c-8c19-50bc2ee3d01e"), "Bodenbeläge", 1 },
                    { 2, new DateTime(2023, 7, 25, 19, 38, 44, 202, DateTimeKind.Local).AddTicks(2945), new Guid("3f442614-2db4-4f9c-8c19-50bc2ee3d01e"), "Farben", 2 },
                    { 3, new DateTime(2023, 7, 25, 19, 38, 44, 202, DateTimeKind.Local).AddTicks(2948), new Guid("3f442614-2db4-4f9c-8c19-50bc2ee3d01e"), "Werkzeuge", 3 },
                    { 4, new DateTime(2023, 7, 25, 19, 38, 44, 202, DateTimeKind.Local).AddTicks(2951), new Guid("3f442614-2db4-4f9c-8c19-50bc2ee3d01e"), "Garten", 4 }
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
