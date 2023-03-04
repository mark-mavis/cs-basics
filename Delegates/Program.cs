using Delegate.Delegate;
using Delegate.Generic.GenericDelegate;
using Delegate.Generic.FunctionDelegate;
using Delegate.Generic.FunctionDelegate.WithAnonymousFunction;
using Delegate.Generic.MultiTypeDelegate;
using Delegate.Generic.ActionDelegate;
using Delegate.Generic.ActionDelegate.WithAnonymousFunction;


namespace Delegate
{
    class Program
    {
        public static int Main()
        {
            //Delegate
            DelegateController.RunExercise01();
            DelegateController.RunExercise02();

            //Generic Delegate
            GenericDelegateController.RunExercise01();

            //Generic Function Delegate Class Provided by library
            FuncDelegateController.RunExercise01();

            //Using the Function Delegate Class with an Anonymous Function
            FunctionDelegateWithAnonymousMethod.RunExercise01();

            //Using the Action Delegate Class Provided by Library
            ActionDelegateController.RunExercise01();

            //Using the Action Delegate Class with an Anonymous Function
            ActionDelegateWithAnonymousMethod.RunExercise01();

            //Creating a generic delegate that can take multiple types
            MultiTypeDelegateController.RunExercise01();

            Console.WriteLine("Press enter to shut down...");
            Console.ReadLine();

            return 1;
        }
    }

}

