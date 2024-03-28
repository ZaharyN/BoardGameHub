using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Data.Data.DataModels
{
    public class PlaceType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(PlaceCapacityMinValue, PlaceCapacityMaxValue)]
        public int Capacity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(typeof(decimal),
            PlacePricePerHourMinValue,
            PlacePricePerHourMaxValue)]
        public decimal PricePerHour { get; set; }

    }
}
