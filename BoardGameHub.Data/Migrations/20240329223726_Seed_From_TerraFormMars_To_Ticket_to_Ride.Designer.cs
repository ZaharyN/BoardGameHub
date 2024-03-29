﻿// <auto-generated />
using System;
using BoardGameHub.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    [DbContext(typeof(BoardGameHubDbContext))]
    [Migration("20240329223726_Seed_From_TerraFormMars_To_Ticket_to_Ride")]
    partial class Seed_From_TerraFormMars_To_Ticket_to_Ride
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.Boardgame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AveragePlayingTime")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<double>("Difficulty")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUpcoming")
                        .HasColumnType("bit");

                    b.Property<int>("MaximumPlayersAllowedToPlay")
                        .HasColumnType("int");

                    b.Property<int>("MinimumPlayersAllowedToPlay")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("PriceInShop")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("YearPublished")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Boardgames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AveragePlayingTime = 90,
                            Description = "Dune: Imperium is a game that uses deck-building to add a hidden-information angle to traditional worker placement. It finds inspiration in elements and characters from the Dune legacy, both the new film from Legendary Pictures and the seminal literary series from Frank Herbert, Brian Herbert, and Kevin J.Anderson.As a leader of one of the Great Houses of the Landsraad, raise your banner and marshal your forces and spies. War is coming, and at the center of the conflict is Arrakis – Dune, the desert planet.",
                            Difficulty = 3.0,
                            ImageUrl = "~/assets/games/Dune_Imperium_card.jpg",
                            IsReserved = false,
                            IsUpcoming = false,
                            MaximumPlayersAllowedToPlay = 4,
                            MinimumPlayersAllowedToPlay = 1,
                            Name = "Dune: Imperium",
                            PriceInShop = 90.00m,
                            YearPublished = 2020
                        },
                        new
                        {
                            Id = 2,
                            AveragePlayingTime = 120,
                            Description = "In the 2400s, mankind begins to terraform the planet Mars. Giant corporations, sponsored by the World Government on Earth, initiate huge projects to raise the temperature, the oxygen level, and the ocean coverage until the environment is habitable. In Terraforming Mars, you play one of those corporations and work together in the terraforming process, but compete for getting victory points that are awarded not only for your contribution to the terraforming, but also for advancing human infrastructure throughout the solar system, and doing other commendable things.",
                            Difficulty = 3.5,
                            ImageUrl = "~/assets/games/Terraforming_Mars_card.jpg",
                            IsReserved = false,
                            IsUpcoming = false,
                            MaximumPlayersAllowedToPlay = 4,
                            MinimumPlayersAllowedToPlay = 1,
                            Name = "Terraforming Mars",
                            PriceInShop = 100.00m,
                            YearPublished = 2016
                        },
                        new
                        {
                            Id = 3,
                            AveragePlayingTime = 90,
                            Description = "In CATAN (formerly The Settlers of Catan), players try to be the dominant force on the island of Catan by building settlements, cities, and roads. On each turn dice are rolled to determine what resources the island produces. Players build by spending resources (sheep, wheat, wood, brick and ore) that are depicted by these resource cards; each land type, with the exception of the unproductive desert, produces a specific resource: hills produce brick, forests produce wood, mountains produce ore, fields produce wheat, and pastures produce sheep. CATAN has won multiple awards and is one of the most popular games in recent history due to its amazing ability to appeal to experienced gamers as well as those new to the hobby.",
                            Difficulty = 2.0,
                            ImageUrl = "~/assets/games/Catan_card.jpg",
                            IsReserved = false,
                            IsUpcoming = false,
                            MaximumPlayersAllowedToPlay = 4,
                            MinimumPlayersAllowedToPlay = 3,
                            Name = "Catan",
                            PriceInShop = 50.00m,
                            YearPublished = 1995
                        },
                        new
                        {
                            Id = 4,
                            AveragePlayingTime = 60,
                            Description = "The sun shines brightly on the canopy of the forest, and the trees use this wonderful energy to grow and develop their beautiful foliage. Sow your crops wisely and the shadows of your growing trees could slow your opponents down, but don't forget that the sun revolves around the forest. Welcome to the world of Photosynthesis, the green strategy board game!",
                            Difficulty = 2.0,
                            ImageUrl = "~/assets/games/Photosynthesis_card.jpg",
                            IsReserved = false,
                            IsUpcoming = false,
                            MaximumPlayersAllowedToPlay = 4,
                            MinimumPlayersAllowedToPlay = 2,
                            Name = "Photosynthesis",
                            PriceInShop = 45.00m,
                            YearPublished = 2017
                        },
                        new
                        {
                            Id = 5,
                            AveragePlayingTime = 60,
                            Description = "With elegantly simple gameplay, Ticket to Ride can be learned in under 15 minutes. Players collect cards of various types of train cars they then use to claim railway routes in North America. The longer the routes, the more points they earn. Additional points come to those who fulfill Destination Tickets – goal cards that connect distant cities; and to the player who builds the longest continuous route.",
                            Difficulty = 1.5,
                            ImageUrl = "~/assets/games/Ticket_To_Ride_card.jpg",
                            IsReserved = false,
                            IsUpcoming = false,
                            MaximumPlayersAllowedToPlay = 5,
                            MinimumPlayersAllowedToPlay = 2,
                            Name = "Ticket to Ride",
                            PriceInShop = 70.00m,
                            YearPublished = 2004
                        });
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.BoardgameGenre", b =>
                {
                    b.Property<int>("BoardgameId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("BoardgameId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("BoardgamesGenres");

                    b.HasData(
                        new
                        {
                            BoardgameId = 1,
                            GenreId = 17
                        },
                        new
                        {
                            BoardgameId = 1,
                            GenreId = 13
                        },
                        new
                        {
                            BoardgameId = 1,
                            GenreId = 12
                        },
                        new
                        {
                            BoardgameId = 2,
                            GenreId = 10
                        },
                        new
                        {
                            BoardgameId = 2,
                            GenreId = 8
                        },
                        new
                        {
                            BoardgameId = 2,
                            GenreId = 9
                        },
                        new
                        {
                            BoardgameId = 3,
                            GenreId = 18
                        },
                        new
                        {
                            BoardgameId = 3,
                            GenreId = 10
                        },
                        new
                        {
                            BoardgameId = 4,
                            GenreId = 1
                        },
                        new
                        {
                            BoardgameId = 4,
                            GenreId = 10
                        },
                        new
                        {
                            BoardgameId = 5,
                            GenreId = 19
                        });
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.GameReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BoardGameId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReviewOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("BoardGameId");

                    b.HasIndex("ReviewOwnerId");

                    b.ToTable("GameReviews");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Abstract"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Deduction"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dexterity"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Exploration"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Industry"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Territory building"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Economy"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Puzzle"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Deckbuilder"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Placement"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Cooperative"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Combat"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Party"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Negotiation"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Trains"
                        });
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.PlaceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerHour")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("PlaceTypes");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdditionalComment")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationOwnerId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationOwnerId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.ReservationPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlaceTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlaceTypeId");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservationPlaces");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.ApplicationUser", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.Boardgame", b =>
                {
                    b.HasOne("BoardGameHub.Data.Data.DataModels.Reservation", "Reservation")
                        .WithMany("BoardgamesReserved")
                        .HasForeignKey("ReservationId");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.BoardgameGenre", b =>
                {
                    b.HasOne("BoardGameHub.Data.Data.DataModels.Boardgame", "Boardgame")
                        .WithMany("BoardgamesGenres")
                        .HasForeignKey("BoardgameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardGameHub.Data.Data.DataModels.Genre", "Genre")
                        .WithMany("BoardgamesGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boardgame");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.GameReview", b =>
                {
                    b.HasOne("BoardGameHub.Data.Data.DataModels.Boardgame", "Boardgame")
                        .WithMany("GameReviews")
                        .HasForeignKey("BoardGameId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BoardGameHub.Data.Data.DataModels.ApplicationUser", "ReviewOwner")
                        .WithMany("GameReviews")
                        .HasForeignKey("ReviewOwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Boardgame");

                    b.Navigation("ReviewOwner");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.Reservation", b =>
                {
                    b.HasOne("BoardGameHub.Data.Data.DataModels.ApplicationUser", "ReservationOwner")
                        .WithMany()
                        .HasForeignKey("ReservationOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReservationOwner");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.ReservationPlace", b =>
                {
                    b.HasOne("BoardGameHub.Data.Data.DataModels.PlaceType", "PlaceType")
                        .WithMany()
                        .HasForeignKey("PlaceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardGameHub.Data.Data.DataModels.Reservation", "Reservation")
                        .WithMany("ReservationPlaces")
                        .HasForeignKey("ReservationId");

                    b.Navigation("PlaceType");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.ApplicationUser", b =>
                {
                    b.Navigation("GameReviews");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.Boardgame", b =>
                {
                    b.Navigation("BoardgamesGenres");

                    b.Navigation("GameReviews");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.Genre", b =>
                {
                    b.Navigation("BoardgamesGenres");
                });

            modelBuilder.Entity("BoardGameHub.Data.Data.DataModels.Reservation", b =>
                {
                    b.Navigation("BoardgamesReserved");

                    b.Navigation("ReservationPlaces");
                });
#pragma warning restore 612, 618
        }
    }
}
