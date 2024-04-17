using BoardGameHub.Data.Data.DataModels;
namespace BoardGameHub.Core.Models.ReservationViewModel
{
	public class ReservationPlaceViewModel
	{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int PlaceTypeId { get; set; }
    }
}
