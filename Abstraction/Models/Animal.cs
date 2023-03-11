namespace Abstraction.Models
{
    internal abstract class Animal
    {
        protected string? _name;
        public abstract string Name { get; set; }

        //Abstract: Derived classes have to implement the function
        protected abstract void Walk();

        //Virtual: Derived classes have the choice to implement the function
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound");
        }
        
    }
}
