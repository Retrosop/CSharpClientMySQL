using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar__IdTovar",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "_IdTovar",
                table: "prihod",
                newName: "IdTovar1");

            migrationBuilder.RenameIndex(
                name: "IX_prihod__IdTovar",
                table: "prihod",
                newName: "IX_prihod_IdTovar1");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_IdTovar1",
                table: "prihod",
                column: "IdTovar1",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_IdTovar1",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "IdTovar1",
                table: "prihod",
                newName: "_IdTovar");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_IdTovar1",
                table: "prihod",
                newName: "IX_prihod__IdTovar");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar__IdTovar",
                table: "prihod",
                column: "_IdTovar",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
