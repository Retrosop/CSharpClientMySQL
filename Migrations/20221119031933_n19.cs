using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_Tovarid",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "Tovarid",
                table: "prihod",
                newName: "TovarId");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_Tovarid",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_TovarId",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "TovarId",
                table: "prihod",
                newName: "Tovarid");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_TovarId",
                table: "prihod",
                newName: "IX_prihod_Tovarid");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_Tovarid",
                table: "prihod",
                column: "Tovarid",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
