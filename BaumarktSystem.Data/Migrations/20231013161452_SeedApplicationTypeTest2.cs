using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class SeedApplicationTypeTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationType",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 13, 18, 14, 51, 955, DateTimeKind.Local).AddTicks(531), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Haus" },
                    { 2, new DateTime(2023, 10, 13, 18, 14, 51, 955, DateTimeKind.Local).AddTicks(598), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Werkstatt" }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 13, 18, 14, 51, 955, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 13, 18, 14, 51, 955, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 13, 18, 14, 51, 955, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 13, 18, 14, 51, 955, DateTimeKind.Local).AddTicks(945));
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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 13, 18, 13, 23, 893, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 13, 18, 13, 23, 893, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 13, 18, 13, 23, 893, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 13, 18, 13, 23, 893, DateTimeKind.Local).AddTicks(7272));
        }
    }
}
