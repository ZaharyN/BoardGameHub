using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class AddedBooleanPropertyIsExpiredToReservationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExpired",
                table: "Reservations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "ReservationPlaces",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd0d7c1c-8a28-457a-848f-a56087de573c", "AQAAAAEAACcQAAAAEDPVSyVMJBZUOCzTujhq7dyNkK7bzf/RX8umUtgdE8OPG0GmmAOQLvXSMOPd+sC5GA==", "22344d1d-90ca-4f76-ac3f-708494bb42c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ee4ae68-f7b8-4880-9f7a-455275799a71", "AQAAAAEAACcQAAAAECdyKp1KCxuo5b54ZuYlEk2QcdNZhsYeRpYPpO+1jf2dSrELs+jD8vZEDvOWXZYIFQ==", "6a708a46-483c-4c0e-a9b5-ede12bddc86a" });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationPlaces_ReservationId",
                table: "ReservationPlaces",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationPlaces_Reservations_ReservationId",
                table: "ReservationPlaces",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationPlaces_Reservations_ReservationId",
                table: "ReservationPlaces");

            migrationBuilder.DropIndex(
                name: "IX_ReservationPlaces_ReservationId",
                table: "ReservationPlaces");

            migrationBuilder.DropColumn(
                name: "IsExpired",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "ReservationPlaces");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85d5f9a1-edbc-4fcb-8e34-6a390eed8d95", "AQAAAAEAACcQAAAAELwBJTO0sMTPQqmssshQgSYsOhbvAb/jPpUMcBvOWNBFO3Py18dy8LBpxswtbB5AnA==", "37166d6e-baa6-4a68-9f2a-c45ca4245077" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee8eecf3-14f2-45bb-8779-56d9bf1e1e8c", "AQAAAAEAACcQAAAAEGmADaZBIuajkQR+n6uJibRjDIcoePKjYOqiFIXHwc91CXTGEfro/D0Hwgl/+P5cfA==", "bb3fbea3-2e3d-42b1-8cfe-657744b626f8" });
        }
    }
}
