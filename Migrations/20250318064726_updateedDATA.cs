using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFTEST.Migrations
{
    /// <inheritdoc />
    public partial class updateedDATA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_CurrencyTypes_CurrencyTypeid",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Curenccyid",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Discerption",
                table: "CurrencyTypes",
                newName: "Description");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyTypeid",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "BookPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CurrencyTypeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookPrices_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookPrices_CurrencyTypes_CurrencyTypeid",
                        column: x => x.CurrencyTypeid,
                        principalTable: "CurrencyTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CurrencyTypes",
                columns: new[] { "id", "Currency", "Description" },
                values: new object[,]
                {
                    { 1, "INR", "Indian Rupee" },
                    { 2, "USD", "US Dollar" },
                    { 3, "EUR", "Euro" },
                    { 4, "GBP", "British Pound" },
                    { 5, "JPY", "Japanese Yen" },
                    { 6, "AUD", "Australian Dollar" },
                    { 7, "CAD", "Canadian Dollar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrices",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_CurrencyTypeid",
                table: "BookPrices",
                column: "CurrencyTypeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_CurrencyTypes_CurrencyTypeid",
                table: "Books",
                column: "CurrencyTypeid",
                principalTable: "CurrencyTypes",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_CurrencyTypes_CurrencyTypeid",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookPrices");

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "CurrencyTypes",
                newName: "Discerption");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyTypeid",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Curenccyid",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_CurrencyTypes_CurrencyTypeid",
                table: "Books",
                column: "CurrencyTypeid",
                principalTable: "CurrencyTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
