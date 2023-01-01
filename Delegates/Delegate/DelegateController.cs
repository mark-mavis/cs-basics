using Delegate.Ex01;
using Delegate.Ex02;

namespace Delegate.Delegates
{
    internal class DelegateController
    {
        public static void RunExercise01()
        {
            //Setting Target Method
            MyDelegate del = Delegate.Ex01.Delegate.ClassA.MethodA;
            del("Hello World");

            //Multicast Delegate
            MyDelegate del1 = Delegate.Ex01.Delegate.ClassA.MethodA;
            MyDelegate del2 = Delegate.Ex01.Delegate.ClassB.MethodA;
            MyDelegate combined_del = del1 + del2;
            combined_del("Combined Delegate");

            MyDelegate del3 = (string message) => Console.WriteLine("Called lambra expression: " + message);
            combined_del += del3;

            combined_del("Hello World");

            //Passing functions as a Parameter
            InvokeDelegate(del1);
        }

        private static void InvokeDelegate(MyDelegate del)
        {
            del("Hello World");
        }
    }
}
