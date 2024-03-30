using BoardGameHub.Data.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Models.BoardgameViewModels
{
    public class BoardgameAllViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<BoardgameGenreViewModel> BoardgameGenres { get; set; } = null!;
        public int? Rating { get; set; }
        public int AppropriateAge { get; set; }
        public double Difficulty { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int MinimumPlayersAllowedToPlay { get; set; }
        public int MaximumPlayersAllowedToPlay { get; set; }
    }
}
