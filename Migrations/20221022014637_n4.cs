using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_prihod",
                table: "prihod");

            migrationBuilder.RenameTable(
                name: "prihod",
                newName: "Prihod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prihod",
                table: "Prihod",
                column: "IdPrihod");

            migrationBuilder.CreateTable(
                name: "gorod",
                columns: table => new
                {
                    IdGorod = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gorod", x => x.IdGorod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gorod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prihod",
                table: "Prihod");

            migrationBuilder.RenameTable(
                name: "Prihod",
                newName: "prihod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_prihod",
                table: "prihod",
                column: "IdPrihod");
        }
    }
}
