 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class CartDbContext : DbContext
{
    public CartDbContext(DbContextOptions<CartDbContext> options) : base(options)
    {

    }

    public DbSet<Game> Game {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>().HasData(GetCart());
        base.OnModelCreating(modelBuilder);
    }

    private List<Game> GetCart()
    {
        return new List<Game>();
    }
}
