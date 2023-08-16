using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class AddTableInquiryDetailsAndHeaderChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_CartItem_CartItemId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CartItemId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("24d83a6a-76e4-4610-9e78-06216472439d"));

            migrationBuilder.DropColumn(
                name: "CartItemId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "InquiryDetails");

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 122, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 122, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0cd9ad89-9a9b-4892-b77a-bc1215861865"), 0, "9716c2a5-bcd7-4c57-bde5-f7ea18fde3ec", null, false, "UserUserov", false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 122, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 122, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 122, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 122, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 17, 42, 10, 123, DateTimeKind.Local).AddTicks(1615));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0cd9ad89-9a9b-4892-b77a-bc1215861865"));

            migrationBuilder.AddColumn<int>(
                name: "CartItemId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "InquiryDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 573, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 573, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("24d83a6a-76e4-4610-9e78-06216472439d"), 0, "7084438a-945d-4ca9-8b3c-4b9f2ac25d5d", null, false, "UserUserov", false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 573, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 573, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 573, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 573, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 16, 11, 17, 23, 574, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.CreateIndex(
                name: "IX_Product_CartItemId",
                table: "Product",
                column: "CartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CartItem_CartItemId",
                table: "Product",
                column: "CartItemId",
                principalTable: "CartItem",
                principalColumn: "Id");
        }
    }
}
