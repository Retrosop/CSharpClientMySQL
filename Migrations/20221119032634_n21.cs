using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_DescriptionID",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "DescriptionID",
                table: "prihod",
                newName: "IdTovar");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_DescriptionID",
                table: "prihod",
                newName: "IX_prihod_IdTovar");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_IdTovar",
                table: "prihod",
                column: "IdTovar",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_IdTovar",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "IdTovar",
                table: "prihod",
                newName: "DescriptionID");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_IdTovar",
                table: "prihod",
                newName: "IX_prihod_DescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_DescriptionID",
                table: "prihod",
                column: "DescriptionID",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
