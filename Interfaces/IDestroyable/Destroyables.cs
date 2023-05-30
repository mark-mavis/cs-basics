namespace DestroyableObjects;


internal interface IDestroyable
{
    string DestructionSound { get; set; }
    void Destroy();
}

internal class Furniture
{
    public string Color { get; set; }
    public string Material { get; set; }

    public Furniture()
    {
        Color = "Grey";
        Material = "Wood";
    }

    public Furniture(string color, string material)
    {
        Color = color;
        Material = material;
    }
}
internal class Chair : Furniture, IDestroyable
{
    public string DestructionSound { get; set; }
    public Chair(string color, string material) : base(color, material) 
    {
        DestructionSound = "ChairBreak.mp3";
    }

    public void Destroy()
    {
        Console.WriteLine($"{DestructionSound}");
    }

}



