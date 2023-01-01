using Delegate.Delegates;

namespace Delegates
{
    class Program
    {
        public static int Main()
        {
            DelegateController.RunExercise01();
            GenericDelegateController.RunExercise();
            FunctionDelegate.RunProgram();
            AnonymousMethodwithFuncDelegate.RunProgram();
            ActionDelegate.RunProgram();


            Console.WriteLine("Press enter to shut down...");
            Console.ReadLine();

            return 1;
        }
    }

}

