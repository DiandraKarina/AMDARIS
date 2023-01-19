using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_Category_CategoryId",
                table: "BlogPosts");

            migrationBuilder.DropIndex(
                name: "IX_BlogPosts_CategoryId",
                table: "BlogPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "BlogPosts");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "BlogPostId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BlogPostId",
                table: "Categories",
                column: "BlogPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_BlogPosts_BlogPostId",
                table: "Categories",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "BlogPostId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_BlogPosts_BlogPostId",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_BlogPostId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BlogPostId",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "BlogPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_CategoryId",
                table: "BlogPosts",
                column: "CategoryId",
                unique: true);

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
