using BoardGameHub.Data.Data.DataModels;
namespace BoardGameHub.Core.Models.ReservationViewModel
{
	public class ReservationPlaceViewModel
	{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
		public PlaceType PlaceType { get; set; } = null!;
		public int PlaceTypeId { get; set; }
		public bool IsReserved { get; set; }
		public Reservation? Reservation { get; set; }
		public int? ReservationId { get; set; }
	}
}
