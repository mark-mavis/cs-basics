using System.Globalization;

namespace Operators.Lambda
{
    public class LambdaOperators
    {
        public static void ExpressionLambda()
        {
            Console.WriteLine("Expression Lambda: input => expression;");
            Func<int, int> square = x => x*x;
            Console.WriteLine(square(5));
            Console.ReadLine();
        }

        public static void StatementLambda()
        {
            Console.WriteLine("Statement Lambda: input => { statements };");

            List<int> numbers = new List<int>() {36, 71, 12, 15, 29, 18, 27, 17, 9, 34};

            Console.WriteLine("The list : ");
            foreach (var num in numbers)
            {
                Console.WriteLine($"{num} ");
            }
            Console.WriteLine();

            var square = numbers.Select(x => x * x);

            //Func<int, bool> oddCheck = x => x%2 != 0;
            //var oddnumbers = numbers.Where(oddCheck).ToList();
        }
    }
}
