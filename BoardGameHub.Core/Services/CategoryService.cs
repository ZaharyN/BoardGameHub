using BoardGameHub.Core.Contracts;
using BoardGameHub.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly BoardGameHubDbContext context;

        public CategoryService(BoardGameHubDbContext _context)
        {
            context = _context;
        }
    }
}
