using BoardGameHub.Data.Data.DataModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameHub.Data.Data.Seed
{
	internal class SeedApplicationUserData
	{
		public SeedApplicationUserData() 
		{
			SeedUsers();
		}
        public ApplicationUser AppUser { get; set; }
        public ApplicationUser AdminUser { get; set; }

		void SeedUsers()
		{
			var hasher = new PasswordHasher<IdentityUser>();

			AppUser = new ApplicationUser()
			{
				Id = "1b572cdb-ca30-43a0-8718-12df99d66c45",
				UserName = "user@mail.com",
				NormalizedUserName = "user@mail.com",
				Email= "user@mail.com",
				NormalizedEmail = "user@mail.com",
				FirstName = "Ivan",
				LastName = "Ivanov",
				PhoneNumber = "0898888888"
			};

			AppUser.PasswordHash = hasher.HashPassword(AppUser, "123456z");

			AdminUser = new ApplicationUser()
			{
				Id = "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
				UserName = "admin@mail.com",
				NormalizedUserName = "admin@mail.com",
				Email = "admin@mail.com",
				NormalizedEmail = "admin@mail.com",
				FirstName = "Zahary",
				LastName = "Nyagolov"
			};

			AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "123456z");
		}
    }
}
