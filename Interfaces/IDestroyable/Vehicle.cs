namespace DestroyableObjects
{
    internal class Vehicle
    {
        public int Speed { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {
            Speed = 0;
            Color = "Grey";
        }
        public Vehicle(int speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
