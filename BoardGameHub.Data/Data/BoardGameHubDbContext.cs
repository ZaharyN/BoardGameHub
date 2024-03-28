using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoardGameHub.Data.Data
{
    public class BoardGameHubDbContext : IdentityDbContext
    {
        public BoardGameHubDbContext(DbContextOptions<BoardGameHubDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Boardgame> Boardgames { get; set; } = null!;
        public DbSet<GameReview> GameReviews { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<BoardgameGenre> BoardgamesGenres { get; set; } = null!;
        public DbSet<PlaceType> PlaceTypes { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public DbSet<ReservationPlace> ReservationPlaces { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BoardgameGenre>()
                .HasKey(bg => new
                {
                    bg.BoardgameId,
                    bg.GenreId
                });


            builder.Entity<GameReview>()
                .HasOne(gr => gr.Boardgame)
                    .WithMany(b => b.GameReviews)
                .HasForeignKey(gr => gr.BoardGameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<GameReview>()
                .HasOne(gr => gr.ReviewOwner)
                    .WithMany(reviewOwner => reviewOwner.GameReviews)
                .HasForeignKey(gr => gr.ReviewOwnerId)
                .OnDelete(DeleteBehavior.Restrict);
                
            base.OnModelCreating(builder);
        }
    }
}
