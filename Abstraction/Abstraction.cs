
namespace Abstraction
{
    abstract class Language
    {
        /*
         * Abstract classes can have 
         *  - abstract methods (method without body) 
         *  - non-abstract methods (method with the body)
         */
        public abstract void Display1();
        public void Display2(){ 
            Console.WriteLine("Base Class Display2 called");
        }
    }
    abstract class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();   //Calling the base class method also
            Console.WriteLine("Woof");
        }
    }

    public class TestAbstraction
    {
        public static void Run()
        {
            Program obj = new Program();
            obj.Display1();
            obj.Display2();
        }
    }
}
