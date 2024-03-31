using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class Rename_Image_Url_Path : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/assets/games/Dune_Imperium_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/assets/games/Terraforming_Mars_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/assets/games/Catan_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/assets/games/Photosynthesis_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/assets/games/Ticket_To_Ride_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/assets/games/Gloomhaven_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/assets/games/Mysterium_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/assets/games/Everdell_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/assets/games/Monopoly_Bulgaria_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/assets/games/Pandemic_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "/assets/games/Brass_Birmingham_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "/assets/games/Ark_Nova_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "/assets/games/Scythe_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "/assets/games/Nemesis_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "/assets/games/Wingspan_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "/assets/games/Cascadia_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "/assets/games/Codenames_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "/assets/games/Dixit_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "/assets/games/Exlpoding_Kittens_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "/assets/games/Decrypto_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "/assets/games/Eclipse_card.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/assets/games/Dune_Imperium_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/assets/games/Terraforming_Mars_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/assets/games/Catan_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "~/assets/games/Photosynthesis_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "~/assets/games/Ticket_To_Ride_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "~/assets/games/Gloomhaven_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "~/assets/games/Mysterium_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "~/assets/games/Everdell_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "~/assets/games/Monopoly_Bulgaria_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "~/assets/games/Pandemic_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "~/assets/games/Brass_Birmingham_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "~/assets/games/Ark_Nova_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "~/assets/games/Scythe_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "~/assets/games/Nemesis_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "~/assets/games/Wingspan_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "~/assets/games/Cascadia_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "~/assets/games/Codenames_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "~/assets/games/Dixit_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "~/assets/games/Exlpoding_Kittens_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "~/assets/games/Decrypto_card.jpg");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "~/assets/games/Eclipse_card.jpg");
        }
    }
}
