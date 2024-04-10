﻿using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNetCore.Identity;

namespace BoardGameHub.Extensions
{
	public static class ApplicationBuilderExtensions
	{
		public static async Task CreateAdminRoleAsync(this IApplicationBuilder app)
		{
			using var scope = app.ApplicationServices.CreateScope();

			var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
			var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

			if(userManager != null && roleManager != null && await roleManager.RoleExistsAsync("Administrator") == false)
			{
				var role = new IdentityRole("Administrator");
				await roleManager.CreateAsync(role);

				var admin = await userManager.FindByEmailAsync("admin@mail.com");

				if(admin != null)
				{
					await userManager.AddToRoleAsync(admin, role.Name);
				}
			}
		}
	}
}
