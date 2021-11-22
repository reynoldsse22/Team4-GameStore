public class Game
{
    public int ID {get;set;}
    public string Name{get; set;}
    public float Price{get;set;}

    public float OriginalPrice{get; set;}
    public string ImageLink{get; set;}
    public string Description{get;set;}

    public Console Console{get;set;}

}

public enum Console{
    PC,
    Playstation,
    XBOX,
    Switch,
    Wii
}