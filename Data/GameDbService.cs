using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class GameDbService
{
    #region Private members
    private GameDbContext dbContext;
    #endregion
    #region Constructor
    public GameDbService(GameDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion
    #region Public methods
    /// <summary>
    /// This method returns the list of product
    /// </summary>
    /// <returns></returns>
    public async Task<List<Game>> GetGames()
    {
        return await dbContext.Game.ToListAsync();
    }
    /// <summary>
    /// This method add a new product to the DbContext and saves it
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    public async Task<Game> AddGameAsync(Game game)
    {
        try
        {
            dbContext.Game.Add(game);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return game;
    }
    /// <summary>
    /// This method update and existing product and saves the changes
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    public async Task<Game> UpdateGameAsync(Game game)
    {
        try
        {
            var GameExist = dbContext.Game.FirstOrDefault(p => p.ID == game.ID);
            if (GameExist != null)
            {
                dbContext.Update(game);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return game;
    }
    /// <summary>
    /// This method removes and existing product from the DbContext and saves it
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    public async Task DeleteGameAsync(Game game)
    {
        try
        {
            dbContext.Game.Remove(game);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}