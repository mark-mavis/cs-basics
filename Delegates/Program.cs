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

            return 1;
        }
    }

}

