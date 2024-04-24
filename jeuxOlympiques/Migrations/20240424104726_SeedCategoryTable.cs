using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace jeuxOlympiques.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, "Ce ticket est valable pour 1 personne", 1, "Ticket Solo" },
                    { 2, "Ce ticket est valable pour 2 personnes", 2, "Ticket Duo" },
                    { 3, "Ce ticket est valable pour 4 personnes", 3, "Ticket Famille" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
