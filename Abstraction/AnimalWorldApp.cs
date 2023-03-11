using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldApp
{
    internal abstract class Animal
    {
        protected string? _name;
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            _name = name;
        }
        public abstract void Move();
        public abstract void MakeSound();

    }
    internal class Eagle : Animal
    {
        public override string Name
        {
            get
            {
                if (_name != null) return _name;
                else return string.Empty;
            }
            set { _name = value; }
        }

        public Eagle(string name) : base(name)
        {
            Name = name;
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} flying");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name}: Screeeecchhhhh");
        }
    }
    internal class Pig : Animal
    {
        public override string Name
        {
            get
            {
                if (_name != null) return _name;
                else return string.Empty;
            }
            set { _name = value; }
        }
        public Pig(string name) : base(name)
        {
            Name = name;
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} Walking");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name}: Oinkkk Oinkkkk");
        }
    }
    class Program
    {
        public static void Run()
        {
            Eagle eagle = new Eagle("Falcor");
            Pig pig = new Pig("Pork Chop");

            eagle.Move();
            eagle.MakeSound();
            pig.Move();
            pig.MakeSound();
        }
    }
}
