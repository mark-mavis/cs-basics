
namespace Polymorphism.InheritanceBased
{
    //Car is a Concrete Class because
    //  - it is a normal class with all attributes implemented
    //  - It can be instantiated as a normal class
    //  - Can be used as a base class

    class Car : Machine
    {
        public Car()
        {
            this.Name = "unknown";
            this.Price = 0;
        }

        public Car(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override void Start()
        {
            Console.WriteLine("Car started up");    
        }
        public sealed override void Stop() //sealed keyword make it so now inheriting classes can override the Stop method
        {
            Console.WriteLine("Car turned off");

        }
    }
}
