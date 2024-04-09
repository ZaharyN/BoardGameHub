using BoardGameHub.Core.Contracts;
using BoardGameHub.Data.Data;
using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNet.Identity;
using System.Security.Claims;

namespace BoardGameHub.Core.Services
{
	public class ApplicationUserService : IApplicationUserService
	{
		private readonly BoardGameHubDbContext context;

        public ApplicationUserService(BoardGameHubDbContext _context)
        {
			context = _context;
        }

        public async Task<string> UserFullName(string id)
		{
			ApplicationUser? user = await context.ApplicationUsers.FindAsync(id);

			if(string.IsNullOrEmpty(user?.FirstName) 
				|| string.IsNullOrEmpty(user.LastName))
			{
				return null;
			}

			return $"{user.FirstName} {user.LastName}";
		}
		
	}
}
