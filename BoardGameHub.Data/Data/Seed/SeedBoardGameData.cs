using BoardGameHub.Data.Data.DataModels;
using System.Data.SqlTypes;

namespace BoardGameHub.Data.Data.Seed
{
    internal class SeedBoardgameData
    {
        public SeedBoardgameData()
        {
            SeedBoardgames();
        }

        public Boardgame DuneBoardgame { get; set; }
        public Boardgame TerraformingMarsBoardgame { get; set; }
        public Boardgame CatanBoardgame { get; set; }
        public Boardgame PhotosynthesisBoardgame { get; set; }
        public Boardgame TicketToRideBoardgame { get; set; }
        public Boardgame GloomhavenBoardgame { get; set; }
        public Boardgame MysteriumBoardgame { get; set; }
        public Boardgame EverdellBoardgame { get; set; }
        public Boardgame MonopolyBulgariaBoardgame { get; set; }
        public Boardgame PandemicBoardgame { get; set; }
        public Boardgame BrassBirminghamBoardgame { get; set; }
        public Boardgame ArkNovaBoardgame { get; set; }
        public Boardgame ScytheBoardgame { get; set; }
        public Boardgame NemesisBoardgame { get; set; }
        public Boardgame WingspanBoardgame { get; set; }
        public Boardgame CascadiaBoardgame { get; set; }
        public Boardgame ChessBoardgame { get; set; }
        public Boardgame BackgammonBoardgame { get; set; }
        public Boardgame ExplodingKittensBoardgame { get; set; }
        public Boardgame DecryptoBoardgame { get; set; }
        public Boardgame EclipseSecondDawnForTheGalaxyBoardgame { get; set; }

        private void SeedBoardgames()
        {
            DuneBoardgame = new Boardgame()
            {
                Id = 1,
                Name = "Dune: Imperium",
                AveragePlayingTime = 90,
                Description = "Dune: Imperium is a game that uses deck-building to add a hidden-information angle to traditional worker placement. It finds inspiration in elements and characters from the Dune legacy, both the new film from Legendary Pictures and the seminal literary series from Frank Herbert, Brian Herbert, and Kevin J.Anderson.As a leader of one of the Great Houses of the Landsraad, raise your banner and marshal your forces and spies. War is coming, and at the center of the conflict is Arrakis – Dune, the desert planet.",
                Difficulty = 3,
                ImageUrl = "~/assets/games/Dune_Imperium_card.jpg",
                YearPublished = 2020,
                PriceInShop = 90.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            TerraformingMarsBoardgame = new Boardgame()
            {
                Id = 2,
                Name = "Terraforming Mars",
                AveragePlayingTime = 120,
                Description = "In the 2400s, mankind begins to terraform the planet Mars. Giant corporations, sponsored by the World Government on Earth, initiate huge projects to raise the temperature, the oxygen level, and the ocean coverage until the environment is habitable. In Terraforming Mars, you play one of those corporations and work together in the terraforming process, but compete for getting victory points that are awarded not only for your contribution to the terraforming, but also for advancing human infrastructure throughout the solar system, and doing other commendable things.",
                Difficulty = 3.5,
                ImageUrl = "~/assets/games/Terraforming_Mars_card.jpg",
                YearPublished = 2016,
                PriceInShop = 100.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            CatanBoardgame = new Boardgame()
            {
                Id = 3,
                Name = "Catan",
                AveragePlayingTime = 90,
                Description = "In CATAN (formerly The Settlers of Catan), players try to be the dominant force on the island of Catan by building settlements, cities, and roads. On each turn dice are rolled to determine what resources the island produces. Players build by spending resources (sheep, wheat, wood, brick and ore) that are depicted by these resource cards; each land type, with the exception of the unproductive desert, produces a specific resource: hills produce brick, forests produce wood, mountains produce ore, fields produce wheat, and pastures produce sheep. CATAN has won multiple awards and is one of the most popular games in recent history due to its amazing ability to appeal to experienced gamers as well as those new to the hobby.",
                Difficulty = 2,
                ImageUrl = "~/assets/games/Catan_card.jpg",
                YearPublished = 1995,
                PriceInShop = 50.00M,
                MinimumPlayersAllowedToPlay = 3,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            PhotosynthesisBoardgame = new Boardgame()
            {
                Id = 4,
                Name = "Photosynthesis",
                AveragePlayingTime = 60,
                Description = "The sun shines brightly on the canopy of the forest, and the trees use this wonderful energy to grow and develop their beautiful foliage. Sow your crops wisely and the shadows of your growing trees could slow your opponents down, but don't forget that the sun revolves around the forest. Welcome to the world of Photosynthesis, the green strategy board game!",
                Difficulty = 2,
                ImageUrl = "~/assets/games/Photosynthesis_card.jpg",
                YearPublished = 2017,
                PriceInShop = 45.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            TicketToRideBoardgame = new Boardgame()
            {
                Id = 5,
                Name = "Ticket to Ride",
                AveragePlayingTime = 60,
                Description = "With elegantly simple gameplay, Ticket to Ride can be learned in under 15 minutes. Players collect cards of various types of train cars they then use to claim railway routes in North America. The longer the routes, the more points they earn. Additional points come to those who fulfill Destination Tickets – goal cards that connect distant cities; and to the player who builds the longest continuous route.",
                Difficulty = 1.5,
                ImageUrl = "~/assets/games/Ticket_To_Ride_card.jpg",
                YearPublished = 2004,
                PriceInShop = 70.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 5,
                IsReserved = false,
                IsUpcoming = false
            };

            GloomhavenBoardgame = new Boardgame()
            {
                Id = 6,
                Name = "Gloomhaven",
                AveragePlayingTime = 120,
                Description = "Gloomhaven is a game of Euro-inspired tactical combat in a persistent world of shifting motives. Players will take on the role of a wandering adventurer with their own special set of skills and their own reasons for traveling to this dark corner of the world. Players must work together out of necessity to clear out menacing dungeons and forgotten ruins. In the process, they will enhance their abilities with experience and loot, discover new locations to explore and plunder, and expand an ever-branching story fueled by the decisions they make. This is a game with a persistent and changing world that is ideally played over many game sessions. After a scenario, players will make decisions on what to do, which will determine how the story continues, kind of like a “Choose Your Own Adventure” book. Playing through a scenario is a cooperative affair where players will fight against automated monsters using an innovative card system to determine the order of play and what a player does on their turn.",
                Difficulty = 4,
                ImageUrl = "~/assets/games/Gloomhaven_card.jpg",
                YearPublished = 2017,
                PriceInShop = 250.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = true
            };

            MysteriumBoardgame = new Boardgame()
            {
                Id = 7,
                Name = "Mysterium",
                AveragePlayingTime = 45,
                Description = "In the 1920s, Mr. MacDowell, a gifted astrologer, immediately detected a supernatural being upon entering his new house in Scotland. He gathered eminent mediums of his time for an extraordinary séance, and they have seven hours to make contact with the ghost and investigate any clues that it can provide to unlock an old mystery.Unable to talk, the amnesiac ghost communicates with the mediums through visions, which are represented in the game by illustrated cards. The mediums must decipher the images to help the ghost remember how he was murdered: Who did the crime? Where did it take place? Which weapon caused the death? The more the mediums cooperate and guess well, the easier it is to catch the right culprit.",
                Difficulty = 2,
                ImageUrl = "~/assets/games/Mysterium_card.jpg",
                YearPublished = 2015,
                PriceInShop = 70.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 7,
                IsReserved = false,
                IsUpcoming = false
            };

            EverdellBoardgame = new Boardgame()
            {
                Id = 8,
                Name = "Everdell",
                AveragePlayingTime = 60,
                Description = "Within the charming valley of Everdell, beneath the boughs of towering trees, among meandering streams and mossy hollows, a civilization of forest critters is thriving and expanding. From Everfrost to Bellsong, many a year have come and gone, but the time has come for new territories to be settled and new cities established. You will be the leader of a group of critters intent on just such a task. There are buildings to construct, lively characters to meet, events to host—you have a busy year ahead of yourself. Will the sun shine brightest on your city before the winter moon rises?",
                Difficulty = 2.8,
                ImageUrl = "~/assets/games/Everdell_card.jpg",
                YearPublished = 2018,
                PriceInShop = 110M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };

            MonopolyBulgariaBoardgame = new Boardgame()
            {
                Id = 9,
                Name = "Monopoly-Bulgaria",
                AveragePlayingTime = 90,
                Description = "Know your motherland, to love it. But what if you could own a small part of Bulgaria for yourself? This is possible with the special edition of Monopoly - Bulgaria is wonderful. Buy one of the most majestic sights in our country - the unique Stobski pyramids, the National Palace of Culture, the temple-monument \"St. Alexander Nevsky\". Take a walk along some of our most beautiful hiking trails - go inside Devetashka Cave, cross the Devil's Bridge and connect with nature through the Paneurhythmy around the Seven Rila Lakes. The rules are well known to everyone - build hotels and houses to develop your properties, try your luck with the BANK or CHANCE cards. Roll the dice and discover the wonders of Bulgaria as you fight for victory.",
                Difficulty = 1.5,
                ImageUrl = "~/assets/games/Monopoly_Bulgaria_card.jpg",
                YearPublished = 2021,
                PriceInShop = 55.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 6,
                IsReserved = false,
                IsUpcoming = false
            };

            PandemicBoardgame = new Boardgame()
            {
                Id = 10,
                Name = "Pandemic",
                AveragePlayingTime = 45,
                Description = "In Pandemic, several virulent diseases have broken out simultaneously all over the world! The players are disease-fighting specialists whose mission is to treat disease hotspots while researching cures for each of four plagues before they get out of hand. The game board depicts several major population centers on Earth. On each turn, a player can use up to four actions to travel between cities, treat infected populaces, discover a cure, or build a research station. A deck of cards provides the players with these abilities, but sprinkled throughout this deck are Epidemic! cards that accelerate and intensify the diseases' activity. A second, separate deck of cards controls the \"normal\" spread of the infections.",
                Difficulty = 2.5,
                ImageUrl = "~/assets/games/Pandemic_card.jpg",
                YearPublished = 2008,
                PriceInShop = 45.00M,
                MinimumPlayersAllowedToPlay = 2,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };
        }
    }
}
