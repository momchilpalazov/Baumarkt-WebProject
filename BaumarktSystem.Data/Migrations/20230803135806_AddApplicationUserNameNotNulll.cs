using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class AddApplicationUserNameNotNulll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValue: "UserUserov");

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("961dd96d-1176-4855-87c6-92ce2175f6ac"), 0, "670f570a-34aa-464c-af53-18dbd0030b4f", null, false, false, null, "UserUserov", null, null, null, null, false, null, false, null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 15, 58, 5, 666, DateTimeKind.Local).AddTicks(5977));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("961dd96d-1176-4855-87c6-92ce2175f6ac"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValue: "UserUserov",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 508, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 508, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 509, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 509, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 509, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 509, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 3, 14, 52, 52, 510, DateTimeKind.Local).AddTicks(5533));
        }
    }
}
