using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class WishlistDbService
{
    #region Private members
    private WishlistDbContext dbContext;
    public int WishListQuantity { get; set; }
    #endregion
    #region Constructor
    public WishlistDbService(WishlistDbContext dbContext)
    {
        this.dbContext = dbContext;
        WishListQuantity = GetWishlist().Result.Count;
    }
    #endregion
    #region Public methods
    /// <summary>
    /// This method returns the list of product
    /// </summary>
    /// <returns></returns>
    public async Task<List<Game>> GetWishlist()
    {
        return await dbContext.Game.ToListAsync();
    }
    /// <summary>
    /// This method add a new game to the DbContext and saves it
    /// </summary>
    /// <param name="game"></param>
    /// <returns></returns>
    public async Task<Game> AddGameAsync(Game game)
    {
        try
        {
            if(!dbContext.Game.Contains(game))
            {
                dbContext.Game.Add(game);
                WishListQuantity++;
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
    /// This method update and existing game and saves the changes
    /// </summary>
    /// <param name="game"></param>
    /// <returns></returns>
    public async Task<Game> UpdateWishlistAsync(Game game)
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
    /// <param name="game"></param>
    /// <returns></returns>
    public async Task DeleteGameAsync(Game game)
    {
        try
        {
            dbContext.Game.Remove(game);
            WishListQuantity--;
            if(WishListQuantity < 0)
            {
                WishListQuantity = 0;
            }
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}