using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class AddAppTypeCreatorAndCreatedOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ApplicationType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "ApplicationType",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationType_CreatorId",
                table: "ApplicationType",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationType_AspNetUsers_CreatorId",
                table: "ApplicationType",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationType_AspNetUsers_CreatorId",
                table: "ApplicationType");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationType_CreatorId",
                table: "ApplicationType");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ApplicationType");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "ApplicationType");
        }
    }
}
