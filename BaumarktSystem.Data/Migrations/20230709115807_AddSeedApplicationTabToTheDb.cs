using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class AddSeedApplicationTabToTheDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
