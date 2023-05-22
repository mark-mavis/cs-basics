

using Interface_Injection;
using Setter_Injection;
using ConstructorInjection;
using System.ComponentModel;
using System.Reflection.Emit;

class Program
{

    public static void Main()
    {
        Interface_Injection.Program.run();
        Setter_Injection.Program.Run();
        ConstructorInjection.Program.Run();

        
    }
}