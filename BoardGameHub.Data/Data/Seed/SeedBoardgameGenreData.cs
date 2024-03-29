using BoardGameHub.Data.Data.DataModels;

namespace BoardGameHub.Data.Data.Seed
{
    internal class SeedBoardgameGenreData
    {
        public SeedBoardgameGenreData()
        {
            SeedBoardgameGenres();
        }

        public BoardgameGenre DuneGenre1 { get; set; }
        public BoardgameGenre DuneGenre2 { get; set; }
        public BoardgameGenre DuneGenre3 { get; set; }
        public BoardgameGenre TerraformMarsGenre1 { get; set; }
        public BoardgameGenre TerraformMarsGenre2 { get; set; }
        public BoardgameGenre TerraformMarsGenre3 { get; set; }
        public BoardgameGenre CatanGenre1 { get; set; }
        public BoardgameGenre CatanGenre2 { get; set; }
        public BoardgameGenre PhotosynthesisGenre1 { get; set; }
        public BoardgameGenre PhotosynthesisGenre2 { get; set; }
        public BoardgameGenre TicketToRideGenre { get; set; }

        void SeedBoardgameGenres()
        {
            DuneGenre1 = new BoardgameGenre()
            {
                BoardgameId = 1,
                GenreId = 17
            };

            DuneGenre2 = new BoardgameGenre()
            {
                BoardgameId = 1,
                GenreId = 13
            };

            DuneGenre3 = new BoardgameGenre()
            {
                BoardgameId = 1,
                GenreId = 12
            };

            TerraformMarsGenre1 = new BoardgameGenre()
            {
                BoardgameId = 2,
                GenreId = 10
            };

            TerraformMarsGenre2 = new BoardgameGenre()
            {
                BoardgameId = 2,
                GenreId = 8
            };

            TerraformMarsGenre3 = new BoardgameGenre()
            {
                BoardgameId = 2,
                GenreId = 9
            };

            CatanGenre1 = new BoardgameGenre()
            {
                BoardgameId = 3,
                GenreId = 18
            };

            CatanGenre2 = new BoardgameGenre()
            {
                BoardgameId = 3,
                GenreId = 10
            };

            PhotosynthesisGenre1 = new BoardgameGenre()
            {
                BoardgameId = 4,
                GenreId = 1
            };

            PhotosynthesisGenre2 = new BoardgameGenre()
            {
                BoardgameId = 4,
                GenreId = 10
            };

            TicketToRideGenre = new BoardgameGenre()
            {
                BoardgameId = 5,
                GenreId = 19
            };
        }
    }
}
