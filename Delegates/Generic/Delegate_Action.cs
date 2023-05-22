
namespace Delegate.Generic.ActionDelegate;

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
public delegate void IntDelegate(int i);
public delegate void IntInputDel<T>(T x);
public delegate void IntInputAdderDel<T1, T2>(T1 x, T2 y);

internal class SystemDefinedDelegate_Action{
    // Class for Methods
    internal class ClassObj
    {
        public static void PrintValue(int x){
            Console.WriteLine($"ClassObj.PrintValue: {x}");
        }
        public static void PrintDoubleValue(int x){
            Console.WriteLine($"ClassObj.PrintDoubleValue: {x}");
        }
        public static void ConsolePrint(int message)
        {
            Console.WriteLine(message.ToString());
        }
    }

    public static void ActionDelegate(){
        IntInputDel<int> intDel = new IntInputDel<int>(ClassObj.PrintValue);
        intDel(10);

        //Ways of Initializing an Action Delegate
        Action<int> actionDel1 = new Action<int>(ClassObj.PrintValue);
        Action<int> actionDel2 = delegate(int x) {
            Console.WriteLine($"Anonymous Method: {x}");
        };
        Action<int> actionDel3 = (int x) => {
            Console.WriteLine($"Labda function: {x}");
        };
        
        //Multi
        actionDel1 += ClassObj.PrintDoubleValue;
        actionDel1 += delegate (int x) {
            Console.WriteLine($"x: {x}");
        };

        actionDel1(100);


        //String Argument Action Delegate
        PrintActionDelegate printActionDel1 = ClassObj.ConsolePrint;
        printActionDel1(6745);

        /*
        Instead of Creating the above delegate, you can import the action delegate from the
        System library and use it.
        */
        Action<int> printActionDel2 = ClassObj.ConsolePrint;
        printActionDel2(2515616);

        //Can also...
        Action<int> printActionDel3 = new Action<int>(ClassObj.ConsolePrint);
        printActionDel3(342515);
    }
    public static void ActionWithAnonymousFunction(){
        //Defining Action Delegate with Lambda Expression

        Action<int> printInt1 = delegate (int x)
        {
            Console.WriteLine(x);
        };

        //Invoking Action Delegate
        printInt1(3225252);

        //OR 

        Action<int> printInt2 = (x) => Console.WriteLine(x);
        printInt2(23525);

        Action<int, int> printTwoInts = (int x, int y) => Console.WriteLine($"x: {x} y: {y}");
        printTwoInts(2, 3);


        List<int> list = new List<int>(){1, 2, 3, 4, 5};
        List<List<int>> multidimensionalList = new List<List<int>>(){ 
            new List<int>(){1, 2, 3, 4, 5}, 
            new List<int>(){6, 7, 8, 9, 10}, 
            new List<int>(){11, 12, 13, 14, 15} 
        };

        list.Count((x) => x > 3);

        multidimensionalList.Count((x) => x.Average() > 3);
        Console.WriteLine(multidimensionalList.Count((x) => x.Average() > 3));
        Console.WriteLine(multidimensionalList.Sum( (x) => x.Average()));
    }
}

class DelegateProvider{
    public static Action<int> GetDelegate(string str){
        
        if(str == "double value"){
            return (int i) => {
            Console.WriteLine("Printing Double Value");
            Console.WriteLine(i*2);
            };    
        }
        else{
            return (int i) => {
                Console.WriteLine("Printing Value");
                Console.WriteLine("Hello");
            };
        }
    }
}