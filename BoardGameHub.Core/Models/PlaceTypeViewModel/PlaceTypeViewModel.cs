namespace BoardGameHub.Core.Models.PriceViewModel
{
    public class PlaceTypeViewModel
    {
        public string Name { get; set; } = string.Empty;

        public int Capacity { get; set; }

        public decimal PricePerHour { get; set; }
    }
}
