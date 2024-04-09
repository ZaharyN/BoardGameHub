using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class SeedAdminAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "014d16f4-b47d-45fa-98a5-0cb40aa950c5", 0, "a4c97842-a177-420a-b1c9-fb83ee4a4eb8", "ApplicationUser", "admin@mail.com", false, "Zahary", "Nyagolov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEGuP6cwlZOVikKxCzzcIeICZZGzy6ZjDFZ0Ag/XEHsefsZUmfgRmg5CPwZHphvgwBg==", null, false, "c459d061-160b-4e0d-a686-2a8fa849cb01", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1b572cdb-ca30-43a0-8718-12df99d66c45", 0, "6c096eea-ebfc-4b92-89e5-4c7e02be64cd", "ApplicationUser", "user@mail.com", false, "Ivan", "Ivanov", false, null, "user@mail.com", "user@mail.com", "AQAAAAEAACcQAAAAEIQb3+PtPnuQYUjhuj0jPYt8SFIsT7VrEAu9aiPUBjk0i1RfsG0nwWVqlbCos9l6sw==", null, false, "dcfa720d-0e12-4842-9719-262e9ac23d20", false, "user@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014d16f4-b47d-45fa-98a5-0cb40aa950c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45");
        }
    }
}
