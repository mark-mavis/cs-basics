using Abstraction;
using AbstractAccessors;
class Program : Language
{
    public override void Display1()
    {
        Console.WriteLine("Derived Class Display 1");
    }
    public static void Main()
    {
        TestAbstraction.Run();
        TestAbstractAccessors.Run();
        
    }
}