using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myWpf.Migrations
{
    public partial class n26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdPostav",
                table: "prihod",
                newName: "PostavId");

            migrationBuilder.CreateIndex(
                name: "IX_prihod_PostavId",
                table: "prihod",
                column: "PostavId");

            migrationBuilder.AddForeignKey(
                name: "FK_prihod_postav_PostavId",
                table: "prihod",
                column: "PostavId",
                principalTable: "postav",
                principalColumn: "IdPostav",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prihod_postav_PostavId",
                table: "prihod");

            migrationBuilder.DropIndex(
                name: "IX_prihod_PostavId",
                table: "prihod");

            migrationBuilder.RenameColumn(
                name: "PostavId",
                table: "prihod",
                newName: "IdPostav");
        }
    }
}
