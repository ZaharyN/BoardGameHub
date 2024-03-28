using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace BoardGameHub.Data.Data.DataModels
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required] 
        public string UserId { get; set; } = string.Empty;
        public IdentityUser User { get; set; } = null!;

        public List<GameReview> GameReviews { get; set; } = new List<GameReview>();
    }
}
