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
        public Boardgame TerraformMarsBoardgame { get; set; }
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
                Description = "Dune: Imperium is a game that uses deck-building to add a hidden-information angle to traditional worker placement. It finds inspiration in elements and characters from the Dune legacy, both the new film from Legendary Pictures and the seminal literary series from Frank Herbert, Brian Herbert, and Kevin J.Anderson.As a leader of one of the Great Houses of the   Landsraad, raise your banner and marshal your forces and spies. War is coming, and at the center of the conflict is Arrakis – Dune, the desert planet.",
                Difficulty = 3,
                ImageUrl = "~/assets/games/Dune_Imperium.jpg",
                YearPublished = 2020,
                PriceInShop = 90.00M,
                MinimumPlayersAllowedToPlay = 1,
                MaximumPlayersAllowedToPlay = 4,
                IsReserved = false,
                IsUpcoming = false
            };
        }
    }
}
