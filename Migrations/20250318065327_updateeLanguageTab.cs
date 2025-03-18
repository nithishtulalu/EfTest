using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFTEST.Migrations
{
    /// <inheritdoc />
    public partial class updateeLanguageTab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Languages",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "English Language", "English" },
                    { 2, "Spanish Language", "Spanish" },
                    { 3, "French Language", "French" },
                    { 4, "German Language", "German" },
                    { 5, "Chinese Language", "Chinese" },
                    { 6, "Japanese Language", "Japanese" },
                    { 7, "Hindi Language", "Hindi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Languages",
                newName: "Discription");
        }
    }
}
