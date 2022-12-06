using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_Category_CategoryId",
                table: "BlogPosts");

            migrationBuilder.DropIndex(
                name: "IX_BlogPosts_CategoryId",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "BlogPosts");

            migrationBuilder.AddColumn<int>(
                name: "BlogPostId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Category_BlogPostId",
                table: "Category",
                column: "BlogPostId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_BlogPosts_BlogPostId",
                table: "Category",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "BlogPostId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_BlogPosts_BlogPostId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_BlogPostId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "BlogPostId",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "BlogPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_CategoryId",
                table: "BlogPosts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_Category_CategoryId",
                table: "BlogPosts",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
