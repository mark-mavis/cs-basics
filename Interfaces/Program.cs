using ShootableWeapons;
using DestroyableObjects;
using GenericInterface;
using MultipleInterfaces;

/*
     * INTERFACES
     * Interfaces describe the behavior of a class. A Document class may need a "IStorable" 
     * Interface to save and load the document on the OS but the user preferences class may 
     * may also need a "IStorable" interface so creating an interface that describes the methods
     * need, and sharing them with both the classes for logic implementation
     * Contracts between itself and the class that inherits the interface. The 
     * class that inherits the interface agrees to implement all methods and properties.
     * 
     * Interfaces CANNOT contain any implementations!!
     */

class Program
{
    internal interface IStorable{
        public void Save();
        public void Load();
    }

     public class Document : IStorable{
        private string _name;
        public string Name{
            get => _name;
            set => _name = value;
        }
        public Document(string name){
            _name = name;
        }

        public void Save(){
            System.Console.WriteLine($"Saving {_name} Document");
        }
        public void Load(){
            System.Console.WriteLine($"Loading {_name} Document");
        }
     }
     public class UserPreferences : IStorable{
        private string _userprofile;
        public string UserProfile{
            get => _userprofile;
            set => _userprofile = value;
        }
        public UserPreferences(string userprofile){
            _userprofile = userprofile;
        }
        public void Save(){
            System.Console.WriteLine($"Saving {_userprofile}'s Prefereneces");
        }
        public void Load(){
            System.Console.WriteLine($"Loading {_userprofile}'s Preferences");
        }
     }

    public static void Main(string[] args)
    {

        IStorable[] application = new IStorable[2]{
            new Document("Homework.doc"),
            new UserPreferences("Mark Mavis")
        };
        //Load all IStorable classes
        foreach(IStorable s in application){
            s.Load();
        }
        //Save all IStorable Classes
        foreach(IStorable s in application){
            s.Save();
        }
        
        //----------------------------------------------------------------
        
        WeaponsTest.Run();
        //----------------------------------------------------------------
        Car car = new Car(100, "Black");
        car.DestroyableItemsNearBy.Add(new Chair("Brown", "wood"));
        car.DestroyableItemsNearBy.Add(new Car(45, "Red"));
        car.Destroy();

        //----------------------------------------------------------------
        
        CastingTest.Run();

        //----------------------------------------------------------------
        Ticket ticket1 = new Ticket(10);
        Ticket ticket2 = new Ticket(10);
        Ticket ticket3 = new Ticket(25);

        //This works because the IEquitable<Ticket> interface is inherited to the ticket, and
        //and it gives us a chance to declare how the two objects will be compared. If we used the 
        //Equals method that came with the ticket object, the result would always False because it
        //needs to be the exact same instance of the object.
        //
        Console.WriteLine(ticket1.Equals(ticket2));
        Console.WriteLine(ticket2.Equals(ticket3));

        Console.WriteLine("Press any key to shutdown");
        Console.ReadKey();

        //---------------------------------------------------------------
        //Explicit Interface Implementation

        DemoClass demoClass = new DemoClass();
        
        IFirstInterface int01 = demoClass as IFirstInterface;
        int01.SomeMethod();
        
        ISecondInterface int02 = demoClass as ISecondInterface;
        int02.SomeMethod();

        //Can Also do this...
        (demoClass as ISecondInterface).SomeMethod();
        (demoClass as IFirstInterface).SomeMethod();

        //---------------------------------------------------------------

    }
}