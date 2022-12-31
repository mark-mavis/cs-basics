using System.Transactions;

namespace Polymorphism.InheritanceBased
{
    public class Machine : IEquatable<Machine>
    {
        //Abstract Class
        //  - Incomplete with at least one property or method not implemented
        //  - Cannot be instantiated. It can only be inherited
        //  - Intended to be used as a base class

        public string Name { get; set; } = "unknown";   //Property
        public double Price { get; set; } = 0;

        public Machine()
        {
            this.Name = "unknown";
            this.Price = 0;
        }

        public Machine(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public virtual void Start()
        {
            Console.WriteLine("Machine Started up");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Machine turned off");
        }

        public bool Equals(Machine? other)
        {
            if(other != null)
            {
                return (this.Price == other.Price);
            }
            return false;
        }
    }
}
