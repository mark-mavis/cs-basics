using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /*
    * ---------------LIBRARY PROVIDED GENERIC TYPE FUNC--------------
    *  C# includes built-in generic delegate types FUNC and ACTION, so that you don't need to define
    *  custom delegates manually in most cases.
    *  
    *  FUNC is a generic delegate included in the System namespace. It has zero or more input parameters
    *  and one out parameter. The last parameter is considered as an on parameter.
    *
    *  public delegate TResults Func<in T, out TResult>(T arg);
    */
    public delegate T func_del<T>(T param1, T param2);
    class FunctionDelegate
    {
        public static string TargetMethodAddString(string param1, string param2)
        {
            return param1 + param2;
        }
        public static int TargetMethodAddInt(int param1, int param2)
        {
            return param1 + param2;
        }
        public static int TargetMethodMultiplyInt(int param1, int param2)
        {
            return param1 * param2;
        }
        public static void RunProgram()
        {
            func_del<int> sum = TargetMethodAddInt;
            Console.WriteLine(sum(25, 18));

            func_del<string> concat = TargetMethodAddString;
            Console.WriteLine(concat("Hello ", "There"));

            func_del<int> multiple = TargetMethodMultiplyInt;
            Console.WriteLine(multiple(23, 18));
        }
    }

    //---------MULTIPLE TYPE DELEGATE
    //public delegate TResult TwoInputDelegate<in T1, in T2, out TResult>(int param1, int param2, bool answer);
    public delegate T2 MyCustomDelegate<in T1, out T2>(T1 param1, T1 param2);
    public delegate T4 MyCustomDelegate2<in T1, in T2, in T3, out T4>(T1 param1, T2 param2, T3 param3);
    class MultiTypeDelegate
    {
        public static bool CompareInt(int param1, int param2)
        {
            //Returns true if param1 is larger than param2
            return param1 > param2;
        }
        public static bool CompareString(string param1, string param2)
        {
            //Returns Zero is strings are equal
            return String.Compare(param2 + param1, param1) == 0;
        }
        public static decimal AddMultiType(int param1, double param2, float param3)
        {
            return (decimal)param1 + (decimal)param2 + (decimal)param3;
        }
        public static void RunProgram()
        {
            MyCustomDelegate<int, bool> compInt = MultiTypeDelegate.CompareInt;
            Console.WriteLine(compInt(23, 20));

            MyCustomDelegate<string, bool> compStr = MultiTypeDelegate.CompareString;
            Console.WriteLine(compStr("Hello", "Hell0"));

            MyCustomDelegate2<int, double, float, decimal> addmultitype = MultiTypeDelegate.AddMultiType;
            Console.WriteLine(addmultitype(4, 6.434d, 5.4f));
        }
    }


    /*
     * C# - Action Delegate
     * Action is a delegate type defined in the System namespace. An Action type 
     * delegate is the same as Func delegate except that the Action delegate doesn't 
     * return a value. In other words, an Action delegate can be used with a method 
     * that has a void return type.
     * 
     * For example, the following delegate prints an int value.
     */
    public delegate void PrintActionDelegate(int message);
    class ActionDelegate
    {
        public static void ConsolePrint(int message)
        {
            Console.WriteLine(message.ToString());
        }
        public static void RunProgram()
        {
            PrintActionDelegate printActionDel1 = ActionDelegate.ConsolePrint;
            printActionDel1(6745);

            //Instead of Creating the above delegate, you can
            Action<int> printActionDel2 = ConsolePrint;
            printActionDel2(2515616);

            //Can also...
            Action<int> printActionDel3 = new Action<int>(ConsolePrint);
            printActionDel3(342515);
        }
    }

    class AnonymousMethodwithFuncDelegate
    {
        public static void RunProgram()
        {
            //Func with Lambda Expression
            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new();
                return rnd.Next(1, 100);
            };
            //OR 
            Func<int, int, int> Sum = (x, y) => x + y;
            Console.WriteLine(getRandomNumber());
            Console.WriteLine(Sum(100, 125));
        }
        public static void RunFunctionwithLambdaExpression()
        {
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
        }
    }
    class AnonymousMethodwithActionDelegate
    {
        public static void RunProgram()
        {
            //Func with Lambda Expression
            Action<int> printInt1 = delegate (int x)
            {
                Console.WriteLine(x);
            };
            printInt1(3225252);
            
            //OR 
            
            Action<int> printInt2 = x => Console.WriteLine(x);
            printInt2(23525);
        }
    }
}
