using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass.StaticConstructor
{
    class Account
    {
        public int id;
        public string name;
        public static float rateOfInterest;
        public Account(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        static Account()
        {
            rateOfInterest = 9.5f;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }

    class StaticConstructor
    {
        public static void RunExercise()
        {
            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Sonoo");
            a1.Display();
            a2.Display();
        }
    }

    
}
