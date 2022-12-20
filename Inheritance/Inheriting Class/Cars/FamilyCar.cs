namespace Inheritance.CarTest
{ 
    internal class FamilyCar : Car
    {

        public FamilyCar(int hp, int windows, int wheels)
        {
            HP = hp;
            Windows = windows;
            Wheels = wheels;
        }

        public override void Drive()
        {
            Console.WriteLine("Ppppppppprrrrrrrrrrrrr");
        }

        public override void Honk()
        {
            Console.WriteLine("HOOOONKKKK!!!!!");
        }
    }
}
