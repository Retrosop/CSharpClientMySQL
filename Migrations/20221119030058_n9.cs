using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_tovar_IdTovar",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "tovar_IdTovar",
                table: "prihod",
                newName: "_IdTovar");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_tovar_IdTovar",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar__IdTovar",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "_IdTovar",
                table: "prihod",
                newName: "tovar_IdTovar");

            migrationBuilder.RenameIndex(
                name: "IX_prihod__IdTovar",
                table: "prihod",
                newName: "IX_prihod_tovar_IdTovar");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_tovar_IdTovar",
                table: "prihod",
                column: "tovar_IdTovar",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
