using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class RPAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservationPlaceId",
                table: "Reservations",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3316b1b3-7646-4cb6-97c6-4c08f9feba81", "AQAAAAEAACcQAAAAEJwIP4W8XYRs7QDxnb4S4hAv37tpYZ+oLnnxuzCn9YiVQRnywKbcxJzg/2GPsVA9DA==", "6b8eac5e-14bc-40cb-954f-4ff4288fef44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0927823-6797-491b-9a2f-2acdf7881892", "AQAAAAEAACcQAAAAEPhc+rNDFkpUgZvprfdJtAhGYwqAJgiEvSPssDtW87SdXN7F9imBq8/+iKomxl1Naw==", "a366f7ec-fb8f-4d19-a69d-f89a86b72dd1" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationPlaceId",
                table: "Reservations",
                column: "ReservationPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ReservationPlaces_ReservationPlaceId",
                table: "Reservations",
                column: "ReservationPlaceId",
                principalTable: "ReservationPlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReservationPlaces_ReservationPlaceId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationPlaceId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationPlaceId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78a830b8-44cd-45fa-a53d-7380981b8500", "AQAAAAEAACcQAAAAEMlwC1ho3ZUWNlc8xxnBXPv/E1GHCwDPuwIRLVmwTYl1b7dAIL5lhIH0bZsS8KD0Iw==", "c198827b-b384-40ab-8523-87f6ffefcd2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e86f9c1-7df0-4b7f-ae08-600c80f6a1ff", "AQAAAAEAACcQAAAAEAJ4w5TfwpxFiD7jSuLHx1MJDCOvxkcKZMPGIpK18a+63XqFOPx0KnrVafkmIrrtXw==", "c451aaab-526c-4b5f-9d6f-674aa74d582a" });
        }
    }
}
