using BoardGameHub.Data.Data.DataModels;
using System.Reflection.Metadata.Ecma335;

namespace BoardGameHub.Data.Data.Seed
{
    internal class SeedGenreData
    {
        public SeedGenreData()
        {
            SeedGenres();
        }

        public Genre AbstractStrategyGenre { get; set; }
        public Genre AdventureGenre { get; set; }
        public Genre DeductionGenre { get; set; }
        public Genre DexterityGenre { get; set; }
        public Genre FamilyGenre { get; set; }
        public Genre ExplorationGenre { get; set; }
        public Genre HorrorGenre { get; set; }
        public Genre IndustryGenre { get; set; }
        public Genre TerritoryBuildingGenre { get; set; }
        public Genre EconomicGenre { get; set; }
        public Genre PuzzleGenre { get; set; }
        public Genre DeckbuilderGenre { get; set; }
        public Genre PlacementGenre { get; set; }
        public Genre CooperativeGenre { get; set; }
        public Genre CombatGenre { get; set; }
        public Genre PartyGenre { get; set; }
        public Genre StrategyGenre { get; set; }

        private void SeedGenres()
        {

            AbstractStrategyGenre = new Genre()
            {
                Id = 1,
                Name = "Abstract",
            };

            AdventureGenre = new Genre()
            {
                Id = 2,
                Name = "Adventure"
            };

            DeductionGenre = new Genre()
            {
                Id = 3,
                Name = "Deduction"
            };

            DexterityGenre = new Genre()
            {
                Id = 4,
                Name = "Dexterity"
            };

            FamilyGenre = new Genre()
            {
                Id = 5,
                Name = "Family"
            };

            ExplorationGenre = new Genre()
            {
                Id = 6,
                Name = "Exploration"
            };

            HorrorGenre = new Genre()
            {
                Id = 7,
                Name = "Horror"
            };

            IndustryGenre = new Genre()
            {
                Id = 8,
                Name = "Industry"
            };

            TerritoryBuildingGenre = new Genre()
            {
                Id = 9,
                Name = "Territory building"
            };

            EconomicGenre = new Genre()
            {
                Id = 10,
                Name = "Economy"
            };

            PuzzleGenre = new Genre()
            {
                Id = 11,
                Name = "Puzzle"
            };

            DeckbuilderGenre = new Genre()
            {
                Id = 12,
                Name = "Deckbuilder"
            };

            PlacementGenre = new Genre()
            {
                Id = 13,
                Name = "Placement"
            };

            CooperativeGenre = new Genre()
            {
                Id = 14,
                Name = "Cooperative"
            };

            CombatGenre = new Genre()
            {
                Id = 15,
                Name = "Combat"
            };

            PartyGenre = new Genre()
            {
                Id = 16,
                Name = "Party"
            };

            StrategyGenre = new Genre()
            {
                Id = 17,
                Name = "Strategy"
            };
        }
    }
}
