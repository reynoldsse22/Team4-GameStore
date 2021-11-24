 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class WishlistDbContext : DbContext
{
    public WishlistDbContext(DbContextOptions<WishlistDbContext> options) : base(options)
    {

    }

    public DbSet<Game> Game {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>().HasData(GetWishlist());
        base.OnModelCreating(modelBuilder);
    }

    private List<Game> GetWishlist()
    {
        return new List<Game>();
    }
}
