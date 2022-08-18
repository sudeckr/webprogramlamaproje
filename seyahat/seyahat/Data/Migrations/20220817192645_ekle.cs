using Microsoft.EntityFrameworkCore.Migrations;

namespace seyahat.Data.Migrations
{
    public partial class ekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlar_Blog_BlogId",
                table: "Yorumlar");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "Yorumlar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlar_Blog_BlogId",
                table: "Yorumlar",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlar_Blog_BlogId",
                table: "Yorumlar");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "Yorumlar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlar_Blog_BlogId",
                table: "Yorumlar",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
