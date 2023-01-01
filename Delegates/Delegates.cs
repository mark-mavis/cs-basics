namespace Delegate.Ex01
{
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


    //Delegate that matches the method signatures in both Class A and Class B
    public delegate void MyDelegate(string message);    
    internal class Delegate
    {
        public class ClassA
        {
            public static void MethodA(string message)
            {
                Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
            }
        }
        public class ClassB
        {
            public static void MethodA(string message)
            {
                Console.WriteLine("Called ClassB.MethodA() with parameter: " + message);
            }
        }
    }
}
