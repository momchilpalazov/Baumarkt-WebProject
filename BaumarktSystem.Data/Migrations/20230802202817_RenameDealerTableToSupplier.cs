using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class RenameDealerTableToSupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dealer_AspNetUsers_CreatorId",
                table: "Dealer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dealer",
                table: "Dealer");

            migrationBuilder.RenameTable(
                name: "Dealer",
                newName: "Supplier");

            migrationBuilder.RenameIndex(
                name: "IX_Dealer_CreatorId",
                table: "Supplier",
                newName: "IX_Supplier_CreatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_AspNetUsers_CreatorId",
                table: "Supplier",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_AspNetUsers_CreatorId",
                table: "Supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Dealer");

            migrationBuilder.RenameIndex(
                name: "IX_Supplier_CreatorId",
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
    }
}
