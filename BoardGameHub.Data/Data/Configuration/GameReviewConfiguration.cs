using BoardGameHub.Data.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoardGameHub.Data.Data.Configuration
{
    internal class GameReviewConfiguration : IEntityTypeConfiguration<GameReview>
    {
        public void Configure(EntityTypeBuilder<GameReview> builder)
        {
            builder
               .HasOne(gr => gr.Boardgame)
                   .WithMany(b => b.GameReviews)
               .HasForeignKey(gr => gr.BoardGameId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(gr => gr.ReviewOwner)
                   .WithMany(reviewOwner => reviewOwner.GameReviews)
               .HasForeignKey(gr => gr.ReviewOwnerId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
