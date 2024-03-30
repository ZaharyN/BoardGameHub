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
        public BoardgameGenre GloomhavenGenre1 { get; set; }
        public BoardgameGenre GloomhavenGenre2 { get; set; }
        public BoardgameGenre GloomhavenGenre3 { get; set; }
        public BoardgameGenre GloomhavenGenre4 { get; set; }
        public BoardgameGenre MysteriumGenre1 { get; set; }
        public BoardgameGenre MysteriumGenre2 { get; set; }
        public BoardgameGenre MysteriumGenre3 { get; set; }
        public BoardgameGenre EverdellGenre1 { get; set; }
        public BoardgameGenre EverdellGenre2 { get; set; }
        public BoardgameGenre EverdellGenre3 { get; set; }
        public BoardgameGenre MonopolyBulgariaGenre1 { get; set; }
        public BoardgameGenre MonopolyBulgariaGenre2 { get; set; }
        public BoardgameGenre PandemicGenre1 { get; set; }
        public BoardgameGenre PandemicGenre2 { get; set; }
        public BoardgameGenre BrassBirminghamGenre1 { get; set; }
        public BoardgameGenre BrassBirminghamGenre2 { get; set; }
        public BoardgameGenre BrassBirminghamGenre3 { get; set; }
        public BoardgameGenre ArkNovaGenre1 { get; set; }
        public BoardgameGenre ArkNovaGenre2 { get; set; }
        public BoardgameGenre ArkNovaGenre3 { get; set; }
        public BoardgameGenre ScytheGenre1 { get; set; }
        public BoardgameGenre ScytheGenre2 { get; set; }
        public BoardgameGenre NemesisGenre1 { get; set; }
        public BoardgameGenre NemesisGenre2 { get; set; }
        public BoardgameGenre NemesisGenre3 { get; set; }
        public BoardgameGenre WingspanGenre1 { get; set; }
        public BoardgameGenre WingspanGenre2 { get; set; }
        public BoardgameGenre WingspanGenre3 { get; set; }
        public BoardgameGenre CascadiaGenre1 { get; set; }
        public BoardgameGenre CascadiaGenre2 { get; set; }
        public BoardgameGenre CascadiaGenre3 { get; set; }
        public BoardgameGenre CodenamesGenre1 { get; set; }
        public BoardgameGenre CodenamesGenre2 { get; set; }
        public BoardgameGenre CodenamesGenre3 { get; set; }
        public BoardgameGenre DixitGenre1 { get; set; }
        public BoardgameGenre DixitGenre2 { get; set; }
        public BoardgameGenre ExplodingKittensGenre1 { get; set; }
        public BoardgameGenre ExplodingKittensGenre2 { get; set; }
        public BoardgameGenre DecryptoGenre1 { get; set; }
        public BoardgameGenre DecryptoGenre2 { get; set; }
        public BoardgameGenre EclipseGenre1 { get; set; }
        public BoardgameGenre EclipseGenre2 { get; set; }

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

            GloomhavenGenre1 = new BoardgameGenre()
            {
                BoardgameId = 6,
                GenreId = 2
            };

            GloomhavenGenre2 = new BoardgameGenre()
            {
                BoardgameId = 6,
                GenreId = 6
            };

            GloomhavenGenre3 = new BoardgameGenre()
            {
                BoardgameId = 6,
                GenreId = 15
            };

            GloomhavenGenre4 = new BoardgameGenre()
            {
                BoardgameId = 6,
                GenreId = 14
            };

            MysteriumGenre1 = new BoardgameGenre()
            {
                BoardgameId = 7,
                GenreId = 3
            };

            MysteriumGenre2 = new BoardgameGenre()
            {
                BoardgameId = 7,
                GenreId = 7
            };

            MysteriumGenre3 = new BoardgameGenre()
            {
                BoardgameId = 7,
                GenreId = 16
            };

            EverdellGenre1 = new BoardgameGenre()
            {
                BoardgameId = 8,
                GenreId = 20
            };

            EverdellGenre2 = new BoardgameGenre()
            {
                BoardgameId = 8,
                GenreId = 21
            };

            EverdellGenre3 = new BoardgameGenre()
            {
                BoardgameId = 8,
                GenreId = 9
            };

            MonopolyBulgariaGenre1 = new BoardgameGenre()
            {
                BoardgameId = 9,
                GenreId = 18
            };

            MonopolyBulgariaGenre2 = new BoardgameGenre()
            {
                BoardgameId = 9,
                GenreId = 10
            };

            PandemicGenre1 = new BoardgameGenre()
            {
                BoardgameId = 10,
                GenreId = 13
            };

            PandemicGenre2 = new BoardgameGenre()
            {
                BoardgameId = 10,
                GenreId = 14
            };

            BrassBirminghamGenre1 = new BoardgameGenre()
            {
                BoardgameId = 11,
                GenreId = 10
            };

            BrassBirminghamGenre2 = new BoardgameGenre()
            {
                BoardgameId = 11,
                GenreId = 8
            };

            BrassBirminghamGenre3 = new BoardgameGenre()
            {
                BoardgameId = 11,
                GenreId = 19
            };

            ArkNovaGenre1 = new BoardgameGenre()
            {
                BoardgameId = 12,
                GenreId = 20
            };

            ArkNovaGenre2 = new BoardgameGenre()
            {
                BoardgameId = 12,
                GenreId = 10
            };

            ArkNovaGenre3 = new BoardgameGenre()
            {
                BoardgameId = 12,
                GenreId = 22
            };

            ScytheGenre1 = new BoardgameGenre()
            {
                BoardgameId = 13,
                GenreId = 9,
            };

            ScytheGenre2 = new BoardgameGenre()
            {
                BoardgameId = 13,
                GenreId = 10,
            };

            NemesisGenre1 = new BoardgameGenre()
            {
                BoardgameId = 14,
                GenreId = 2
            };

            NemesisGenre2 = new BoardgameGenre()
            {
                BoardgameId = 14,
                GenreId = 7
            };

            NemesisGenre3 = new BoardgameGenre()
            {
                BoardgameId = 14,
                GenreId = 14
            };

            WingspanGenre1 = new BoardgameGenre()
            {
                BoardgameId = 15,
                GenreId = 20
            };

            WingspanGenre2 = new BoardgameGenre()
            {
                BoardgameId = 15,
                GenreId = 21
            };

            WingspanGenre3 = new BoardgameGenre()
            {
                BoardgameId = 15,
                GenreId = 23
            };

            CascadiaGenre1 = new BoardgameGenre()
            {
                BoardgameId = 16,
                GenreId = 20
            };

            CascadiaGenre2 = new BoardgameGenre()
            {
                BoardgameId = 16,
                GenreId = 22
            };

            CascadiaGenre3 = new BoardgameGenre()
            {
                BoardgameId = 16,
                GenreId = 11
            };

            CodenamesGenre1 = new BoardgameGenre()
            {
                BoardgameId = 17,
                GenreId = 21
            };

            CodenamesGenre2 = new BoardgameGenre()
            {
                BoardgameId = 17,
                GenreId = 16
            };

            CodenamesGenre3 = new BoardgameGenre()
            {
                BoardgameId = 17,
                GenreId = 3
            };

            DixitGenre1 = new BoardgameGenre()
            {
                BoardgameId = 18,
                GenreId = 21
            };

            DixitGenre2 = new BoardgameGenre()
            {
                BoardgameId = 18,
                GenreId = 16
            };

            ExplodingKittensGenre1 = new BoardgameGenre()
            {
                BoardgameId = 19,
                GenreId = 20
            };

            ExplodingKittensGenre2 = new BoardgameGenre()
            {
                BoardgameId = 19,
                GenreId = 21
            };

            DecryptoGenre1 = new BoardgameGenre()
            {
                BoardgameId = 20,
                GenreId = 3
            };

            DecryptoGenre2 = new BoardgameGenre()
            {
                BoardgameId = 20,
                GenreId = 16
            };

            EclipseGenre1 = new BoardgameGenre()
            {
                BoardgameId = 21,
                GenreId = 6
            };

            EclipseGenre2 = new BoardgameGenre()
            {
                BoardgameId = 21,
                GenreId = 24
            };
        }
    }
}
