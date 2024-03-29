using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Data.Data.DataModels
{
    
    public class BoardgameGenre
    {
        public Boardgame Boardgame { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Boardgame))]
        public int BoardgameId { get; set; }

        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;

        [Required]
        public int GenreId { get; set; }

        public List<BoardgameGenre> BoardgamesGenres { get; set; } = null!;
    }
}
