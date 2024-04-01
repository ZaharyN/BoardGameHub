using BoardGameHub.Data.Data.DataModels;

namespace BoardGameHub.Data.Data.Seed
{
    internal class SeedReservationPlaceData
    {
        public SeedReservationPlaceData()
        {
            SeedReservationPlaces();
        }

        public ReservationPlace SmallTable1 { get; set; }
        public ReservationPlace SmallTable2 { get; set; }
        public ReservationPlace SmallTable3 { get; set; }
        public ReservationPlace SmallTable4 { get; set; }
        public ReservationPlace MediumTable1 { get; set; }
        public ReservationPlace MediumTable2 { get; set; }
        public ReservationPlace MediumTable3 { get; set; }
        public ReservationPlace MediumTable4 { get; set; }
        public ReservationPlace MediumTable5 { get; set; }
        public ReservationPlace MediumTable6 { get; set; }
        public ReservationPlace MediumTable7 { get; set; }
        public ReservationPlace MediumTable8 { get; set; }
        public ReservationPlace LargeTable1 { get; set; }
        public ReservationPlace LargeTable2 { get; set; }
        public ReservationPlace WholePlace { get; set; }

        void SeedReservationPlaces()
        {
            SmallTable1 = new ReservationPlace()
            {
                Id = 1,
                Name = "Table for 2 - No1",
                PlaceTypeId = 1,
                IsReserved = false,
            };

            SmallTable2 = new ReservationPlace()
            {
                Id = 2,
                Name = "Table for 2 - No2",
                PlaceTypeId = 1,
                IsReserved = false,
            };

            SmallTable3 = new ReservationPlace()
            {
                Id = 3,
                Name = "Table for 2 - No3",
                PlaceTypeId = 1,
                IsReserved = false,
            };

            SmallTable4 = new ReservationPlace()
            {
                Id = 4,
                Name = "Table for 2 - No4",
                PlaceTypeId = 1,
                IsReserved = false,
            };

            MediumTable1 = new ReservationPlace()
            {
                Id = 5,
                Name = "Table for 4 - No1",
                PlaceTypeId = 2,
                IsReserved = false,
            };

            MediumTable2 = new ReservationPlace()
            {
                Id = 6,
                Name = "Table for 4 - No2",
                PlaceTypeId = 2,
                IsReserved = false,
            };

            MediumTable3 = new ReservationPlace()
            {
                Id = 7,
                Name = "Table for 4 - No3",
                PlaceTypeId = 2,
                IsReserved = false,
            };

            MediumTable4 = new ReservationPlace()
            {
                Id = 8,
                Name = "Table for 4 - No4",
                PlaceTypeId = 2,
                IsReserved = false,
            };

            MediumTable5 = new ReservationPlace()
            {
                Id = 9,
                Name = "Table for 4 - No5",
                PlaceTypeId = 2,
                IsReserved = false,
            };

            MediumTable6 = new ReservationPlace()
            {
                Id = 10,
                Name = "Table for 4 - No6",
                PlaceTypeId = 2,
                IsReserved = false,
            };

            MediumTable7 = new ReservationPlace()
            {
                Id = 11,
                Name = "Table for 4 - No7",
                PlaceTypeId = 2,
                IsReserved = false,
            };

            MediumTable8 = new ReservationPlace()
            {
                Id = 12,
                Name = "Table for 4 - No8",
                PlaceTypeId = 2,
                IsReserved = false,
            };

            LargeTable1 = new ReservationPlace()
            {
                Id = 13,
                Name = "Table for 10 - No1",
                PlaceTypeId = 3,
                IsReserved = false
            };

            LargeTable2 = new ReservationPlace()
            {
                Id = 14,
                Name = "Table for 10 - No2",
                PlaceTypeId = 3,
                IsReserved = false
            };

            WholePlace = new ReservationPlace()
            {
                Id = 15,
                Name = "Whole place",
                PlaceTypeId = 4,
                IsReserved = false
            };
        }
    }
}
