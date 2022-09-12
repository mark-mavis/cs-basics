
namespace AbstractAccessors
{
    abstract class Animal
    {
        protected string name;
        public abstract string Name { get; set; }
    }

    class Dog : Animal
    {
        public override string Name { 
            get { return name; } 
            set { name = value; } 
        }
    }

    public class TestAbstractAccessors
    {
        public static void Run()
        {
            Dog dog = new Dog();
            dog.Name = "Tom";
            Console.WriteLine($"Name: {dog.Name}");
        }
    }
}
