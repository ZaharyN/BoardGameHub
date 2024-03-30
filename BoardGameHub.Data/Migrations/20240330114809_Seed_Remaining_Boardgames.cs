using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class Seed_Remaining_Boardgames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boardgames",
                columns: new[] { "Id", "AveragePlayingTime", "Description", "Difficulty", "ImageUrl", "IsReserved", "IsUpcoming", "MaximumPlayersAllowedToPlay", "MinimumPlayersAllowedToPlay", "Name", "PriceInShop", "Rating", "ReservationId", "YearPublished" },
                values: new object[,]
                {
                    { 11, 90, "Brass: Birmingham is an economic strategy game sequel to Martin Wallace' 2007 masterpiece, Brass. Brass: Birmingham tells the story of competing entrepreneurs in Birmingham during the industrial revolution, between the years of 1770-1870. It offers a very different story arc and experience from its predecessor. As in its predecessor, you must develop, build, and establish your industries and network, in an effort to exploit low or high market demands. The game is played over two halves: the canal era (years 1770-1830) and the rail era (years 1830-1870). To win the game, score the most VPs. VPs are counted at the end of each half for the canals, rails and established (flipped) industry tiles.", 4.0, "~/assets/games/Brass_Birmingham_card.jpg", false, false, 4, 2, "Brass: Birmingham", 150.00m, null, null, 2018 },
                    { 12, 120, "In Ark Nova, you will plan and design a modern, scientifically managed zoo. With the ultimate goal of owning the most successful zoological establishment, you will build enclosures, accommodate animals, and support conservation projects all over the world. Specialists and unique buildings will help you in achieving this goal.\r\nEach player has a set of five action cards to manage their gameplay, and the power of an action is determined by the slot the card currently occupies. The cards in question are:\r\n\r\nCARDS: Allows you to gain new zoo cards (animals, sponsors, and conservation project cards).\r\nBUILD: Allows you to build standard or special enclosures, kiosks, and pavilions.\r\nANIMALS: Allows you to accommodate animals in your zoo.\r\nASSOCIATION: Allows your association workers to carry out different tasks.\r\nSPONSORS: Allows you to play a sponsor card in your zoo or to raise money.\r\n255 cards featuring animals, specialists, special enclosures, and conservation projects, each with a special ability, are at the heart of Ark Nova. Use them to increase the appeal and scientific reputation of your zoo and collect conservation points.", 3.7000000000000002, "~/assets/games/Ark_Nova_card.jpg", false, true, 4, 1, "Ark Nova", 135.00m, null, null, 2021 },
                    { 13, 90, "It is a time of unrest in 1920s Europa. The ashes from the first great war still darken the snow. The capitalistic city-state known simply as “The Factory”, which fueled the war with heavily armored mechs, has closed its doors, drawing the attention of several nearby countries.\r\nScythe is an engine-building game set in an alternate-history 1920s period. It is a time of farming and war, broken hearts and rusted gears, innovation and valor. In Scythe, each player represents a character from one of five factions of Eastern Europe who are attempting to earn their fortune and claim their faction's stake in the land around the mysterious Factory. Players conquer territory, enlist new recruits, reap resources, gain villagers, build structures, and activate monstrous mechs.", 3.5, "~/assets/games/Scythe_card.jpg", false, false, 5, 1, "Scythe", 165.00m, null, null, 2016 },
                    { 14, 150, "Playing Nemesis will take you into the heart of sci-fi survival horror in all its terror. A soldier fires blindly down a corridor, trying to stop the alien advance. A scientist races to find a solution in his makeshift lab. A traitor steals the last escape pod in the very last moment. Intruders you meet on the ship are not only reacting to the noise you make but also evolve as the time goes by. The longer the game takes, the stronger they become. During the game, you control one of the crew members with a unique set of skills, personal deck of cards, and individual starting equipment. These heroes cover all your basic SF horror needs. For example, the scientist is great with computers and research, but will have a hard time in combat. The soldier, on the other hand...", 3.5, "~/assets/games/Nemesis_card.jpg", false, false, 5, 1, "Nemesis", 200.00m, null, null, 2018 },
                    { 15, 60, "Wingspan is a competitive, medium-weight, card-driven, engine-building board game from Stonemaier Games. It's designed by Elizabeth Hargrave and features over 170 birds illustrated by Beth Sobel, Natalia Rojas, and Ana Maria Martinez.\r\n\r\nYou are bird enthusiasts—researchers, bird watchers, ornithologists, and collectors—seeking to discover and attract the best birds to your network of wildlife preserves. Each bird extends a chain of powerful combinations in one of your habitats (actions). These habitats focus on several key aspects of growth:\r\n\r\nGain food tokens via custom dice in a birdfeeder dice tower\r\nLay eggs using egg miniatures in a variety of colors\r\nDraw from hundreds of unique bird cards and play them\r\nThe winner is the player with the most points after 4 rounds.", 2.5, "~/assets/games/Wingspan_card.jpg", false, false, 5, 1, "Wingspan", 100.00m, null, null, 2019 },
                    { 16, 45, "Cascadia is a puzzly tile-laying and token-drafting game featuring the habitats and wildlife of the Pacific Northwest.\r\n\r\nIn the game, you take turns building out your own terrain area and populating it with wildlife. You start with three hexagonal habitat tiles (with the five types of habitat in the game), and on a turn you choose a new habitat tile that's paired with a wildlife token, then place that tile next to your other ones and place the wildlife token on an appropriate habitat. (Each tile depicts 1-3 types of wildlife from the five types in the game, and you can place at most one tile on a habitat.) Four tiles are on display, with each tile being paired at random with a wildlife token, so you must make the best of what's available — unless you have a nature token to spend so that you can pick your choice of each item.", 1.5, "~/assets/games/Cascadia_card.jpg", false, false, 4, 1, "Cascadia", 72.00m, null, null, 2021 },
                    { 17, 15, "Two rival spymasters know the secret identities of 25 agents. Their teammates know the agents only by their codenames — single-word labels like \"disease\", \"Germany\", and \"carrot\". Yes, carrot. It's a legitimate codename. Each spymaster wants their team to identify their agents first...without uncovering the assassin by mistake.\r\n\r\nIn Codenames, two teams compete to see who can make contact with all of their agents first. Lay out 25 cards, each bearing a single word. The spymasters look at a card showing the identity of each card, then take turns clueing their teammates. A clue consists of a single word and a number, with the number suggesting how many cards in play have some association to the given clue word. The teammates then identify one agent they think is on their team; if they're correct, they can keep guessing up to the stated number of times; if the agent belongs to the opposing team or is an innocent bystander, the team's turn ends; and if they fingered the assassin, they lose the game.\r\n\r\nSpymasters continue giving clues until one team has identified all of their agents or the assassin has removed one team from play.", 1.0, "~/assets/games/Codenames_card.jpg", false, false, 8, 2, "Codenames", 40.00m, null, null, 2015 },
                    { 18, 30, "Each turn in Dixit, one player is the storyteller, chooses one of the six cards in their hand, then makes up a sentence based on that card's image and says it out loud without showing the card to the other players. Each other player then selects the card in their hand that best matches the sentence and gives the selected card to the storyteller, without showing it to anyone else.\r\n\r\nThe storyteller shuffles their card with all of the received cards, then reveals all of these cards. Each player other than the storyteller then secretly guesses which card belongs to the storyteller. If nobody or everybody guesses the correct card, the storyteller scores 0 points, and each other player scores 2 points. Otherwise, the storyteller and whoever found the correct answer score 3 points. Additionally, the non-storyteller players score 1 point for every vote received by their card.\r\n\r\nThe game ends when the deck is empty or if a player has scored at least 30 points. In either case, the player with the most points wins.\r\n\r\nThe Dixit base game and each expansion contains 84 cards, and the cards can be mixed together as desired.", 1.2, "~/assets/games/Dixit_card.jpg", false, false, 8, 3, "Dixit", 55.00m, null, null, 2008 },
                    { 19, 15, "Exploding Kittens is a kitty-powered version of Russian Roulette. Players take turns drawing cards until someone draws an exploding kitten and loses the game. The deck is made up of cards that let you avoid exploding by peeking at cards before you draw, forcing your opponent to draw multiple cards, or shuffling the deck.\r\n\r\nThe game gets more and more intense with each card you draw because fewer cards left in the deck means a greater chance of drawing the kitten and exploding in a fiery ball of feline hyperbole.", 1.0, "~/assets/games/Exlpoding_Kittens_card.jpg", false, false, 5, 2, "Exploding Kittens", 45.00m, null, null, 2015 },
                    { 20, 30, "Players compete in two teams in Decrypto, with each trying to correctly interpret the coded messages presented to them by their teammates while cracking the codes they intercept from the opposing team.\r\n\r\nIn more detail, each team has their own screen, and in this screen they tuck four cards in pockets numbered 1-4, letting everyone on the same team see the words on these cards while hiding the words from the opposing team. In the first round, each team does the following: One team member takes a code card that shows three of the digits 1-4 in some order, e.g., 4-2-1. They then give a coded message that their teammates must use to guess this code. For example, if the team's four words are \"pig\", \"candy\", \"tent\", and \"son\", then I might say \"Sam-striped-pink\" and hope that my teammates can correctly map those words to 4-2-1. If they guess correctly, great; if not, we receive a black mark of failure.", 1.8, "~/assets/games/Decrypto_card.jpg", false, false, 8, 3, "Decrypto", 40.00m, null, null, 2018 },
                    { 21, 150, "A game of Eclipse places you in control of a vast interstellar civilization, competing for success with its rivals. You explore new star systems, research technologies, and build spaceships with which to wage war. There are many potential paths to victory, so you need to plan your strategy according to the strengths and weaknesses of your species, while paying attention to the other civilizations' endeavors.\r\n\r\nEclipse: Second Dawn for the Galaxy is a revised and upgraded version of the Eclipse base game that debuted in 2011 that features:\r\n\r\nNew graphic design, while maintaining the acclaimed symbology of the first edition\r\nA full line of Ship Pack 1 miniatures\r\nNew miniatures for ancients, GCDS, orbitals, and more\r\nCustom plastic inlays\r\nCustom combat dice\r\nFine-tuned gameplay", 3.7000000000000002, "~/assets/games/Eclipse_card.jpg", false, true, 6, 2, "Eclipse: Second Dawn for the Galaxy", 275.00m, null, null, 2020 }
                });

            migrationBuilder.InsertData(
                table: "BoardgamesGenres",
                columns: new[] { "BoardgameId", "GenreId" },
                values: new object[,]
                {
                    { 11, 8 },
                    { 11, 10 },
                    { 11, 19 },
                    { 12, 10 },
                    { 12, 20 },
                    { 12, 22 },
                    { 13, 9 },
                    { 13, 10 },
                    { 14, 2 },
                    { 14, 7 },
                    { 14, 14 },
                    { 15, 20 },
                    { 15, 21 },
                    { 15, 23 },
                    { 16, 11 },
                    { 16, 20 },
                    { 16, 22 },
                    { 17, 3 },
                    { 17, 16 },
                    { 17, 21 },
                    { 18, 16 },
                    { 18, 21 },
                    { 19, 20 },
                    { 19, 21 },
                    { 20, 3 },
                    { 20, 16 },
                    { 21, 6 },
                    { 21, 24 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 11, 19 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 12, 20 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 12, 22 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 15, 20 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 15, 21 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 15, 23 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 16, 20 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 16, 22 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 17, 16 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 17, 21 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 18, 16 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 18, 21 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 19, 20 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 19, 21 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 20, 16 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "BoardgamesGenres",
                keyColumns: new[] { "BoardgameId", "GenreId" },
                keyValues: new object[] { 21, 24 });

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 21);
        }
    }
}
