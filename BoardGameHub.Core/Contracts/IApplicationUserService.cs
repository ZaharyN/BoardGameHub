using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Core.Contracts
{
	public interface IApplicationUserService
	{
		Task<string> UserFullName(string id);
	}
}
