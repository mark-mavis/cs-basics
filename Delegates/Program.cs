using Delegate;
using Delegate.Generic.GenericDelegate;
using Delegate.Generic.FunctionDelegate;
using Delegate.Generic.MultiTypeDelegate;
using Delegate.Generic.ActionDelegate;



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
            GenericDelegate.RunExercise01();

            //Generic Function Delegate Class Provided by library
            SystemDefinedDelegate_Func.FuncDelegate();

            //Using the Function Delegate Class with an Anonymous Function
            SystemDefinedDelegate_Func.FuncWithAnonymousFunction();

            //Using the Action Delegate Class Provided by Library
            SystemDefinedDelegate_Action.ActionDelegate();

            //Using the Action Delegate Class with an Anonymous Function
            SystemDefinedDelegate_Action.ActionWithAnonymousFunction();

            //Creating a generic delegate that can take multiple types
            MultiTypeDelegateController.RunExercise01();

            Action<int> returedDel = DelegateProvider.GetDelegate("double value");
            returedDel(10);
            returedDel = DelegateProvider.GetDelegate("Regular");
            returedDel(10);



            SystemDefinedDelegate_Predicate.Predicate();
            SystemDefinedDelegate_Predicate.PredicateWithAnonymousFunction();
            SystemDefinedDelegate_Predicate.PredicateWithLambdaExpression();

            Console.WriteLine("Press enter to shut down...");
            Console.ReadLine();



            return 1;
        }
    }

}

