using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_TovarId",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "TovarId",
                table: "prihod",
                newName: "DescriptionID");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_TovarId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_DescriptionID",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "DescriptionID",
                table: "prihod",
                newName: "TovarId");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_DescriptionID",
                table: "prihod",
                newName: "IX_prihod_TovarId");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_TovarId",
                table: "prihod",
                column: "TovarId",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
