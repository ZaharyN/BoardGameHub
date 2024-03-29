using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class Seed_DuneBoardgame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boardgames",
                columns: new[] { "Id", "AveragePlayingTime", "Description", "Difficulty", "ImageUrl", "IsReserved", "IsUpcoming", "MaximumPlayersAllowedToPlay", "MinimumPlayersAllowedToPlay", "Name", "PriceInShop", "Rating", "ReservationId", "YearPublished" },
                values: new object[] { 1, 90, "Dune: Imperium is a game that uses deck-building to add a hidden-information angle to traditional worker placement. It finds inspiration in elements and characters from the Dune legacy, both the new film from Legendary Pictures and the seminal literary series from Frank Herbert, Brian Herbert, and Kevin J.Anderson.As a leader of one of the Great Houses of the   Landsraad, raise your banner and marshal your forces and spies. War is coming, and at the center of the conflict is Arrakis – Dune, the desert planet.", 3.0, "~/assets/games/Dune_Imperium.jpg", false, false, 4, 1, "Dune: Imperium", 90.00m, null, null, 2020 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
