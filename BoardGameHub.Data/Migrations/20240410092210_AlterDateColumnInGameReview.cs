using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class AlterDateColumnInGameReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "GameReviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f7100bc-ea17-479d-a896-728b35e5bc53", "AQAAAAEAACcQAAAAELnhrSdg5Zp+4Vg2xOxsokmu0uwXdDM+D1tT9C6fd/kyI+tunzh5eTix0UkQQHfyPg==", "2ffd1903-99d5-40f4-aea7-a56189d78893" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c42e3d-dc0d-4891-8300-61e2664bc6c1", "AQAAAAEAACcQAAAAEEPQbAj2Zgp28necz6OAae8JynFmAXBQCEpF4UPhf8HGgBKDmuV/tvG3cSXl3IhWdw==", "18eb5d5f-a66a-4f89-a778-a859dc045b57" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "GameReviews",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014d16f4-b47d-45fa-98a5-0cb40aa950c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4c97842-a177-420a-b1c9-fb83ee4a4eb8", "AQAAAAEAACcQAAAAEGuP6cwlZOVikKxCzzcIeICZZGzy6ZjDFZ0Ag/XEHsefsZUmfgRmg5CPwZHphvgwBg==", "c459d061-160b-4e0d-a686-2a8fa849cb01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c096eea-ebfc-4b92-89e5-4c7e02be64cd", "AQAAAAEAACcQAAAAEIQb3+PtPnuQYUjhuj0jPYt8SFIsT7VrEAu9aiPUBjk0i1RfsG0nwWVqlbCos9l6sw==", "dcfa720d-0e12-4842-9719-262e9ac23d20" });
        }
    }
}
