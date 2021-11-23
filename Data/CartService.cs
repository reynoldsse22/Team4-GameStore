using System;
using System.Collections.Generic;
public class CartService
{
    public int CartQuantity { get; set; } = 0;
    public IDictionary<Game, int> games;

    public CartService()
    {
        games = new Dictionary<Game, int>();

    }

    public void AddToCart(Game game, int number)
    {
        if(games.ContainsKey(game))
        {
            games[game] = games[game] + number;
        }
        else 
        {
            games.Add(game, number);
        }
        CartQuantity += number;
    }

    public void RemoveFromCart(Game game, int number)
    {
        games[game] = games[game] - number;
        if(games[game] <= 0)
        {  
            games.Remove(game);
        }
        CartQuantity -= number;
        if(CartQuantity < 0)
        {
            CartQuantity = 0;
        }   
    }

    public IDictionary<Game, int> GetProductsInCart()
    {
        return games;
    }
}