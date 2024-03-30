using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Data.Data;
using Microsoft.AspNetCore.Mvc;
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

        public Task<IEnumerable<BoardgameAllViewModel>> AllAsync()
        {
            throw new NotImplementedException();
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
