namespace Delegate.Predicate.PredicateDelegate.WithLambdaExpression
{
    internal class ClassObj
    {
        public static void RunProgram()
        {
            Predicate<string> isUpper = s => s.Equals(s.ToUpper());
            Console.WriteLine(isUpper("hello world!!"));
        }
    }
}
