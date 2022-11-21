using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "goods3");

            migrationBuilder.AddColumn<int>(
                name: "tovar_IdTovar",
                table: "prihod",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_prihod_tovar_IdTovar",
                table: "prihod",
                column: "tovar_IdTovar");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_tovar_IdTovar",
                table: "prihod",
                column: "tovar_IdTovar",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_tovar_IdTovar",
                table: "prihod");

            migrationBuilder.DropIndex(
                name: "IX_prihod_tovar_IdTovar",
                table: "prihod");

            migrationBuilder.DropColumn(
                name: "tovar_IdTovar",
                table: "prihod");

            migrationBuilder.CreateTable(
                name: "goods3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cena = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goods3", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
