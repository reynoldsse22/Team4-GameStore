using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class CartDbService
{
    #region Private members
    public CartDbContext dbContext;
    public int CartQuantity { get; set; }
    #endregion
    #region Constructor
    public CartDbService(CartDbContext dbContext)
    {
        this.dbContext = dbContext;
        foreach(var game in GetCart().Result)
        {
            CartQuantity += game.Quantity;
        }
    }
    #endregion
    #region Public methods
    /// <summary>
    /// This method returns the list of product
    /// </summary>
    /// <returns></returns>
    public async Task<List<Game>> GetCart()
    {
        return await dbContext.Game.ToListAsync();
    }

    public void UpdateCartQuantity()
    {
        foreach(var game in GetCart().Result)
        {
            this.CartQuantity += game.Quantity;
        }
    }
    /// <summary>
    /// This method add a new game to the DbContext and saves it
    /// </summary>
    /// <param name="game"></param>
    /// <returns></returns>
    public async Task<Game> AddGameAsync(Game game, int Quantity)
    {
        CartQuantity = 6;
        try
        {
            Game tempGame = dbContext.Game.Where(x => x.ID == game.ID).FirstOrDefault();
            if (tempGame != null)
            {
                tempGame.Quantity += Quantity;
                UpdateCartQuantity();
                dbContext.Update(tempGame);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                game.Quantity = Quantity;
                dbContext.Game.Add(game);
                UpdateCartQuantity();
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
    public async Task<Game> UpdateCartAsync(Game game, int Quantity)
    {
        try
        {
            Game tempGame = dbContext.Game.Where(x => x.ID == game.ID).FirstOrDefault();
            if (tempGame != null)
            {
                tempGame.Quantity = tempGame.Quantity + Quantity;
                dbContext.Update(tempGame);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                await AddGameAsync(game, Quantity);
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
    public async Task DeleteGameAsync(Game game, int Quantity)
    {
        try
        {
            Game tempGame = dbContext.Game.Where(x => x.ID == game.ID).FirstOrDefault();
            if (tempGame != null)
            {
                tempGame.Quantity -= Quantity;
                if(game.Quantity <= 0)
                {
                    dbContext.Game.Remove(tempGame);
                    await dbContext.SaveChangesAsync();
                }
                else
                {
                    dbContext.Update(tempGame);
                    await dbContext.SaveChangesAsync();
                }

                UpdateCartQuantity();
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }


    #endregion
}