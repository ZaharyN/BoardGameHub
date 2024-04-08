using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameHub.Data.Migrations
{
    public partial class ChangeGenreToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoardgamesGenres");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014d16f4-b47d-45fa-98a5-0cb40aa950c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b572cdb-ca30-43a0-8718-12df99d66c45");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoardgamesCategories",
                columns: table => new
                {
                    BoardgameId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardgamesCategories", x => new { x.BoardgameId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BoardgamesCategories_Boardgames_BoardgameId",
                        column: x => x.BoardgameId,
                        principalTable: "Boardgames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoardgamesCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Abstract" },
                    { 2, "Adventure" },
                    { 3, "Deduction" },
                    { 4, "Dexterity" },
                    { 5, "Family" },
                    { 6, "Exploration" },
                    { 7, "Horror" },
                    { 8, "Industry" },
                    { 9, "Territory building" },
                    { 10, "Economy" },
                    { 11, "Puzzle" },
                    { 12, "Deckbuilder" },
                    { 13, "Placement" },
                    { 14, "Cooperative" },
                    { 15, "Combat" },
                    { 16, "Party" },
                    { 17, "Strategy" },
                    { 18, "Negotiation" },
                    { 19, "Trains" },
                    { 20, "Animals" },
                    { 21, "Card game" },
                    { 22, "Environmental" },
                    { 23, "Educational" },
                    { 24, "Civilization" }
                });

            migrationBuilder.InsertData(
                table: "BoardgamesCategories",
                columns: new[] { "BoardgameId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 17 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 10 },
                    { 3, 18 },
                    { 4, 1 },
                    { 4, 10 },
                    { 5, 19 },
                    { 6, 2 },
                    { 6, 6 },
                    { 6, 14 },
                    { 6, 15 },
                    { 7, 3 },
                    { 7, 7 },
                    { 7, 16 },
                    { 8, 9 },
                    { 8, 20 },
                    { 8, 21 },
                    { 9, 10 },
                    { 9, 18 },
                    { 10, 13 },
                    { 10, 14 },
                    { 11, 8 },
                    { 11, 10 },
                    { 11, 19 },
                    { 12, 10 },
                    { 12, 20 },
                    { 12, 22 },
                    { 13, 9 },
                    { 13, 10 },
                    { 14, 2 },
                    { 14, 7 },
                    { 14, 14 },
                    { 15, 20 },
                    { 15, 21 },
                    { 15, 23 },
                    { 16, 11 },
                    { 16, 20 },
                    { 16, 22 }
                });

            migrationBuilder.InsertData(
                table: "BoardgamesCategories",
                columns: new[] { "BoardgameId", "CategoryId" },
                values: new object[,]
                {
                    { 17, 3 },
                    { 17, 16 },
                    { 17, 21 },
                    { 18, 16 },
                    { 18, 21 },
                    { 19, 20 },
                    { 19, 21 },
                    { 20, 3 },
                    { 20, 16 },
                    { 21, 6 },
                    { 21, 24 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardgamesCategories_CategoryId",
                table: "BoardgamesCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoardgamesCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoardgamesGenres",
                columns: table => new
                {
                    BoardgameId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardgamesGenres", x => new { x.BoardgameId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_BoardgamesGenres_Boardgames_BoardgameId",
                        column: x => x.BoardgameId,
                        principalTable: "Boardgames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoardgamesGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "014d16f4-b47d-45fa-98a5-0cb40aa950c5", 0, "c1e8224e-12ef-4daa-aca0-c65fa699bb30", "admin@mail.com", false, "Zahary", "Nyagolov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEDxpuLKL2Dt7O/HRZsntCEDG8hlFTF3cS2+ZrdGMl5MyqHCGCEyNuXhet/buWbtCgA==", "", false, "f82bb126-5a41-472b-9d2d-75f9a2ce51b6", false, "admin@mail.com" },
                    { "1b572cdb-ca30-43a0-8718-12df99d66c45", 0, "b128cff9-3f18-4d34-8946-2c111d2b7f69", "user@mail.com", false, "Ivan", "Ivanov", false, null, "user@mail.com", "user@mail.com", "AQAAAAEAACcQAAAAEKASGe3mq6rGo7frynK2KQggIQt5bfPQc6LdIl9edUyZAQcdBhYHxe/20pNOrcdAdg==", "0898888888", false, "dca7a5cd-f489-4674-aec9-829c4fe47c3e", false, "user@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Abstract" },
                    { 2, "Adventure" },
                    { 3, "Deduction" },
                    { 4, "Dexterity" },
                    { 5, "Family" },
                    { 6, "Exploration" },
                    { 7, "Horror" },
                    { 8, "Industry" },
                    { 9, "Territory building" },
                    { 10, "Economy" },
                    { 11, "Puzzle" },
                    { 12, "Deckbuilder" },
                    { 13, "Placement" },
                    { 14, "Cooperative" },
                    { 15, "Combat" },
                    { 16, "Party" },
                    { 17, "Strategy" },
                    { 18, "Negotiation" },
                    { 19, "Trains" },
                    { 20, "Animals" },
                    { 21, "Card game" },
                    { 22, "Environmental" },
                    { 23, "Educational" },
                    { 24, "Civilization" }
                });

            migrationBuilder.InsertData(
                table: "BoardgamesGenres",
                columns: new[] { "BoardgameId", "GenreId" },
                values: new object[,]
                {
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 17 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 10 },
                    { 3, 18 },
                    { 4, 1 },
                    { 4, 10 },
                    { 5, 19 },
                    { 6, 2 },
                    { 6, 6 },
                    { 6, 14 },
                    { 6, 15 },
                    { 7, 3 },
                    { 7, 7 },
                    { 7, 16 },
                    { 8, 9 },
                    { 8, 20 },
                    { 8, 21 },
                    { 9, 10 },
                    { 9, 18 },
                    { 10, 13 },
                    { 10, 14 },
                    { 11, 8 },
                    { 11, 10 },
                    { 11, 19 },
                    { 12, 10 },
                    { 12, 20 },
                    { 12, 22 },
                    { 13, 9 },
                    { 13, 10 },
                    { 14, 2 },
                    { 14, 7 },
                    { 14, 14 },
                    { 15, 20 },
                    { 15, 21 },
                    { 15, 23 },
                    { 16, 11 },
                    { 16, 20 },
                    { 16, 22 }
                });

            migrationBuilder.InsertData(
                table: "BoardgamesGenres",
                columns: new[] { "BoardgameId", "GenreId" },
                values: new object[,]
                {
                    { 17, 3 },
                    { 17, 16 },
                    { 17, 21 },
                    { 18, 16 },
                    { 18, 21 },
                    { 19, 20 },
                    { 19, 21 },
                    { 20, 3 },
                    { 20, 16 },
                    { 21, 6 },
                    { 21, 24 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardgamesGenres_GenreId",
                table: "BoardgamesGenres",
                column: "GenreId");
        }
    }
}
