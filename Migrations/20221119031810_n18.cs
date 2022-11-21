using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_TovarIdTovar",
                table: "prihod");

            migrationBuilder.DropIndex(
                name: "IX_prihod_TovarIdTovar",
                table: "prihod");

            migrationBuilder.DropColumn(
                name: "TovarIdTovar",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "IdTovar",
                table: "prihod",
                newName: "Tovarid");

            migrationBuilder.CreateIndex(
                name: "IX_prihod_Tovarid",
                table: "prihod",
                column: "Tovarid");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_Tovarid",
                table: "prihod",
                column: "Tovarid",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_Tovarid",
                table: "prihod");

            migrationBuilder.DropIndex(
                name: "IX_prihod_Tovarid",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "Tovarid",
                table: "prihod",
                newName: "IdTovar");

            migrationBuilder.AddColumn<int>(
                name: "TovarIdTovar",
                table: "prihod",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_prihod_TovarIdTovar",
                table: "prihod",
                column: "TovarIdTovar");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_TovarIdTovar",
                table: "prihod",
                column: "TovarIdTovar",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
