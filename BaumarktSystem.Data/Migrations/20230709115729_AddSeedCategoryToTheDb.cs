using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaumarktSystem.Data.Migrations
{
    public partial class AddSeedCategoryToTheDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ShowOrder" },
                values: new object[,]
                {
                    { 1, "Bodenbeläge", 1 },
                    { 2, "Farben", 2 },
                    { 3, "Werkzeuge", 3 },
                    { 4, "Garten", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
