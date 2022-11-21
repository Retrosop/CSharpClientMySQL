using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_tovar_Id1TovarIdTovar",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "Id1TovarIdTovar",
                table: "prihod",
                newName: "TovarIdTovar");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_Id1TovarIdTovar",
                table: "prihod",
                newName: "IX_prihod_TovarIdTovar");

            migrationBuilder.AddColumn<int>(
                name: "IdTovar",
                table: "prihod",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropColumn(
                name: "IdTovar",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "TovarIdTovar",
                table: "prihod",
                newName: "Id1TovarIdTovar");

            migrationBuilder.RenameIndex(
                name: "IX_prihod_TovarIdTovar",
                table: "prihod",
                newName: "IX_prihod_Id1TovarIdTovar");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_tovar_Id1TovarIdTovar",
                table: "prihod",
                column: "Id1TovarIdTovar",
                principalTable: "tovar",
                principalColumn: "IdTovar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
