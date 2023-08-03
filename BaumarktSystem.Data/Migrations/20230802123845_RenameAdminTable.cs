using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class RenameAdminTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_AspNetUsers_CreatorId",
                table: "Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "Dealer");

            migrationBuilder.RenameIndex(
                name: "IX_Admin_CreatorId",
                table: "Dealer",
                newName: "IX_Dealer_CreatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dealer",
                table: "Dealer",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 352, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 352, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 352, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 352, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 352, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 352, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 38, 45, 353, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.AddForeignKey(
                name: "FK_Dealer_AspNetUsers_CreatorId",
                table: "Dealer",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dealer_AspNetUsers_CreatorId",
                table: "Dealer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dealer",
                table: "Dealer");

            migrationBuilder.RenameTable(
                name: "Dealer",
                newName: "Admin");

            migrationBuilder.RenameIndex(
                name: "IX_Dealer_CreatorId",
                table: "Admin",
                newName: "IX_Admin_CreatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 367, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 367, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 367, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 367, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 367, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 367, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 2, 14, 29, 8, 368, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_AspNetUsers_CreatorId",
                table: "Admin",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
