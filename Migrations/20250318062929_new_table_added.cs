using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTEST.Migrations
{
    /// <inheritdoc />
    public partial class new_table_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Curenccyid",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyTypeid",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CurrencyTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discerption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyTypes", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CurrencyTypeid",
                table: "Books",
                column: "CurrencyTypeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_CurrencyTypes_CurrencyTypeid",
                table: "Books",
                column: "CurrencyTypeid",
                principalTable: "CurrencyTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_CurrencyTypes_CurrencyTypeid",
                table: "Books");

            migrationBuilder.DropTable(
                name: "CurrencyTypes");

            migrationBuilder.DropIndex(
                name: "IX_Books_CurrencyTypeid",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Curenccyid",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CurrencyTypeid",
                table: "Books");
        }
    }
}
