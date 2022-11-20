using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /*
     * C# - PREDICATE DELEGATE
     * 
     * Predicate is the delegate like Func and Action delegates. It represents a 
     * method containing a set of criteria and checks whether the passed parameter
     * meets those criteria. A predicate delegate methods must take one input parameter 
     * and return a boolean - true or false.
     * 
     * The Predicate delegate is defined in the System namespace, as shown below:
     *      Predicate signature: public delegate bool Predicate<in T>(T obj);
     *      
     *  Same as other delegate types, Predicate can also be used with any method, 
     *  anonymous method, or lambda expression.
     */

    
    class PredicateDelegate
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        public static void RunProgram(){
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("hello world!!");
            Console.WriteLine(result);
        }
    }

    class PredicateDelegateWithAnonymousMethod
    {
        public static void RunProgram()
        {
        //Assigning an Anonymous Method to a Predicate Delegate type
            Predicate<string> isUpper = delegate(string s)
            {
                //Anonymous Method
                return s.Equals(s.ToUpper());
            };
            Console.WriteLine(isUpper("hello world"));
        }
    }

    class PredicateDelegateWithLambdaExpression
    {
        public static void RunProgram()
        {
            Predicate<string> isUpper = s => s.Equals(s.ToUpper());
            Console.WriteLine(isUpper("hello world!!"));
        }
    }
}
