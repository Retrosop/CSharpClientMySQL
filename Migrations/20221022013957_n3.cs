using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "prihod",
                columns: table => new
                {
                    IdPrihod = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPostav = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    IdTovar = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Kolvo = table.Column<int>(type: "INT(4)", nullable: false),
                    DatPrih = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prihod", x => x.IdPrihod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "prihod");
        }
    }
}
