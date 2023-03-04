namespace Delegate.Predicate
{
    internal class PredicateController
    {
        public static void RunExercise_Basic()
        {
            Predicate<string> isUpper = PredicateDelegate.ClassObj.IsUpperCase;
            bool result = isUpper("hello world!!");
            Console.WriteLine(result);
        }

        public static void RunExercise_PredicateDelegateWithLambdaExpression()
        {
            PredicateDelegate.WithLambdaExpression.ClassObj.RunProgram();
        }
    }
}
