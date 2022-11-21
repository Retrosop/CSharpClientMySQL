using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_IdTovar",
                table: "prihod");

            migrationBuilder.DropIndex(
                name: "IX_prihod_IdTovar",
                table: "prihod");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_prihod_IdTovar",
                table: "prihod",
                column: "IdTovar");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_IdTovar",
                table: "prihod",
                column: "IdTovar",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
