namespace Delegates
{
    class Program
    {
        public static int Main()
        {
            //Delegate.RunDelegateExercise();
            GenericDelegate.RunGenericClassDelegate();
            FunctionDelegate.RunProgram();
            AnonymousMethodwithFuncDelegate.RunProgram();
            ActionDelegate.RunProgram();


            Console.WriteLine("Press enter to shut down...");
            Console.ReadLine();

            return 1;
        }
    }

}

