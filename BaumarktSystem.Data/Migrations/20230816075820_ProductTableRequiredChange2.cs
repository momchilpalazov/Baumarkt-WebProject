using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class ProductTableRequiredChange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0a2b1fa3-04d8-42eb-81b9-743ed86012f1"));

            migrationBuilder.AlterColumn<string>(
                name: "ShortProductDescription",
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
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3ebf4140-144a-4eae-b831-13f9e714c7f5"), 0, "f3d095e2-76ca-48f9-b1ac-5e73e012044e", null, false, "UserUserov", false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 9, 58, 19, 173, DateTimeKind.Local).AddTicks(7806));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3ebf4140-144a-4eae-b831-13f9e714c7f5"));

            migrationBuilder.AlterColumn<string>(
                name: "ShortProductDescription",
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
    }
}
