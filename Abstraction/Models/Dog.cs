namespace Abstraction.Models
{
    internal class Dog : Animal
    {
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        protected override void Walk()
        {
            Console.WriteLine("Dog running!");
        }
        public override void MakeSound()
        {
            base.MakeSound();   //Calling the base class method also
            Console.WriteLine("Woof");
        }
        
    }
}
