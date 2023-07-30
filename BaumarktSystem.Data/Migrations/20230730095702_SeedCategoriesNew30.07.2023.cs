using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class SeedCategoriesNew30072023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 30, 11, 57, 1, 646, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 30, 11, 57, 1, 646, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Name", "ShowOrder" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 30, 11, 57, 1, 646, DateTimeKind.Local).AddTicks(994), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Bodenbeläge", 1 },
                    { 2, new DateTime(2023, 7, 30, 11, 57, 1, 646, DateTimeKind.Local).AddTicks(1011), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Farben", 2 },
                    { 3, new DateTime(2023, 7, 30, 11, 57, 1, 646, DateTimeKind.Local).AddTicks(1018), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Werkzeuge", 3 },
                    { 4, new DateTime(2023, 7, 30, 11, 57, 1, 646, DateTimeKind.Local).AddTicks(1026), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Garten", 4 }
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

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 30, 11, 54, 11, 780, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 30, 11, 54, 11, 780, DateTimeKind.Local).AddTicks(4307));
        }
    }
}
