using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Services
{
    public class BoardgameService : IBoardgameService
    {
        private readonly BoardGameHubDbContext context;

        public BoardgameService(BoardGameHubDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<BoardgameAllViewModel>> AllAsync()
        {
            IEnumerable<BoardgameAllViewModel> models = await context.Boardgames
                .Where(b => b.IsUpcoming == false)
                .AsNoTracking()
                .Select(b => new BoardgameAllViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    BoardgameGenres = b.BoardgamesGenres
                        .Select(bg => new BoardgameGenreViewModel()
                        {
                            Id = bg.GenreId,
                            Name = bg.Genre.Name
                        })
                        .ToList(),
                    Rating = b.Rating,
                    AppropriateAge = b.AppropriateAge,
                    Difficulty = b.Difficulty,
                    ImageUrl = b.ImageUrl,
                    MinimumPlayersAllowedToPlay = b.MinimumPlayersAllowedToPlay,
                    MaximumPlayersAllowedToPlay = b.MaximumPlayersAllowedToPlay
                })
                .ToListAsync();

            return models;

        }

        public Task<BoardgameCreateViewModel> CreateAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(BoardgameCreateViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BoardgameDetailsViewModel> Details(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BoardgameEditViewModel> EditAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(BoardgameEditViewModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BoardgameUpcomingViewModel>> UpcomingAsync()
        {
            throw new NotImplementedException();
        }
    }
}
