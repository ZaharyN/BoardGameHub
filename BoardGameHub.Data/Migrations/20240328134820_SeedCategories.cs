using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class SeedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boardgames_Reservations_ReservationId",
                table: "Boardgames");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationId",
                table: "Boardgames",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Boardgames_Reservations_ReservationId",
                table: "Boardgames",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boardgames_Reservations_ReservationId",
                table: "Boardgames");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationId",
                table: "Boardgames",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Boardgames_Reservations_ReservationId",
                table: "Boardgames",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
