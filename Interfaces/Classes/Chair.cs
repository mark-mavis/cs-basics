namespace Interfaces
{
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
}
