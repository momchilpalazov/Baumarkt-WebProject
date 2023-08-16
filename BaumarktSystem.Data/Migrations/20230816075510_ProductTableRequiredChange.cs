using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class ProductTableRequiredChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f0eb61d3-4428-4689-89bc-5bffb954d48e"));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Product",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 10000);

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0a2b1fa3-04d8-42eb-81b9-743ed86012f1"), 0, "43ba9d12-f504-4fa4-ad14-ee455a64ca86", null, false, "UserUserov", false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 55, 9, 977, DateTimeKind.Local).AddTicks(5761));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0a2b1fa3-04d8-42eb-81b9-743ed86012f1"));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Product",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 10000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f0eb61d3-4428-4689-89bc-5bffb954d48e"), 0, "60849ca4-97f6-42d3-8de4-288e4e28013a", null, false, "UserUserov", false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 15, 16, 36, 20, 76, DateTimeKind.Local).AddTicks(5176));
        }
    }
}
