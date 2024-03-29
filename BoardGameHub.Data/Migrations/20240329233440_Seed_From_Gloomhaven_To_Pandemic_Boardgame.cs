using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class Seed_From_Gloomhaven_To_Pandemic_Boardgame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boardgames",
                columns: new[] { "Id", "AveragePlayingTime", "Description", "Difficulty", "ImageUrl", "IsReserved", "IsUpcoming", "MaximumPlayersAllowedToPlay", "MinimumPlayersAllowedToPlay", "Name", "PriceInShop", "Rating", "ReservationId", "YearPublished" },
                values: new object[,]
                {
                    { 6, 120, "Gloomhaven is a game of Euro-inspired tactical combat in a persistent world of shifting motives. Players will take on the role of a wandering adventurer with their own special set of skills and their own reasons for traveling to this dark corner of the world. Players must work together out of necessity to clear out menacing dungeons and forgotten ruins. In the process, they will enhance their abilities with experience and loot, discover new locations to explore and plunder, and expand an ever-branching story fueled by the decisions they make. This is a game with a persistent and changing world that is ideally played over many game sessions. After a scenario, players will make decisions on what to do, which will determine how the story continues, kind of like a “Choose Your Own Adventure” book. Playing through a scenario is a cooperative affair where players will fight against automated monsters using an innovative card system to determine the order of play and what a player does on their turn.", 4.0, "~/assets/games/Gloomhaven_card.jpg", false, true, 4, 1, "Gloomhaven", 250.00m, null, null, 2017 },
                    { 7, 45, "In the 1920s, Mr. MacDowell, a gifted astrologer, immediately detected a supernatural being upon entering his new house in Scotland. He gathered eminent mediums of his time for an extraordinary séance, and they have seven hours to make contact with the ghost and investigate any clues that it can provide to unlock an old mystery.Unable to talk, the amnesiac ghost communicates with the mediums through visions, which are represented in the game by illustrated cards. The mediums must decipher the images to help the ghost remember how he was murdered: Who did the crime? Where did it take place? Which weapon caused the death? The more the mediums cooperate and guess well, the easier it is to catch the right culprit.", 2.0, "~/assets/games/Mysterium_card.jpg", false, false, 7, 2, "Mysterium", 70.00m, null, null, 2015 },
                    { 8, 60, "Within the charming valley of Everdell, beneath the boughs of towering trees, among meandering streams and mossy hollows, a civilization of forest critters is thriving and expanding. From Everfrost to Bellsong, many a year have come and gone, but the time has come for new territories to be settled and new cities established. You will be the leader of a group of critters intent on just such a task. There are buildings to construct, lively characters to meet, events to host—you have a busy year ahead of yourself. Will the sun shine brightest on your city before the winter moon rises?", 2.7999999999999998, "~/assets/games/Everdell_card.jpg", false, false, 4, 1, "Everdell", 110m, null, null, 2018 },
                    { 9, 90, "Know your motherland, to love it. But what if you could own a small part of Bulgaria for yourself? This is possible with the special edition of Monopoly - Bulgaria is wonderful. Buy one of the most majestic sights in our country - the unique Stobski pyramids, the National Palace of Culture, the temple-monument \"St. Alexander Nevsky\". Take a walk along some of our most beautiful hiking trails - go inside Devetashka Cave, cross the Devil's Bridge and connect with nature through the Paneurhythmy around the Seven Rila Lakes. The rules are well known to everyone - build hotels and houses to develop your properties, try your luck with the BANK or CHANCE cards. Roll the dice and discover the wonders of Bulgaria as you fight for victory.", 1.5, "~/assets/games/Monopoly_Bulgaria_card.jpg", false, false, 6, 2, "Monopoly-Bulgaria", 55.00m, null, null, 2021 },
                    { 10, 45, "In Pandemic, several virulent diseases have broken out simultaneously all over the world! The players are disease-fighting specialists whose mission is to treat disease hotspots while researching cures for each of four plagues before they get out of hand. The game board depicts several major population centers on Earth. On each turn, a player can use up to four actions to travel between cities, treat infected populaces, discover a cure, or build a research station. A deck of cards provides the players with these abilities, but sprinkled throughout this deck are Epidemic! cards that accelerate and intensify the diseases' activity. A second, separate deck of cards controls the \"normal\" spread of the infections.", 2.5, "~/assets/games/Pandemic_card.jpg", false, false, 4, 2, "Pandemic", 45.00m, null, null, 2008 }
                });

            migrationBuilder.InsertData(
                table: "BoardgamesGenres",
                columns: new[] { "BoardgameId", "GenreId" },
                values: new object[,]
                {
                    { 6, 2 },
                    { 6, 6 },
                    { 6, 14 },
                    { 6, 15 },
                    { 7, 3 },
                    { 7, 7 },
                    { 7, 16 },
                    { 8, 9 },
                    { 8, 20 },
                    { 8, 21 },
                    { 9, 10 },
                    { 9, 18 },
                    { 10, 13 },
                    { 10, 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 8, 20 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 8, 21 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 9, 18 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
