using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
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

    public delegate void MyDelegate(string message);
    class Delegate
    {
        class ClassA
        {
            public static void MethodA(string message)
            {
                Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
            }
        }
        class ClassB
        {
            public static void MethodA(string message)
            {
                Console.WriteLine("Called ClassB.MethodA() with parameter: " + message);
            }
        }
        public static void RunDelegateExercise()
        {
            //Setting Target Method
            MyDelegate del = ClassA.MethodA;
            del("Hello World");

            //Multicast Delegate
            MyDelegate del1 = ClassA.MethodA;
            MyDelegate del2 = ClassB.MethodA;
            MyDelegate combined_del = del1 + del2;
            combined_del("Combined Delegate");

            MyDelegate del3 = (string message) => Console.WriteLine("Called lambra expression: " + message);
            combined_del += del3;

            combined_del("Hello World");
            
            //Passing functions as a Parameter
            InvokeDelegate(del1);
        }
        static void InvokeDelegate(MyDelegate del)
        {
            del("Hello World");
        }
    }


    //Generic Delegate that works with many functions of the same signature
    public delegate T GenericDelegate<T>(T param1, T param2);
    class GenericDelegate
    {
        public static int Sum(int param1, int param2)
        {
            return param1 + param2;
        }
        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }

        public static void RunGenericClassDelegate()
        {
            GenericDelegate<int> sum = Sum;
            Console.WriteLine(sum(10, 20));

            GenericDelegate<string> concat = Concat;
            Console.WriteLine(concat("String 1 and ", "String 2 Concatenated"));
        }
        
    }
}
