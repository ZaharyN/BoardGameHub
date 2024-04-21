using BoardGameHub.Data.Data.DataModels;

namespace BoardGameHub.Data.Data.Seed
{
	internal class SeedPlaceTypeData
    {
        public SeedPlaceTypeData()
        {
            SeedPlaceTypes();
        }

        public PlaceType SmallTable { get; set; }
        public PlaceType MediumTable { get; set; }
        public PlaceType LargeTable { get; set; }
        public PlaceType WholePlace { get; set; }

        void SeedPlaceTypes()
        {
            SmallTable = new PlaceType()
            {
                Id = 1,
                Name = "Small table",
                Capacity = 2,
                PricePerHour = 10.00M
            };

            MediumTable = new PlaceType()
            {
                Id = 2,
                Name = "Medium table",
                Capacity = 4,
                PricePerHour = 20.00M
            };

            LargeTable = new PlaceType()
            {
                Id = 3,
                Name = "Large table",
                Capacity = 10,
                PricePerHour = 50.00M
            };

            WholePlace = new PlaceType()
            {
                Id = 4,
                Name = "Whole place",
                Capacity = 60,
                PricePerHour = 300.00M
            };
        }
    }
}
