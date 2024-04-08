using BoardGameHub.Data.Data.DataModels;
using BoardGameHub.Data.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoardGameHub.Data.Data.Configuration
{
    internal class ReservationPlaceConfiguration : IEntityTypeConfiguration<ReservationPlace>
    {
        public void Configure(EntityTypeBuilder<ReservationPlace> builder)
        {
            SeedReservationPlaceData data = new SeedReservationPlaceData();

            builder.HasData(new ReservationPlace[]
            {
                data.SmallTable1,
                data.SmallTable2,
                data.SmallTable3,
                data.SmallTable4,
                data.MediumTable1,
                data.MediumTable2,
                data.MediumTable3,
                data.MediumTable4,
                data.MediumTable5,
                data.MediumTable6,
                data.MediumTable7,
                data.MediumTable8,
                data.LargeTable1,
                data.LargeTable2,
                data.WholePlace
            });
        }
    }
}
