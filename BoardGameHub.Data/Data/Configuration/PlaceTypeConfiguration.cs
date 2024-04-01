using BoardGameHub.Data.Data.DataModels;
using BoardGameHub.Data.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Data.Data.Configuration
{
    internal class PlaceTypeConfiguration : IEntityTypeConfiguration<PlaceType>
    {
        public void Configure(EntityTypeBuilder<PlaceType> builder)
        {
            SeedPlaceTypeData data = new SeedPlaceTypeData();

            builder.HasData(new PlaceType[]
            {
                data.SmallTable,
                data.MediumTable,
                data.LargeTable,
                data.WholePlace
            });
        }
    }
}
