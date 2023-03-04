namespace Delegate.Generic.FunctionDelegate
{
    internal class FuncDelegateController
    {
        public static void RunExercise01()
        {
            func_del<int> sum = ClassObj.TargetMethodAddInt;
            Console.WriteLine(sum(25, 18));

            func_del<string> concat = ClassObj.TargetMethodAddString;
            Console.WriteLine(concat("Hello ", "There"));

            func_del<int> multiple = ClassObj.TargetMethodMultiplyInt;
            Console.WriteLine(multiple(23, 18));

        }
    }
}
