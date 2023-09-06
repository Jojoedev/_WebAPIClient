using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _WebAPIClient.Migrations
{
    public partial class SeedingInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Quantity" },
                values: new object[] { 1, "Beverages", "Bournvita", 10 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Quantity" },
                values: new object[] { 2, "Wine", "Jameson", 23 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Quantity" },
                values: new object[] { 3, "Spice", "Pepper", 65 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
