using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class DeletetingFKReferenceFromRPlaceToReservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationPlaces_Reservations_ReservationId",
                table: "ReservationPlaces");

            migrationBuilder.DropIndex(
                name: "IX_ReservationPlaces_ReservationId",
                table: "ReservationPlaces");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "c9d3d8f5-4cdc-49f1-9a4d-fd3021b61370", "AQAAAAEAACcQAAAAEJP0Aq8D6rXE3hrfaobFidzhtyU6jg1UuzqhWoJt2MnUtOrGp0bEg6k3KGTenF56UA==", "575078aa-a1f8-4206-8a0a-ad0723309280" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "486ffee7-c3d2-403a-968c-75b7d15e4e76", "AQAAAAEAACcQAAAAEHGilUkHBX1EILvidX7rNR06OwdVmeAlFN+dR6wfALH/IlYjrpLuQ5TyobHd6612eg==", "29bae0f5-c38f-473c-96c2-f96fc2019649" });

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
    }
}
