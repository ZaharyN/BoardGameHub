using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static BoardGameHub.Data.Constants.DataConstants;
using System.Reflection.Metadata.Ecma335;

namespace BoardGameHub.Data.Data.DataModels
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(UserFirstNameMaxLength)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(UserLastNameMaxLength)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.PhoneNumber)]
        public override string PhoneNumber { get; set; } = string.Empty;

        public List<GameReview> GameReviews { get; set; } = new List<GameReview>();
    }
}
