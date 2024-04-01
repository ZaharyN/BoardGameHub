using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class AddedDetailsImageColumnAndMadeRatingTypeDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Boardgames",
                newName: "DetailsImageUrl");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Boardgames",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardImageUrl",
                table: "Boardgames",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Dune_Imperium_card.jpg", "/assets/games/Dune_Imperium_details.jpg", 3.5 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Terraforming_Mars_card.jpg", "/assets/games/Terraforming_Mars_details.jpg", 4.5 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Catan_card.jpg", "/assets/games/Catan_details.jpg", 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Photosynthesis_card.jpg", "/assets/games/Photosynthesis_details.jpg", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Ticket_To_Ride_card.jpg", "/assets/games/Ticket_To_Ride_details.jpg", 3.5 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Gloomhaven_card.jpg", "/assets/games/Gloomhaven_details.jpg", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Mysterium_card.jpg", "/assets/games/Mysterium_details.jpg", 2.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Everdell_card.jpg", "/assets/games/Everdell_details.jpg", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Monopoly_Bulgaria_card.jpg", "/assets/games/Monopoly_Bulgaria_details.jpg", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Pandemic_card.jpg", "/assets/games/Pandemic_details.jpg", 3.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Brass_Birmingham_card.jpg", "/assets/games/Brass_Birmingham_details.jpg", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Ark_Nova_card.jpg", "/assets/games/Ark_Nova_details.jpg", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Scythe_card.jpg", "/assets/games/Scythe_details.jpg", 4.0 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Nemesis_card.jpg", "/assets/games/Nemesis_details.jpg", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Wingspan_card.jpg", "/assets/games/Wingspan_details.jpg", 3.5 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Cascadia_card.jpg", "/assets/games/Cascadia_details.jpg", 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Codenames_card.jpg", "/assets/games/Codenames_details.jpg", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Dixit_card.jpg", "/assets/games/Dixit_details.jpg", 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Exlpoding_Kittens_card.jpg", "/assets/games/Exlpoding_Kittens_details.jpg", 3.5 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Decrypto_card.jpg", "/assets/games/Decrypto_details.jpg", 3.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CardImageUrl", "DetailsImageUrl", "Rating" },
                values: new object[] { "/assets/games/Eclipse_card.jpg", "/assets/games/Eclipse_details.jpg", 4.2999999999999998 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardImageUrl",
                table: "Boardgames");

            migrationBuilder.RenameColumn(
                name: "DetailsImageUrl",
                table: "Boardgames",
                newName: "ImageUrl");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Boardgames",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Dune_Imperium_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Terraforming_Mars_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Catan_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Photosynthesis_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Ticket_To_Ride_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Gloomhaven_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Mysterium_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Everdell_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Monopoly_Bulgaria_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Pandemic_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Brass_Birmingham_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Ark_Nova_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Scythe_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Nemesis_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Wingspan_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Cascadia_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Codenames_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Dixit_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Exlpoding_Kittens_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Decrypto_card.jpg", null });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageUrl", "Rating" },
                values: new object[] { "/assets/games/Eclipse_card.jpg", null });
        }
    }
}
