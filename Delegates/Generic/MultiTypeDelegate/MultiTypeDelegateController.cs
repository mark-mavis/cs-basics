namespace Delegate.Generic.MultiTypeDelegate
{
    internal class MultiTypeDelegateController
    {
        public static void RunExercise01()
        {
            MyCustomDelegate<int, bool> compInt = ClassObj.CompareInt;
            Console.WriteLine(compInt(23, 20));

            MyCustomDelegate<string, bool> compStr = ClassObj.CompareString;
            Console.WriteLine(compStr("Hello", "Hell0"));

            MyCustomDelegate2<int, double, float, decimal> addmultitype = ClassObj.AddMultiType;
            Console.WriteLine(addmultitype(4, 6.434d, 5.4f));
        }
    }
}
