using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class SeedApplicationType30072023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ApplicationType",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Name" },
                values: new object[] { 1, new DateTime(2023, 7, 30, 11, 54, 11, 780, DateTimeKind.Local).AddTicks(4201), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Haus" });

            migrationBuilder.InsertData(
                table: "ApplicationType",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Name" },
                values: new object[] { 2, new DateTime(2023, 7, 30, 11, 54, 11, 780, DateTimeKind.Local).AddTicks(4307), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Werkstatt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
