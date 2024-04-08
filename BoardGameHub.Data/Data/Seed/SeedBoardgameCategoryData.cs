using BoardGameHub.Data.Data.DataModels;

namespace BoardGameHub.Data.Data.Seed
{
    internal class SeedBoardgameCategoryData
    {
        public SeedBoardgameCategoryData()
        {
            SeedBoardgameCategories();
        }

        public BoardgameCategory DuneCategory1 { get; set; }
        public BoardgameCategory DuneCategory2 { get; set; }
        public BoardgameCategory DuneCategory3 { get; set; }
        public BoardgameCategory TerraformMarsCategory1 { get; set; }
        public BoardgameCategory TerraformMarsCategory2 { get; set; }
        public BoardgameCategory TerraformMarsCategory3 { get; set; }
        public BoardgameCategory CatanCategory1 { get; set; }
        public BoardgameCategory CatanCategory2 { get; set; }
        public BoardgameCategory PhotosynthesisCategory1 { get; set; }
        public BoardgameCategory PhotosynthesisCategory2 { get; set; }
        public BoardgameCategory TicketToRideCategory { get; set; }
        public BoardgameCategory GloomhavenCategory1 { get; set; }
        public BoardgameCategory GloomhavenCategory2 { get; set; }
        public BoardgameCategory GloomhavenCategory3 { get; set; }
        public BoardgameCategory GloomhavenCategory4 { get; set; }
        public BoardgameCategory MysteriumCategory1 { get; set; }
        public BoardgameCategory MysteriumCategory2 { get; set; }
        public BoardgameCategory MysteriumCategory3 { get; set; }
        public BoardgameCategory EverdellCategory1 { get; set; }
        public BoardgameCategory EverdellCategory2 { get; set; }
        public BoardgameCategory EverdellCategory3 { get; set; }
        public BoardgameCategory MonopolyBulgariaCategory1 { get; set; }
        public BoardgameCategory MonopolyBulgariaCategory2 { get; set; }
        public BoardgameCategory PandemicCategory1 { get; set; }
        public BoardgameCategory PandemicCategory2 { get; set; }
        public BoardgameCategory BrassBirminghamCategory1 { get; set; }
        public BoardgameCategory BrassBirminghamCategory2 { get; set; }
        public BoardgameCategory BrassBirminghamCategory3 { get; set; }
        public BoardgameCategory ArkNovaCategory1 { get; set; }
        public BoardgameCategory ArkNovaCategory2 { get; set; }
        public BoardgameCategory ArkNovaCategory3 { get; set; }
        public BoardgameCategory ScytheCategory1 { get; set; }
        public BoardgameCategory ScytheCategory2 { get; set; }
        public BoardgameCategory NemesisCategory1 { get; set; }
        public BoardgameCategory NemesisCategory2 { get; set; }
        public BoardgameCategory NemesisCategory3 { get; set; }
        public BoardgameCategory WingspanCategory1 { get; set; }
        public BoardgameCategory WingspanCategory2 { get; set; }
        public BoardgameCategory WingspanCategory3 { get; set; }
        public BoardgameCategory CascadiaCategory1 { get; set; }
        public BoardgameCategory CascadiaCategory2 { get; set; }
        public BoardgameCategory CascadiaCategory3 { get; set; }
        public BoardgameCategory CodenamesCategory1 { get; set; }
        public BoardgameCategory CodenamesCategory2 { get; set; }
        public BoardgameCategory CodenamesCategory3 { get; set; }
        public BoardgameCategory DixitCategory1 { get; set; }
        public BoardgameCategory DixitCategory2 { get; set; }
        public BoardgameCategory ExplodingKittensCategory1 { get; set; }
        public BoardgameCategory ExplodingKittensCategory2 { get; set; }
        public BoardgameCategory DecryptoCategory1 { get; set; }
        public BoardgameCategory DecryptoCategory2 { get; set; }
        public BoardgameCategory EclipseCategory1 { get; set; }
        public BoardgameCategory EclipseCategory2 { get; set; }

        void SeedBoardgameCategories()
        {
            DuneCategory1 = new BoardgameCategory()
            {
                BoardgameId = 1,
                CategoryId = 17
            };

            DuneCategory2 = new BoardgameCategory()
            {
                BoardgameId = 1,
                CategoryId = 13
            };

            DuneCategory3 = new BoardgameCategory()
            {
                BoardgameId = 1,
                CategoryId = 12
            };

            TerraformMarsCategory1 = new BoardgameCategory()
            {
                BoardgameId = 2,
                CategoryId = 10
            };

            TerraformMarsCategory2 = new BoardgameCategory()
            {
                BoardgameId = 2,
                CategoryId = 8
            };

            TerraformMarsCategory3 = new BoardgameCategory()
            {
                BoardgameId = 2,
                CategoryId = 9
            };

            CatanCategory1 = new BoardgameCategory()
            {
                BoardgameId = 3,
                CategoryId = 18
            };

            CatanCategory2 = new BoardgameCategory()
            {
                BoardgameId = 3,
                CategoryId = 10
            };

            PhotosynthesisCategory1 = new BoardgameCategory()
            {
                BoardgameId = 4,
                CategoryId = 1
            };

            PhotosynthesisCategory2 = new BoardgameCategory()
            {
                BoardgameId = 4,
                CategoryId = 10
            };

            TicketToRideCategory = new BoardgameCategory()
            {
                BoardgameId = 5,
                CategoryId = 19
            };

            GloomhavenCategory1 = new BoardgameCategory()
            {
                BoardgameId = 6,
                CategoryId = 2
            };

            GloomhavenCategory2 = new BoardgameCategory()
            {
                BoardgameId = 6,
                CategoryId = 6
            };

            GloomhavenCategory3 = new BoardgameCategory()
            {
                BoardgameId = 6,
                CategoryId = 15
            };

            GloomhavenCategory4 = new BoardgameCategory()
            {
                BoardgameId = 6,
                CategoryId = 14
            };

            MysteriumCategory1 = new BoardgameCategory()
            {
                BoardgameId = 7,
                CategoryId = 3
            };

            MysteriumCategory2 = new BoardgameCategory()
            {
                BoardgameId = 7,
                CategoryId = 7
            };

            MysteriumCategory3 = new BoardgameCategory()
            {
                BoardgameId = 7,
                CategoryId = 16
            };

            EverdellCategory1 = new BoardgameCategory()
            {
                BoardgameId = 8,
                CategoryId = 20
            };

            EverdellCategory2 = new BoardgameCategory()
            {
                BoardgameId = 8,
                CategoryId = 21
            };

            EverdellCategory3 = new BoardgameCategory()
            {
                BoardgameId = 8,
                CategoryId = 9
            };

            MonopolyBulgariaCategory1 = new BoardgameCategory()
            {
                BoardgameId = 9,
                CategoryId = 18
            };

            MonopolyBulgariaCategory2 = new BoardgameCategory()
            {
                BoardgameId = 9,
                CategoryId = 10
            };

            PandemicCategory1 = new BoardgameCategory()
            {
                BoardgameId = 10,
                CategoryId = 13
            };

            PandemicCategory2 = new BoardgameCategory()
            {
                BoardgameId = 10,
                CategoryId = 14
            };

            BrassBirminghamCategory1 = new BoardgameCategory()
            {
                BoardgameId = 11,
                CategoryId = 10
            };

            BrassBirminghamCategory2 = new BoardgameCategory()
            {
                BoardgameId = 11,
                CategoryId = 8
            };

            BrassBirminghamCategory3 = new BoardgameCategory()
            {
                BoardgameId = 11,
                CategoryId = 19
            };

            ArkNovaCategory1 = new BoardgameCategory()
            {
                BoardgameId = 12,
                CategoryId = 20
            };

            ArkNovaCategory2 = new BoardgameCategory()
            {
                BoardgameId = 12,
                CategoryId = 10
            };

            ArkNovaCategory3 = new BoardgameCategory()
            {
                BoardgameId = 12,
                CategoryId = 22
            };

            ScytheCategory1 = new BoardgameCategory()
            {
                BoardgameId = 13,
                CategoryId = 9,
            };

            ScytheCategory2 = new BoardgameCategory()
            {
                BoardgameId = 13,
                CategoryId = 10,
            };

            NemesisCategory1 = new BoardgameCategory()
            {
                BoardgameId = 14,
                CategoryId = 2
            };

            NemesisCategory2 = new BoardgameCategory()
            {
                BoardgameId = 14,
                CategoryId = 7
            };

            NemesisCategory3 = new BoardgameCategory()
            {
                BoardgameId = 14,
                CategoryId = 14
            };

            WingspanCategory1 = new BoardgameCategory()
            {
                BoardgameId = 15,
                CategoryId = 20
            };

            WingspanCategory2 = new BoardgameCategory()
            {
                BoardgameId = 15,
                CategoryId = 21
            };

            WingspanCategory3 = new BoardgameCategory()
            {
                BoardgameId = 15,
                CategoryId = 23
            };

            CascadiaCategory1 = new BoardgameCategory()
            {
                BoardgameId = 16,
                CategoryId = 20
            };

            CascadiaCategory2 = new BoardgameCategory()
            {
                BoardgameId = 16,
                CategoryId = 22
            };

            CascadiaCategory3 = new BoardgameCategory()
            {
                BoardgameId = 16,
                CategoryId = 11
            };

            CodenamesCategory1 = new BoardgameCategory()
            {
                BoardgameId = 17,
                CategoryId = 21
            };

            CodenamesCategory2 = new BoardgameCategory()
            {
                BoardgameId = 17,
                CategoryId = 16
            };

            CodenamesCategory3 = new BoardgameCategory()
            {
                BoardgameId = 17,
                CategoryId = 3
            };

            DixitCategory1 = new BoardgameCategory()
            {
                BoardgameId = 18,
                CategoryId = 21
            };

            DixitCategory2 = new BoardgameCategory()
            {
                BoardgameId = 18,
                CategoryId = 16
            };

            ExplodingKittensCategory1 = new BoardgameCategory()
            {
                BoardgameId = 19,
                CategoryId = 20
            };

            ExplodingKittensCategory2 = new BoardgameCategory()
            {
                BoardgameId = 19,
                CategoryId = 21
            };

            DecryptoCategory1 = new BoardgameCategory()
            {
                BoardgameId = 20,
                CategoryId = 3
            };

            DecryptoCategory2 = new BoardgameCategory()
            {
                BoardgameId = 20,
                CategoryId = 16
            };

            EclipseCategory1 = new BoardgameCategory()
            {
                BoardgameId = 21,
                CategoryId = 6
            };

            EclipseCategory2 = new BoardgameCategory()
            {
                BoardgameId = 21,
                CategoryId = 24
            };
        }
    }
}
