

using Interfaces;

class Program
{
    /*
     * Contracts between itself and the class that inherits the interface. The 
     * class that inherits the interface agrees to implement all methods and properties.
     * 
     * Interfaces CANNOT contain any implementations!!
     * 
     * 
     * 
     */

    public static int Main(string[] args)
    {


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

        IShootableTest.Run();

        Console.WriteLine("Press any key to shutdown");
        Console.ReadKey();
        return 0;
    }
}