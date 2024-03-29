using BoardGameHub.Data.Data.DataModels;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
