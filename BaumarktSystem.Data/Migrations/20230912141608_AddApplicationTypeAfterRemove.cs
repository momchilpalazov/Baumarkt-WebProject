using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class AddApplicationTypeAfterRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationType",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 12, 16, 16, 7, 615, DateTimeKind.Local).AddTicks(423), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Haus" },
                    { 2, new DateTime(2023, 9, 12, 16, 16, 7, 615, DateTimeKind.Local).AddTicks(493), new Guid("ae6cebee-8421-4d00-8213-35b95ab97239"), "Werkstatt" }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 16, 16, 7, 615, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 16, 16, 7, 615, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 16, 16, 7, 615, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 16, 16, 7, 615, DateTimeKind.Local).AddTicks(797));
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
                value: new DateTime(2023, 9, 12, 16, 13, 5, 407, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 16, 13, 5, 407, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 16, 13, 5, 407, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 16, 13, 5, 407, DateTimeKind.Local).AddTicks(803));
        }
    }
}
