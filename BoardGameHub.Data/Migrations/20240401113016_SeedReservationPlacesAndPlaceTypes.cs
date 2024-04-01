using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class SeedReservationPlacesAndPlaceTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlaceTypes",
                columns: new[] { "Id", "Capacity", "Name", "PricePerHour" },
                values: new object[,]
                {
                    { 1, 2, "Small table", 10.00m },
                    { 2, 4, "Medium table", 20.00m },
                    { 3, 10, "Large table", 50.00m },
                    { 4, 60, "Whole place", 300.00m }
                });

            migrationBuilder.InsertData(
                table: "ReservationPlaces",
                columns: new[] { "Id", "IsReserved", "Name", "PlaceTypeId", "ReservationId" },
                values: new object[,]
                {
                    { 1, false, "Table for 2 - No1", 1, null },
                    { 2, false, "Table for 2 - No2", 1, null },
                    { 3, false, "Table for 2 - No3", 1, null },
                    { 4, false, "Table for 2 - No4", 1, null },
                    { 5, false, "Table for 4 - No1", 2, null },
                    { 6, false, "Table for 4 - No2", 2, null },
                    { 7, false, "Table for 4 - No3", 2, null },
                    { 8, false, "Table for 4 - No4", 2, null },
                    { 9, false, "Table for 4 - No5", 2, null },
                    { 10, false, "Table for 4 - No6", 2, null },
                    { 11, false, "Table for 4 - No7", 2, null },
                    { 12, false, "Table for 4 - No8", 2, null },
                    { 13, false, "Table for 10 - No1", 3, null },
                    { 14, false, "Table for 10 - No2", 3, null },
                    { 15, false, "Whole place", 4, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ReservationPlaces",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PlaceTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlaceTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlaceTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlaceTypes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
