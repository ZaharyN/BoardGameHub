using BoardGameHub.Core.Models.BoardgameViewModels;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Contracts
{
    public interface IBoardgameService
    {
        Task<IEnumerable<BoardgameActiveViewModel>> ActiveAsync();
        Task<IEnumerable<BoardgameUpcomingViewModel>> UpcomingAsync();
        Task PromoteToActiveAsync(Boardgame boardgame);
        Task CreateAsync(BoardgameCreateViewModel model, string userId);
        Task<BoardgameEditViewModel> EditAsync(int id);
        Task EditAsync(BoardgameEditViewModel model, string userId);
        Task Delete(int id);
        Task<BoardgameDetailsViewModel> Details(int id);
    }
}
