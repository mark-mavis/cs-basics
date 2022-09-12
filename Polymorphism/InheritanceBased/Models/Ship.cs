

namespace Polymorphism.InheritanceBased
{
    class Ship : Machine
    {
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
