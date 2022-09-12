namespace Polymorphism.InheritanceBased
{
    public class Machine
    {
        //Abstract Class
        //  - Incomplete with at least one property or method not implemented
        //  - Cannot be instantiated. It can only be inherited
        //  - Intended to be used as a base class

        protected string _name;     //
        protected int _price;

        public string Name { get; set; }    //Property
        public int Price { get; set; }
        public virtual void Start()
        {
            Console.WriteLine("Machine Started up");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Machine turned off");
        }
    }
}
