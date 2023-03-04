/*  What if we want to pass a function as a parameter?
    *  
    *   The Delegate is a reference type data type that defines the method signature.
    *  
    *   STEP 1: Declare a delegate
    *          public delegate void MyDelegate(string message);
    *   STEP 2: Set a target method
    *          
    *          MyDelegate del = new MyDelegate(MethodA);
    *          // OR
    *           
    *          MyDelegate del = MethodA;
    *          // OR Set Lambda Expression
    *           
    *          //MyDelegate del3 = (string msg) => Console.WriteLine(msg);
    *   STEP 3: Invoke a delegate
    *  
    *   Delegate Form
    *   [modifier] delegate [return_type] [delegate_name] ([parameter list]);
    * 
    *   Modifier: Required modifier which defines the access of delegate and it is opitional to use.
    *   Delegate: Keyword which is used to define the delegate.
    *   Return Type: Type of value returned by the methods which the delegate with be going to call. It can be
    *              void. A method must have the same return type as the delegate.
    *   Deletegate Name: User-defined name or identifier for the delegate.
    *   Parameter List: The parameters which are required by the method when called through the delegate.
    */

namespace Delegate.Delegate
{
    internal class DelegateController
    {
        public static void RunExercise01()
        {
            
            //Setting Target Method
            Ex01.MyDelegate del = Ex01.Delegate.ClassA.MethodA;
            del("Hello World");

            //Multicast Delegate
            Ex01.MyDelegate del1 = Delegate.Ex01.Delegate.ClassA.MethodA;
            Ex01.MyDelegate del2 = Delegate.Ex01.Delegate.ClassB.MethodA;
            Ex01.MyDelegate combined_del = del1 + del2;
            combined_del("Combined Delegate");

            Ex01.MyDelegate del3 = (string message) => Console.WriteLine("Called lambra expression: " + message);
            combined_del += del3;

            combined_del("Hello World");

            //Passing functions as a Parameter
            InvokeDelegate(del1);
        }

        private static void InvokeDelegate(Ex01.MyDelegate del)
        {
            del("Hello World");
        }


        public static void RunExercise02()
        {

        }
    }
}
