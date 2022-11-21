using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n25 : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "TovarId",
                table: "prihod",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_prihod_TovarId",
                table: "prihod",
                column: "TovarId");

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

            migrationBuilder.DropIndex(
                name: "IX_prihod_TovarId",
                table: "prihod");

            migrationBuilder.DropColumn(
                name: "TovarId",
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
    }
}
