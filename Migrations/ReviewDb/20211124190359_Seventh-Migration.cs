using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp.Migrations.ReviewDb
{
    public partial class SeventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GameID = table.Column<int>(type: "INTEGER", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    ReviewDescription = table.Column<string>(type: "TEXT", nullable: true),
                    Stars = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 1, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "This game sucks", 1, "GameCritic1" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 18, new DateTime(2016, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "This game is decent", 5, "GameCritic3" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 17, new DateTime(2011, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "This game is ok", 2, "GameCritic2" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 16, new DateTime(2012, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "This game sucks", 1, "GameCritic1" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 15, new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "This game is great", 5, "GameCritic5" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 14, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "This game is average", 4, "GameCritic4" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 13, new DateTime(2014, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "This game is decent", 3, "GameCritic3" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 12, new DateTime(2011, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "This game is ok", 2, "GameCritic2" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 11, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "This game sucks", 1, "GameCritic1" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 10, new DateTime(2013, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "This game is great", 5, "GameCritic5" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 9, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "This game is Terrible", 1, "GameCritic4" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 8, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "This game is decent", 3, "GameCritic3" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 7, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "This game is ok", 2, "GameCritic2" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 6, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "This game sucks", 1, "GameCritic1" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 5, new DateTime(2013, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "This game is great", 5, "GameCritic5" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 4, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "This game is average", 4, "GameCritic4" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 3, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "This game is decent", 3, "GameCritic3" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 2, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "This game is ok", 2, "GameCritic2" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 19, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "This game is not fun at all to play", 3, "GameCritic4" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ID", "Date", "GameID", "ReviewDescription", "Stars", "Username" },
                values: new object[] { 20, new DateTime(2008, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "This game is great", 5, "GameCritic5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
