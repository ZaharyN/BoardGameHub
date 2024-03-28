using BoardGameHub.Data.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Data.Data.Seed
{
    internal class SeedBoardGameData
    {
        public SeedBoardGameData()
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
                Genres = new List<BoardgameGenre>
                {
                    new BoardgameGenre()
                    {
                        BoardgameId = 1,
                        GenreId = 17
                    },
                    new BoardgameGenre()
                    {

                    }
                },

            };
        }


    }
}
