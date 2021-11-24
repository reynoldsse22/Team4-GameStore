using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class ReviewDbContext : DbContext
{
    public ReviewDbContext(DbContextOptions<ReviewDbContext> options) : base(options)
    {

    }

    public DbSet<Review> Review {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Review>().HasData(GetReviews());
        base.OnModelCreating(modelBuilder);
    }

    private List<Review> GetReviews()
    {
        return new List<Review>
        {
            new Review
            {
                    ID = 1,
                    GameID = 1, 
                    Username = "GameCritic1", 
                    ReviewDescription = "This game sucks",
                    Stars = 1,
                    Date = new DateTime(2019, 6, 1)

                },
            new Review
            {
                    ID = 2,
                    GameID = 1, 
                    Username = "GameCritic2", 
                    ReviewDescription = "This game is ok",
                    Stars = 2,
                    Date = new DateTime(2019, 9, 1)
            },
            new Review
            {
                    ID = 3,
                    GameID = 1, 
                    Username = "GameCritic3", 
                    ReviewDescription = "This game is decent",
                    Stars = 3,
                    Date = new DateTime(2019, 6, 1)
            },
            new Review
            {
                    ID = 4,
                    GameID = 1, 
                    Username = "GameCritic4", 
                    ReviewDescription = "This game is average",
                    Stars = 4,
                    Date = new DateTime(2018, 2, 1)
            },
            new Review
            {
                    ID = 5,
                    GameID = 1, 
                    Username = "GameCritic5", 
                    ReviewDescription = "This game is great",
                    Stars = 5,
                    Date = new DateTime(2013, 12, 1)
            },
            new Review
            {
                    ID = 6,
                    GameID = 2, 
                    Username = "GameCritic1", 
                    ReviewDescription = "This game sucks",
                    Stars = 1,
                    Date = new DateTime(2019, 6, 1)

                },
            new Review
            {
                    ID = 7,
                    GameID = 2, 
                    Username = "GameCritic2", 
                    ReviewDescription = "This game is ok",
                    Stars = 2,
                    Date = new DateTime(2019, 9, 1)
            },
            new Review
            {
                    ID = 8,
                    GameID = 2, 
                    Username = "GameCritic3", 
                    ReviewDescription = "This game is decent",
                    Stars = 3,
                    Date = new DateTime(2019, 6, 1)
            },
            new Review
            {
                    ID = 9,
                    GameID = 2, 
                    Username = "GameCritic4", 
                    ReviewDescription = "This game is Terrible",
                    Stars = 1,
                    Date = new DateTime(2018, 2, 1)
            },
            new Review
            {
                    ID = 10,
                    GameID = 2, 
                    Username = "GameCritic5", 
                    ReviewDescription = "This game is great",
                    Stars = 5,
                    Date = new DateTime(2013, 12, 1)
            },
            new Review
            {
                    ID = 11,
                    GameID = 1, 
                    Username = "GameCritic1", 
                    ReviewDescription = "This game sucks",
                    Stars = 1,
                    Date = new DateTime(2019, 6, 1)

                },
            new Review
            {
                    ID = 12,
                    GameID = 3, 
                    Username = "GameCritic2", 
                    ReviewDescription = "This game is ok",
                    Stars = 2,
                    Date = new DateTime(2011, 9, 1)
            },
            new Review
            {
                    ID = 13,
                    GameID = 3, 
                    Username = "GameCritic3", 
                    ReviewDescription = "This game is decent",
                    Stars = 3,
                    Date = new DateTime(2014, 6, 1)
            },
            new Review
            {
                    ID = 14,
                    GameID = 3, 
                    Username = "GameCritic4", 
                    ReviewDescription = "This game is average",
                    Stars = 4,
                    Date = new DateTime(2021, 2, 1)
            },
            new Review
            {
                    ID = 15,
                    GameID = 3, 
                    Username = "GameCritic5", 
                    ReviewDescription = "This game is great",
                    Stars = 5,
                    Date = new DateTime(2015, 12, 1)
            },
            new Review
            {
                    ID = 16,
                    GameID = 4, 
                    Username = "GameCritic1", 
                    ReviewDescription = "This game sucks",
                    Stars = 1,
                    Date = new DateTime(2012, 6, 1)

                },
            new Review
            {
                    ID = 17,
                    GameID = 4, 
                    Username = "GameCritic2", 
                    ReviewDescription = "This game is ok",
                    Stars = 2,
                    Date = new DateTime(2011, 9, 1)
            },
            new Review
            {
                    ID = 18,
                    GameID = 4, 
                    Username = "GameCritic3", 
                    ReviewDescription = "This game is decent",
                    Stars = 5,
                    Date = new DateTime(2016, 8, 1)
            },
            new Review
            {
                    ID = 19,
                    GameID = 4, 
                    Username = "GameCritic4", 
                    ReviewDescription = "This game is not fun at all to play",
                    Stars = 3,
                    Date = new DateTime(2020, 12, 1)
            },
            new Review
            {
                    ID = 20,
                    GameID = 4, 
                    Username = "GameCritic5", 
                    ReviewDescription = "This game is great",
                    Stars = 5,
                    Date = new DateTime(2008, 12, 1)
            }
        };   
    }
}
