using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<float>(type: "REAL", nullable: false),
                    OriginalPrice = table.Column<float>(type: "REAL", nullable: false),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Console = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "ID", "Console", "Description", "ImageLink", "Name", "OriginalPrice", "Price" },
                values: new object[] { 1, 0, "Grand Theft Auto V is an action-adventure game played from either a third-person or first-person perspective. Players complete missions—linear scenarios with set objectives—to progress through the story. Outside of the missions, players may freely roam the open world.", "Images/GTAV.jpg", "Grand Theft Auto V", 34.99f, 29.99f });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "ID", "Console", "Description", "ImageLink", "Name", "OriginalPrice", "Price" },
                values: new object[] { 2, 5, "In the game, Mario must race through the Mushroom Kingdom and save Princess Toadstool (later Princess Peach) from Bowser. Mario jumps, runs, and walks across each level. The worlds are full of enemies and platforms, and open holes.", "Images/SuperMario.png", "Mario Pratt", 24.99f, 19.99f });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "ID", "Console", "Description", "ImageLink", "Name", "OriginalPrice", "Price" },
                values: new object[] { 3, 0, "The Elder Scrolls V: Skyrim is an action role-playing game, playable from either a first or third-person perspective. The player may freely roam over the land of Skyrim—an open world environment consisting of wilderness expanses, dungeons, caves, cities, towns, fortresses, and villages.", "Images/skyrim.png", "Skyrim 90th edition", 34.99f, 14.99f });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "ID", "Console", "Description", "ImageLink", "Name", "OriginalPrice", "Price" },
                values: new object[] { 4, 3, "The game simulates the infantry and combined arms warfare of World War II", "Images/COD.jpg", "Call of Duty", 31.49f, 17.99f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
