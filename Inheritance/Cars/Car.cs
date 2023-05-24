namespace Inheritance.Car
{ 
    internal abstract class Car
    {
        public int HP { get; set; } = 0;
        public int Windows { get; set; } = 0;
        public int Wheels { get; set; } = 0;
        public abstract void Drive();
        public abstract void Honk();

    }
}
