using System;
using System.Collections.Generic;
namespace BlazorApp.Data
{
    public class GameService
    {
        private readonly List<Game> games;

        public GameService()
        {
            games = new()
            {
                new()
                {
                    ID = 1,
                    Name = "Rockman", 
                    Price = 29.99f,
                    ImageLink = "Images/deeznutssss.webp",
                    Description = "Technology."
                },
                new()
                {
                    ID = 2,
                    Name = "Mario Pratt", 
                    Price = 19.99f,
                    ImageLink = "Images/Mario.jpg",
                    Description = "A tutorial book for Blazor WASM technology."
                },
                new()
                {
                    ID = 3,
                    Name = "Skyrim 90th edition", 
                    Price = 14.99f,
                    ImageLink = "Images/skyrim.png",
                    Description = "Follow the journey of a programmer."
                }
            };
        }
        public List<Game> GetAllGames()
        {
            return games;
        }
    }
}