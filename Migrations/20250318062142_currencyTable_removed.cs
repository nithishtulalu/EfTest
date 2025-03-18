using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTEST.Migrations
{
    /// <inheritdoc />
    public partial class currencyTable_removed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Currencys_Currencyid",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Currencys");

            migrationBuilder.DropIndex(
                name: "IX_Books_Currencyid",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Curenccyid",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Currencyid",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Curenccyid",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Currencyid",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Currencys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Currency_ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discerption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencys", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Currencyid",
                table: "Books",
                column: "Currencyid");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Currencys_Currencyid",
                table: "Books",
                column: "Currencyid",
                principalTable: "Currencys",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
