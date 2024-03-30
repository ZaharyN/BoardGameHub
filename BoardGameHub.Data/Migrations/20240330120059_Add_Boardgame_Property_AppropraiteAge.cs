using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class Add_Boardgame_Property_AppropraiteAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppropriateAge",
                table: "Boardgames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppropriateAge",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppropriateAge",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppropriateAge",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 4,
                column: "AppropriateAge",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 5,
                column: "AppropriateAge",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 6,
                column: "AppropriateAge",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 7,
                column: "AppropriateAge",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 8,
                column: "AppropriateAge",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 9,
                column: "AppropriateAge",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 10,
                column: "AppropriateAge",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 11,
                column: "AppropriateAge",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 12,
                column: "AppropriateAge",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 13,
                column: "AppropriateAge",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 14,
                column: "AppropriateAge",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 15,
                column: "AppropriateAge",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 16,
                column: "AppropriateAge",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 17,
                column: "AppropriateAge",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 18,
                column: "AppropriateAge",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 19,
                column: "AppropriateAge",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 20,
                column: "AppropriateAge",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 21,
                column: "AppropriateAge",
                value: 14);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppropriateAge",
                table: "Boardgames");
        }
    }
}
