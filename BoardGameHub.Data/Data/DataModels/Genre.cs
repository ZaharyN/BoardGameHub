using System.ComponentModel.DataAnnotations;
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

        [Required]
        public List<Boardgame> Boardgames { get; set; } = new List<Boardgame>();
    }
}
