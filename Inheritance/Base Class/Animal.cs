namespace Inheritance
{
    internal class Animal
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        
        //Constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

     

        //Virtual method which sub classes can override
        public virtual void MakeSound()
        {

        }

        //Virtual method which sub classes can override
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        //Virtual method which sub classes can override
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
