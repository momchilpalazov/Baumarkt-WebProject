using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class AddCreatorIdToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
            name: "CreatorId",
            table: "Category",
            nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_CreatorId",
                table: "Category",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_AspNetUsers_CreatorId",
                table: "Category",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
           name: "FK_Category_AspNetUsers_CreatorId",
           table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_CreatorId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Category");
        }
    }
}
