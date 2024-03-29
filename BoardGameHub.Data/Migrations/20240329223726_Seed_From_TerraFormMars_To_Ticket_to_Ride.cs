using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class Seed_From_TerraFormMars_To_Ticket_to_Ride : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/assets/games/Dune_Imperium_card.jpg");

            migrationBuilder.InsertData(
                table: "Boardgames",
                columns: new[] { "Id", "AveragePlayingTime", "Description", "Difficulty", "ImageUrl", "IsReserved", "IsUpcoming", "MaximumPlayersAllowedToPlay", "MinimumPlayersAllowedToPlay", "Name", "PriceInShop", "Rating", "ReservationId", "YearPublished" },
                values: new object[,]
                {
                    { 2, 120, "In the 2400s, mankind begins to terraform the planet Mars. Giant corporations, sponsored by the World Government on Earth, initiate huge projects to raise the temperature, the oxygen level, and the ocean coverage until the environment is habitable. In Terraforming Mars, you play one of those corporations and work together in the terraforming process, but compete for getting victory points that are awarded not only for your contribution to the terraforming, but also for advancing human infrastructure throughout the solar system, and doing other commendable things.", 3.5, "~/assets/games/Terraforming_Mars_card.jpg", false, false, 4, 1, "Terraforming Mars", 100.00m, null, null, 2016 },
                    { 3, 90, "In CATAN (formerly The Settlers of Catan), players try to be the dominant force on the island of Catan by building settlements, cities, and roads. On each turn dice are rolled to determine what resources the island produces. Players build by spending resources (sheep, wheat, wood, brick and ore) that are depicted by these resource cards; each land type, with the exception of the unproductive desert, produces a specific resource: hills produce brick, forests produce wood, mountains produce ore, fields produce wheat, and pastures produce sheep. CATAN has won multiple awards and is one of the most popular games in recent history due to its amazing ability to appeal to experienced gamers as well as those new to the hobby.", 2.0, "~/assets/games/Catan_card.jpg", false, false, 4, 3, "Catan", 50.00m, null, null, 1995 },
                    { 4, 60, "The sun shines brightly on the canopy of the forest, and the trees use this wonderful energy to grow and develop their beautiful foliage. Sow your crops wisely and the shadows of your growing trees could slow your opponents down, but don't forget that the sun revolves around the forest. Welcome to the world of Photosynthesis, the green strategy board game!", 2.0, "~/assets/games/Photosynthesis_card.jpg", false, false, 4, 2, "Photosynthesis", 45.00m, null, null, 2017 },
                    { 5, 60, "With elegantly simple gameplay, Ticket to Ride can be learned in under 15 minutes. Players collect cards of various types of train cars they then use to claim railway routes in North America. The longer the routes, the more points they earn. Additional points come to those who fulfill Destination Tickets – goal cards that connect distant cities; and to the player who builds the longest continuous route.", 1.5, "~/assets/games/Ticket_To_Ride_card.jpg", false, false, 5, 2, "Ticket to Ride", 70.00m, null, null, 2004 }
                });

            migrationBuilder.InsertData(
                table: "BoardgamesGenres",
                columns: new[] { "BoardgameId", "GenreId" },
                values: new object[] { 1, 12 });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 18, "Negotiation" },
                    { 19, "Trains" }
                });

            migrationBuilder.InsertData(
                table: "BoardgamesGenres",
                columns: new[] { "BoardgameId", "GenreId" },
                values: new object[,]
                {
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 10 },
                    { 3, 18 },
                    { 4, 1 },
                    { 4, 10 },
                    { 5, 19 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/assets/games/Dune_Imperium.jpg");
        }
    }
}
