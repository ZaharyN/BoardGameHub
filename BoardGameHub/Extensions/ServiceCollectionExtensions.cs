using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Services;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BoardGameHub.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IBoardgameService, BoardgameService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IApplicationUserService, ApplicationUserService>();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services)
        {
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
            })
            .AddEntityFrameworkStores<BoardGameHubDbContext>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<BoardGameHubDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            return services;
        }
    }
}
