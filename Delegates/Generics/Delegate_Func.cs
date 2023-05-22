


namespace Delegate.Generic.FunctionDelegate
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


    //Creating Generic Delegate
    public delegate T func_del<T>(T param1, T param2);
    
    class Adder
    {
        public static string AddStrings(string param1, string param2)
        {
            return param1 + param2;
        }
        public static int AddInts(int param1, int param2)
        {
            return param1 + param2;
        }
    }

    class Multiplayer{
        public static int MultiplyInts(int param1, int param2)
        {
            return param1 * param2;
        }
    }
    internal class SystemDefinedDelegate_Func
    {
        public static void FuncDelegate()
        {
            func_del<int> sum = Adder.AddInts;
            Console.WriteLine(sum(25, 18));

            func_del<string> concat = Adder.AddStrings;
            Console.WriteLine(concat("Hello ", "There"));

            func_del<int> multiple = Multiplayer.MultiplyInts;
            Console.WriteLine(multiple(23, 18));
        }
        public static void FuncWithAnonymousFunction(){
            //Func with Lambda Expression
            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new();
                return rnd.Next(1, 100);
            };
            
            Console.WriteLine(getRandomNumber());
            
            //OR

            /*Using Predefined Func Delegate in System library. The last generic
             is always the out variable
            */
            Func<int, int, int> Sum = (x, y) => x + y;
            
            Console.WriteLine(Sum(100, 125));
        }
        public static void FuncWithLambdaFunction(){
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
        }
    }
}
