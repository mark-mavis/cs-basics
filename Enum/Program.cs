using System.Runtime.InteropServices;

using System.Runtime.CompilerServices;

namespace AnimalWorldApp;



interface IMovable 
{ 
    void Move(int x, int y, int rate);
}
class Swim : IMovable
{
    public void Move(int x, int y, int rate)
    {
        Console.WriteLine($"Swimming to position {x},{y} at a rate of {rate}");
    }
}
class Fly : IMovable
{
    private enum MovementType { Takeoff, Glide, Land };
    public void Move(int x, int y, int rate)
    {
        Console.WriteLine($"Moving to position {x}, {y}, at a rate of {rate}");
    }
}

    class Program
    {
        private enum ElectronicProductCode
        {
            Keyboard = 0, Monitor = 1, Mouse = 2,
        }

        public static void Run()
        {
            string milk_name = ProductCode.Milk.ToString();     //retrieving string MilK
            Console.WriteLine(milk_name);   
        Console.WriteLine($"Prey is Evading");
            ProductCode parse_product;
            bool status = Enum.TryParse(milk_name, out parse_product);
            Console.WriteLine(status);

            int electronic_product_code = (int)ElectronicProductCode.Keyboard;
            Console.WriteLine(electronic_product_code);
 
            Console.WriteLine(((ElectronicProductCode)electronic_product_code).ToString());

            ProductCode product_data_type;
            bool product_data_parse_status = Enum.TryParse(ElectronicProductCode.Monitor.ToString(), out product_data_type);
            
            
            Console.WriteLine(product_data_type);
            Console.WriteLine((int)product_data_type);
            Console.WriteLine(product_data_type.ToString());
            
            Console.ReadLine();
        }
        Console.WriteLine($"Flying to ({x},{y}) at a rate of {rate} ft/sec");
    }
    public void Hunt()
    {
        Console.WriteLine("B");
    }
}


class Fish : IMovable, IAnimalBehavior
{
    private IMovable _movementType;
    private IAnimalBehavior _animalbehavior;
    public Fish(IMovable movementType, IAnimalBehavior behavior)
    {
        _movementType = movementType;
        _animalbehavior = behavior;
    }
    public void Move(int x, int y, int rate)
    {
        Console.WriteLine($"Swimming to {x},{y} at a rate of {rate}");
    }
    public void Evade()
    {
        Console.WriteLine("Fish swimming deeper");
    }
}


class Program
{
    public static void Main()
    {
        enum_example.Program.Run();

    }
}