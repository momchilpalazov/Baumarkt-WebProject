using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class ChangeProductFullNameTrue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0f4b2abd-1077-4974-89d6-ceed9aa263b6"));

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 381, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 381, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cf6ff543-7fa9-4d73-8673-84ae6bf854dd"), 0, "72f32974-8044-449e-aa09-3506d06a0289", null, false, "UserUserov", false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 381, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 381, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 381, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 381, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 13, 9, 0, 52, 382, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryId",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_CategoryId",
                table: "Category",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_CategoryId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_CategoryId",
                table: "Category");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf6ff543-7fa9-4d73-8673-84ae6bf854dd"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0f4b2abd-1077-4974-89d6-ceed9aa263b6"), 0, "a2dbbbfc-15a8-4adc-8615-6f1605b73448", null, false, "UserUserov", false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 4, 10, 59, 23, 816, DateTimeKind.Local).AddTicks(8386));
        }
    }
}
