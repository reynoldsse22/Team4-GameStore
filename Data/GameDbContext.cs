using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class GameDbContext : DbContext
{
    public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
    {

    }

    public DbSet<Game> Game {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>().HasData(GetGames());
        base.OnModelCreating(modelBuilder);
    }

    private List<Game> GetGames()
    {
        return new List<Game>
        {
            new Game
            {
                    ID = 1,
                    Name = "Grand Theft Auto V", 
                    Price = 29.99f,
                    OriginalPrice = 34.99f,
                    ImageLink = "Images/GTAV.jpg",
                    Description = "Grand Theft Auto V is an action-adventure game played from either a third-person or first-person perspective. Players complete missions—linear scenarios with set objectives—to progress through the story. Outside of the missions, players may freely roam the open world.",
                    Console = Console.PC,
                    Quantity = 7
                },
            new Game
            {
                    ID = 2,
                    Name = "Mario Pratt", 
                    Price = 19.99f,
                    OriginalPrice = 24.99f,
                    ImageLink = "Images/SuperMario.png",
                    Description = "In the game, Mario must race through the Mushroom Kingdom and save Princess Toadstool (later Princess Peach) from Bowser. Mario jumps, runs, and walks across each level. The worlds are full of enemies and platforms, and open holes.",
                    Console = Console.Switch,
                    Quantity = 0
            },
            new Game
            {
                    ID = 3,
                    Name = "Skyrim 90th edition", 
                    Price = 14.99f,
                    OriginalPrice = 34.99f,
                    ImageLink = "Images/skyrim.png",
                    Description = "The Elder Scrolls V: Skyrim is an action role-playing game, playable from either a first or third-person perspective. The player may freely roam over the land of Skyrim—an open world environment consisting of wilderness expanses, dungeons, caves, cities, towns, fortresses, and villages.",
                    Console = Console.PC,
                    Quantity = 0
            },
            new Game
            {
                    ID = 4,
                    Name = "Call of Duty", 
                    Price = 17.99f,
                    OriginalPrice = 31.49f,
                    ImageLink = "Images/COD.jpg",
                    Description = "The game simulates the infantry and combined arms warfare of World War II",
                    Console = Console.Xbox_360,
                    Quantity = 0
            },
            new Game
            {
                    ID = 5,
                    Name = "Among Us", 
                    Price = 10.99f,
                    OriginalPrice = 20.99f,
                    ImageLink = "Images/sus.jpg",
                    Description = "The game simulates the infantry and combined arms warfare of World War II",
                    Console = Console.Switch,
                    Quantity = 0
            }
        };   
    }
}
