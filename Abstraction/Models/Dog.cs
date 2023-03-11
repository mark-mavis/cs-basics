namespace Abstraction.Models
{
    internal class Dog : Animal
    {
        public override string Name
        {
            get { 
                    if(_name != null) return _name;
                    else return "No name";
                }
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
