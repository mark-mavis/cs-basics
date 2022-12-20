namespace Inheritance.CarTest
{
    class CarTest
    {
        public static void Run()
        {
            RaceCar racecar = new RaceCar(750, 2, 4);
            racecar.Drive();
            racecar.Honk();

            FamilyCar familyCar = new FamilyCar(128, 6, 4);
            familyCar.Drive();
            familyCar.Honk();
        }
    }
}
