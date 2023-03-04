namespace Delegate.Generic.GenericDelegate
{
    class GenericDelegateController
    {
        public static void RunExercise01()
        {
            GenericDelegate<int> sum = ClassObj.Sum;
            Console.WriteLine(sum(10, 20));

            GenericDelegate<string> concat = ClassObj.Concat;
            Console.WriteLine(concat("String 1 and ", "String 2 Concatenated"));
        }
    }

}
