using System;
using System.Collections.Generic;
public class CartService
{
    private readonly List<Game> games;

    public CartService()
    {
        games = new();

    }

    public void AddToCart(Game game)
    {
        games.Add(game);
    }

    public List<Game> GetProductsInCart()
    {
        return games;
    }
}