using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDogApp.API.Migrations
{
    public partial class CustomLiked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Likes_LikeeId",
                table: "Likes");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Likes_LikeeId_LikerId",
                table: "Likes",
                columns: new[] { "LikeeId", "LikerId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Likes_LikeeId_LikerId",
                table: "Likes");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_LikeeId",
                table: "Likes",
                column: "LikeeId");
        }
    }
}
