using BoardGameHub.Core.Contracts;
using BoardGameHub.Data.Data;

namespace BoardGameHub.Core.Services
{
	public class ReservationService : IReservationService
	{
		private readonly BoardGameHubDbContext context;

        public ReservationService(BoardGameHubDbContext _context)
        {
            context = _context;
        }

    }
}
