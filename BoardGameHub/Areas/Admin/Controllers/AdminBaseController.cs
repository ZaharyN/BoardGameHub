using BoardGameHub.Core.Contracts;
using BoardGameHub.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using static BoardGameHub.Data.Constants.DataConstants;

namespace BoardGameHub.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = AdminRole)]
	public class AdminBaseController : Controller
	{
		
	}
}
