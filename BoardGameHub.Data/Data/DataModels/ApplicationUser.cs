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
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required] 
        public string UserId { get; set; } = string.Empty;
        public IdentityUser User { get; set; } = null!;

        public List<GameReview> GameReviews { get; set; } = new List<GameReview>();
    }
}
