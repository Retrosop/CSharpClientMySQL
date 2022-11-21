using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar__IdTovarIdTovar",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "_IdTovarIdTovar",
                table: "prihod",
                newName: "TovarIdTovar");

            migrationBuilder.RenameIndex(
                name: "IX_prihod__IdTovarIdTovar",
                table: "prihod",
                newName: "IX_prihod_TovarIdTovar");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_TovarIdTovar",
                table: "prihod",
                column: "TovarIdTovar",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_TovarIdTovar",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "TovarIdTovar",
                table: "prihod",
                newName: "_IdTovarIdTovar");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_TovarIdTovar",
                table: "prihod",
                newName: "IX_prihod__IdTovarIdTovar");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar__IdTovarIdTovar",
                table: "prihod",
                column: "_IdTovarIdTovar",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
