using BoardGameHub.Data.Data.DataModels;

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
        public Boardgame MonopolyBoardgame { get; set; }
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
        }
    }
}
