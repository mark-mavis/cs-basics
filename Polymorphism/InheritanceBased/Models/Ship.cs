

namespace Polymorphism.InheritanceBased
{
    class Ship : Machine
    {

        public Ship() { }
        public Ship(string name, double price) : base(name, price) { }


        public override void Start()
        {
            Console.WriteLine("Ship started up");

        }
        public override void Stop()
        {
            Console.WriteLine("Ship turned off");

        }

    }
}
