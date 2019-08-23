using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "weddings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_weddings_UserId",
                table: "weddings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_responses_WeddingId",
                table: "responses",
                column: "WeddingId");

            migrationBuilder.AddForeignKey(
                name: "FK_responses_weddings_WeddingId",
                table: "responses",
                column: "WeddingId",
                principalTable: "weddings",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_weddings_users_UserId",
                table: "weddings",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_responses_weddings_WeddingId",
                table: "responses");

            migrationBuilder.DropForeignKey(
                name: "FK_weddings_users_UserId",
                table: "weddings");

            migrationBuilder.DropIndex(
                name: "IX_weddings_UserId",
                table: "weddings");

            migrationBuilder.DropIndex(
                name: "IX_responses_WeddingId",
                table: "responses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "weddings");
        }
    }
}
