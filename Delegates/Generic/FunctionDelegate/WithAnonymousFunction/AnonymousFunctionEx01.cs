namespace Delegate.Generic.FunctionDelegate.WithAnonymousFunction
{
    internal class FunctionDelegateWithAnonymousMethod
    {
        public static void RunExercise01()
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
}
