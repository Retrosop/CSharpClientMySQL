using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_IdTovar1",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "IdTovar1",
                table: "prihod",
                newName: "_IdTovarIdTovar");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_IdTovar1",
                table: "prihod",
                newName: "IX_prihod__IdTovarIdTovar");

            migrationBuilder.AddColumn<int>(
                name: "IdTovar",
                table: "prihod",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar__IdTovarIdTovar",
                table: "prihod",
                column: "_IdTovarIdTovar",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar__IdTovarIdTovar",
                table: "prihod");

            migrationBuilder.DropColumn(
                name: "IdTovar",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "_IdTovarIdTovar",
                table: "prihod",
                newName: "IdTovar1");

            migrationBuilder.RenameIndex(
                name: "IX_prihod__IdTovarIdTovar",
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
    }
}
