using Polymorphism.InterfaceBased;
using Polymorphism.InheritanceBased;
using Polymorphism.MemberOverloading;
using Polymorphism.MemberOverriding;

/*
 * Polymorphism is the ability of a variable, function, or object to take on multiple forms.
 * 
 * 
 * Two Types of Polymorphism
 *  - Static: Collects the information to call a method at compile-time
 *  - Dynamic: Collects the information to call a method at run-time
 */

public class Program
{
    static void Main(string[] args)
    {
        //Inheritance Based - - - - - - - - - - - - 

        Machine car = new Car();
        Machine ship = new Ship();
        Machine machine = new Machine();

        IMachine imachine = new IMachine();
        imachine.StartMachine(car);
        imachine.StartMachine(ship);
        imachine.ShutdownMachine(car);
        imachine.ShutdownMachine(ship);
        imachine.StartMachine(machine);
        imachine.ShutdownMachine(machine);


        //Interface Based - - - - - - - - - - - - - - - - 
        
        CommunicationFacade CommunicationFacade = new CommunicationFacade();
        
        int mode = IO.GetUserInput(); // Collect, Parse, Return User input
        
        ICommunicationType factory = CommunicationFactory.Create(mode);     

        Console.WriteLine("Communication starting....");
        CommunicationFacade.StartCommunication(factory);




        MemberOverloading.ChangeArgs();
        MemberOverloading.ChangeDateType();

        MemberOverriding.Run();

    }

    
}
