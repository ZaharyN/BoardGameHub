using BoardGameHub.Data.Data.Configuration;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoardGameHub.Data.Data
{
    public class BoardGameHubDbContext : IdentityDbContext<ApplicationUser>
    {
        private bool _seedDb;

        public BoardGameHubDbContext(DbContextOptions<BoardGameHubDbContext> options, bool seed = true)
            : base(options)
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
            else
            {
                Database.EnsureCreated();
            }

            _seedDb = seed;
        }

        public DbSet<Boardgame> Boardgames { get; set; } = null!;
        public DbSet<GameReview> GameReviews { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<BoardgameCategory> BoardgamesCategories { get; set; } = null!;
        public DbSet<PlaceType> PlaceTypes { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public DbSet<ReservationPlace> ReservationPlaces { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BoardgameCategory>()
                .HasKey(bg => new
                {
                    bg.BoardgameId,
                    bg.CategoryId
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

            if (_seedDb)
            {
                builder.ApplyConfiguration(new CategoryConfiguration());
                builder.ApplyConfiguration(new BoardgameConfiguration());
                builder.ApplyConfiguration(new BoardgameCategoryConfiguration());
                builder.ApplyConfiguration(new PlaceTypeConfiguration());
                builder.ApplyConfiguration(new ReservationPlaceConfiguration());
                builder.ApplyConfiguration(new ApplicationUserConfiguration());
            }

            base.OnModelCreating(builder);
        }
    }
}
