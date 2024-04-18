using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class ChangedReservedBoardgameToOneBoardgamePerReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoardgameReservedId",
                table: "Reservations",
                type: "int",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CardImageUrl", "DetailsImageUrl" },
                values: new object[] { "/assets/games/Exploding_Kittens_card.jpg", "/assets/games/Exploding_Kittens_details.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BoardgameReservedId",
                table: "Reservations",
                column: "BoardgameReservedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Boardgames_BoardgameReservedId",
                table: "Reservations",
                column: "BoardgameReservedId",
                principalTable: "Boardgames",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Boardgames_BoardgameReservedId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_BoardgameReservedId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "BoardgameReservedId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1932b612-25d7-4dd9-8e6f-2a4826edc244", "AQAAAAEAACcQAAAAEMGMkOyOwPIh182wY5wHELK6LNufnH6aiX2DKHBokpdV0+ATHA32NmHTQCeG64rZGg==", "f087134a-b6e1-4ae9-bc62-3770696f01d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "919c61ed-9cb7-463b-a80f-39a2a188eefd", "AQAAAAEAACcQAAAAEDF/RDak4XLPouMA0cgMBrpFyrIRf0Ete0GEGGEPPneygJB/IFygT5Xrl/5ZqGRP0g==", "eff43c15-814f-4c59-a66a-20ea70443bbe" });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CardImageUrl", "DetailsImageUrl" },
                values: new object[] { "/assets/games/Exlpoding_Kittens_card.jpg", "/assets/games/Exlpoding_Kittens_details.jpg" });
        }
    }
}
