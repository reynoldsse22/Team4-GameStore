using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {

    }

    public DbSet<User> User {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(GetUsers());
        base.OnModelCreating(modelBuilder);
    }

    private List<User> GetUsers()
    {
        return new List<User>
        {
            new User
            {
                    ID = 1,
                    FirstName = "Bob", 
                    LastName = "Lasso", 
                    Email = "lassorocks@gmail.com",
                    Password = "Password"
                },
            new User
            {
                    ID = 2,
                    FirstName = "Sarah", 
                    LastName = "Chapman", 
                    Email = "sarahforprez@outlook.com",
                    Password = "$chap4potus"
            },
            new User
            {
                    ID = 3,
                    FirstName = "Kevin", 
                    LastName = "Roger", 
                    Email = "late4class@hotmail.com",
                    Password = "incorrect"
            },
            new User
            {
                    ID = 4,
                    FirstName = "ETSUadmin", 
                    LastName = "ETSUadmin", 
                    Email = "etsuadmin@etsu.edu",
                    Password = "root"
            }
        };   
    }
}
