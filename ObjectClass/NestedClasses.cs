
namespace ObjectClass.NestedClasses
{
    class Car
    {
        public void DisplayCar()
        {
            Console.WriteLine("Mercedes");
        }
        public class Engine
        {
            public void DisplayEngine()
            {
                Console.WriteLine("Engine: V8");
            }
        }
    }

    class TestNestedClasses
    {
        public static void Run()
        {
            Car obj = new Car();
            obj.DisplayCar();

            Car.Engine engine = new Car.Engine();
            engine.DisplayEngine();
        }
    }
}
