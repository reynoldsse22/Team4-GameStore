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
                    ImageLink = "Images/deeznutssss.webp",
                    Description = "Technology."
                },
                new()
                {
                    ID = 2,
                    Name = "Mario Pratt", 
                    ImageLink = "Images/Mario.jpg",
                    Description = "A tutorial book for Blazor WASM technology."
                },
                new()
                {
                    ID = 3,
                    Name = "Skyrim 90th edition", 
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