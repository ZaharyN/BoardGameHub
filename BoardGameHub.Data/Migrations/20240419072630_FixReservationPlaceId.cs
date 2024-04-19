using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class FixReservationPlaceId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
