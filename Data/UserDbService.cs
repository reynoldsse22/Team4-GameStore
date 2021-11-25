using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class UserDbService
{
    #region Private members
    private UserDbContext dbContext;
    #endregion
    #region Constructor
    public UserDbService(UserDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion
    #region Public methods
    /// <summary>
    /// This method returns the list of product
    /// </summary>
    /// <returns></returns>
    public async Task<List<User>> GetUsers()
    {
        return await dbContext.User.ToListAsync();
    }
    /// <summary>
    /// This method add a new product to the DbContext and saves it
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<User> AddGameAsync(User user)
    {
        try
        {
            dbContext.User.Add(user);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return user;
    }
    /// <summary>
    /// This method update and existing user and saves the changes
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<User> UpdateUserAsync(User user)
    {
        try
        {
            var UserExist = dbContext.User.FirstOrDefault(p => p.ID == user.ID);
            if (UserExist != null)
            {
                dbContext.Update(user);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return user;
    }
    /// <summary>
    /// This method removes and existing user from the DbContext and saves it
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task DeleteUserAsync(User user)
    {
        try
        {
            dbContext.User.Remove(user);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        } 
    }
    #endregion
}