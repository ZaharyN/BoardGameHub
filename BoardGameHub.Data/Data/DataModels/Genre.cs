using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Data.Data.DataModels
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        //[Required]
        //[ForeignKey(nameof(Boardgame))]
        //public int BoardGameId { get; set; }
        //
        //[Required]
        //public Boardgame BoardGame { get; set; } = null!;

        [Required]
        public List<BoardgameGenre> BoardgamesGenres { get; set; } = new List<BoardgameGenre>();
    }
}
