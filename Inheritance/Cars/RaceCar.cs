namespace Inheritance.Car
{
    internal class RaceCar : Car
    {

        public RaceCar(int hp, int windows, int wheels)
        {
            HP = hp;
            Windows = windows;
            Wheels = wheels;
        }

        public override void Drive()
        {
            Console.WriteLine("VRRRROOOOOOOOoooooooooooo");
        }

        public override void Honk()
        {
            Console.WriteLine("Race cars don't have horns");
        }
    }
}
