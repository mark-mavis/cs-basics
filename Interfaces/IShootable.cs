namespace Interfaces
{
    interface IShootable
    {
        void Shoot();
    }

    class Weapon
    {
        public string Name { get; set; }
        
        public Weapon() 
        {
            Name = "Weapon";
        }
        public void Label()
        {
            Console.WriteLine($"This is {Name}");
        }
    }

    class Gun : Weapon, IShootable
    {
        public Gun()
        {
            Name = "Gun";
        }
        public void Shoot()
        {
            Console.WriteLine("Bang!");
        }
    }
}
