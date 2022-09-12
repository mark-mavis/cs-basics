namespace ObjectClass.Static
{
    public class Account
    {
        //Fields---------------------------
        public int id;
        public String name;
        /*-----------STATIC FIELD--------------*/
        public static int count = 0;        //Tracks number of instances of Account
        
        /*-----------STATIC FIELD--------------*/
        public static float rateOfInterest; //Interest Rate for all instances of Account

        //Public Constructor
        public Account(int id, String name)
        {
            this.id = id;
            this.name = name;
            count++;
        }

        /*-----------STATIC CONSTRUCTOR-----------*/
        static Account()
        {
            rateOfInterest = 9.5f;  // <-------Initializing the Static field
        }

        public void display()
        {
            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }

    class StaticExercise
    {
        public static void Run()
        {
            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Sonoo");
            a1.display();
            a2.display();
            
            Account.rateOfInterest = 10.5f;     //Changing Interest Rate for all Instances of the Account class
            
            a1.display();
            a2.display();

            Console.WriteLine("Total objects are: " + Account.count);
        }
    }

    
}

