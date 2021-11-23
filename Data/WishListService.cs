using System;
using System.Collections.Generic;
public class WishListService
{
    public int WishListQuantity { get; set; } = 0;
    protected readonly List<Game> games;

    public WishListService()
    {
        games = new();

    }

    public void AddToWishList(Game game)
    {
        if(!games.Contains(game))
        {
            games.Add(game);
            WishListQuantity++;
        }
    }

    public void RemoveFromWishList(Game game)
    {
        games.Remove(game);
        WishListQuantity--;
        if(WishListQuantity < 0)
            WishListQuantity = 0;
    }

    public List<Game> GetProductsInWishList()
    {
        return games;
    }
}