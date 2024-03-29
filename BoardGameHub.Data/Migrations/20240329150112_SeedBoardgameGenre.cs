using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class SeedBoardgameGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoardgameGenreBoardgameId",
                table: "BoardgamesGenres",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BoardgameGenreGenreId",
                table: "BoardgamesGenres",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BoardgamesGenres",
                columns: new[] { "BoardgameId", "GenreId", "BoardgameGenreBoardgameId", "BoardgameGenreGenreId" },
                values: new object[] { 1, 17, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_BoardgamesGenres_BoardgameGenreBoardgameId_BoardgameGenreGenreId",
                table: "BoardgamesGenres",
                columns: new[] { "BoardgameGenreBoardgameId", "BoardgameGenreGenreId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BoardgamesGenres_BoardgamesGenres_BoardgameGenreBoardgameId_BoardgameGenreGenreId",
                table: "BoardgamesGenres",
                columns: new[] { "BoardgameGenreBoardgameId", "BoardgameGenreGenreId" },
                principalTable: "BoardgamesGenres",
                principalColumns: new[] { "BoardgameId", "GenreId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoardgamesGenres_BoardgamesGenres_BoardgameGenreBoardgameId_BoardgameGenreGenreId",
                table: "BoardgamesGenres");

            migrationBuilder.DropIndex(
                name: "IX_BoardgamesGenres_BoardgameGenreBoardgameId_BoardgameGenreGenreId",
                table: "BoardgamesGenres");

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DropColumn(
                name: "BoardgameGenreBoardgameId",
                table: "BoardgamesGenres");

            migrationBuilder.DropColumn(
                name: "BoardgameGenreGenreId",
                table: "BoardgamesGenres");
        }
    }
}
