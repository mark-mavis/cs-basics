

namespace Inheritance
{
    public class BaseClass { }
    public class DerivedClass : BaseClass { }

    /*
     * Allows us to define a class in terms of another class, which makes
     * it easier to create and maintain an application. This also provides
     * oppurtunity to reuse the code functionality and speeds up
     * implementation time
     */

    class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        //Base Constructor
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }
        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
    class Radio : ElectricalDevice
    {
        //Tell the Radio constructor to pass the arguments along to the 
        // base constructor
        public Radio(bool isOn, string brand) : base(isOn, brand){} 
    }
    class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand){}

    }

    class Animal
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

        //Methods
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
    class Dog : Animal
    {
        public bool IsHappy { get;set; } 
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }
        public override void Eat()
        {
            //base.Eat(); Tells the base class eat to be called

        }
        
    }
}
