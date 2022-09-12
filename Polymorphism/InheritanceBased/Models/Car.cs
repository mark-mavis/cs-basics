
namespace Polymorphism.InheritanceBased
{
    //Car is a Concrete Class because
    //  - it is a normal class with all attributes implemented
    //  - It can be instantiated as a normal class
    //  - Can be used as a base class

    class Car : Machine
    {
        public override void Start()
        {
            Console.WriteLine("Car started up");
            
        }
        public override void Stop()
        {
            Console.WriteLine("Car turned off");

        }
    }
}
