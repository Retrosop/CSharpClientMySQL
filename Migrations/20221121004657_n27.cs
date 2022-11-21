using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "test");

            migrationBuilder.RenameColumn(
                name: "IdUlica",
                table: "postav",
                newName: "UlicaId");

            migrationBuilder.RenameColumn(
                name: "IdGorod",
                table: "postav",
                newName: "GorodId");

            migrationBuilder.CreateIndex(
                name: "IX_postav_GorodId",
                table: "postav",
                column: "GorodId");

            migrationBuilder.CreateIndex(
                name: "IX_postav_UlicaId",
                table: "postav",
                column: "UlicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_postav_gorod_GorodId",
                table: "postav",
                column: "GorodId",
                principalTable: "gorod",
                principalColumn: "IdGorod",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_postav_ulica_UlicaId",
                table: "postav",
                column: "UlicaId",
                principalTable: "ulica",
                principalColumn: "IdUlica",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postav_gorod_GorodId",
                table: "postav");

            migrationBuilder.DropForeignKey(
                name: "FK_postav_ulica_UlicaId",
                table: "postav");

            migrationBuilder.DropIndex(
                name: "IX_postav_GorodId",
                table: "postav");

            migrationBuilder.DropIndex(
                name: "IX_postav_UlicaId",
                table: "postav");

            migrationBuilder.RenameColumn(
                name: "UlicaId",
                table: "postav",
                newName: "IdUlica");

            migrationBuilder.RenameColumn(
                name: "GorodId",
                table: "postav",
                newName: "IdGorod");

            migrationBuilder.CreateTable(
                name: "test",
                columns: table => new
                {
                    IdTest = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_test", x => x.IdTest);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
