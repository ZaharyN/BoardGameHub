using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class ChangeRatingTypeToInteger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Boardgames",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Boardgames",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

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
                keyValue: 1,
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 3,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 4,
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 5,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 6,
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 7,
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 8,
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 9,
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 10,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 11,
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 12,
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 13,
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 14,
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 15,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 16,
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 17,
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 18,
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 19,
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 20,
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 21,
                column: "Rating",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Boardgames",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Boardgames",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c52190e-7688-408a-abdf-453171a8dfa8", "AQAAAAEAACcQAAAAEDHhXExnv0LozbjK441aJbROjvibSmz/5TjyGaFrB01G6T93/+UgIXorY5vGrwG+ow==", "9a8e995f-fb71-4d1f-94cf-ae144291d14f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b2b2b1c-1b47-4d4d-8028-98d3b382ce87", "AQAAAAEAACcQAAAAEBuFhMSWTU5MabHnyQjEENYGDOs4kR1JW84YE06q0dpAJ3dXLmayMWIblN5OvpB4Gw==", "abcfa9ae-db48-41b4-a49b-3373277b0ec9" });

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rating",
                value: 3.5);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rating",
                value: 4.5);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 3,
                column: "Rating",
                value: 3.1000000000000001);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 4,
                column: "Rating",
                value: 3.7999999999999998);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 5,
                column: "Rating",
                value: 3.5);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 6,
                column: "Rating",
                value: 4.7999999999999998);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 7,
                column: "Rating",
                value: 2.2999999999999998);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 8,
                column: "Rating",
                value: 4.2999999999999998);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 9,
                column: "Rating",
                value: 4.7000000000000002);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 10,
                column: "Rating",
                value: 3.3999999999999999);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 11,
                column: "Rating",
                value: 4.7000000000000002);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 12,
                column: "Rating",
                value: 4.2000000000000002);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 13,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 14,
                column: "Rating",
                value: 4.7000000000000002);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 15,
                column: "Rating",
                value: 3.5);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 16,
                column: "Rating",
                value: 2.8999999999999999);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 17,
                column: "Rating",
                value: 4.2999999999999998);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 18,
                column: "Rating",
                value: 3.1000000000000001);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 19,
                column: "Rating",
                value: 3.5);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 20,
                column: "Rating",
                value: 3.6000000000000001);

            migrationBuilder.UpdateData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 21,
                column: "Rating",
                value: 4.2999999999999998);
        }
    }
}
