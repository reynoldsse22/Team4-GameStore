using System.ComponentModel.DataAnnotations;
public class Game
{
    public int ID {get;set;}
    public string Name{get; set;}
    public float Price{get;set;}

    public float OriginalPrice{get; set;}
    public string ImageLink{get; set;}
    public string Description{get;set;}

    public Console Console{get;set;}
    public int Quantity{get;set;} = 0;

}

public enum Console{
    PC,
    Playstation_4,
    Playstation_5,
    Xbox_360,
    Xbox_One,
    Switch,
    Wii,
    Wii_U,
    DS,
    GameBoy
}