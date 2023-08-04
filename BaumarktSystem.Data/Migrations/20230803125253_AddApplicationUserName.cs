using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class AddApplicationUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 22, 28, 16, 754, DateTimeKind.Local).AddTicks(9587));
        }
    }
}
