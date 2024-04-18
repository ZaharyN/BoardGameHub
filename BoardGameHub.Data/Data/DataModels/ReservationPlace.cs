using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace BoardGameHub.Data.Data.DataModels
{
    public class ReservationPlace
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public PlaceType PlaceType { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(PlaceType))]
        public int PlaceTypeId { get; set; }

        [Required]
        public bool IsReserved { get; set; }

        public Reservation? Reservation { get; set; }

        [ForeignKey(nameof(Reservation))]
        public int? ReservationId { get; set; }
    }
}
