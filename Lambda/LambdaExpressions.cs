
using System.ComponentModel;

namespace Lambda
{
    class LambdaExpressions {

        //  Lambda Expressions are anonymous functions
        //  x => x*x

        //  Typical Functions look like...
        //  f(x) == x*x       - the function returns x^2
        //  square(x) == x*x  - the function also returns x^2

        //  The only difference between the two function are the name so
        //  anonymising them yields the same result.

        /*
         * Lambda expressions are used when the function is short and simple, and defining
         * it separately and giving it a descriptive name is not necessary. 
         * 
         * TWO TYPES OF LAMBDA EXPRESSIONS
         * 
         *  1. Expression Lambdas
         *      The body (right side) is an expression, such as x*x in x => x*x
         *  2. Statement Lambdas
         *      The body are blocks of code
         *      
         *  LAMBDA EXPRESSIONS in LINQ
         *  
         *  TWO WAYS TO QUERY OBJECTS USING LINQ
         *     
         *  1. Query Syntax - converted into a method call and a lambda by the .NET common language runtime (CLR)
         *  2. Method Syntax = 
         *  
         *  
         *  PREDICATE = A statement that, depending on the values of its variables, will be true or false.
         */



        public static void RunLambdaExpression()
        {
            var numbers = new int[]{2, 7, 5, 9, 1, 5, 3, 0, 7, 6 };
            int count = numbers.Count(x => x == 5); //  The LINQ query is the "Count" method. It is saying "query the list "numbers" when the 
                                                    //  lambda expression (x => x==5) evaluates to true".
            Console.WriteLine(count);
        }

        public static void RunStatementLambda()
        {
            List<int> numbers = new List<int> { 2, 7, 5, 9, 1, 5, 3, 0, 7, 6 };
            int count = numbers.Count(x => 
            { 
                return x == 5; 
            });
            Console.WriteLine(count);
        }

        public static void RunLambdaExpressionsInDelegates()
        {
            //Func<in T, out TResult>(T arg)
            Func<int, int> squareDelegate = x => x*x;
            Console.WriteLine(squareDelegate(2));

            //Func<in, int, out> add
            Func<int, int, int> Add = Sum;
            Console.WriteLine(Add(10, 20));
        }

        public static int Sum(int x, int y)
        {
            return x+y;
        }
       



        public static void RunQueryExpression()
        {
            int[] scores = new int[] { 97, 92, 81, 60};

            IEnumerable<int> scoreQuery = 
                from score in scores
                where score > 80
                select score;

            foreach(int i in scoreQuery)
            {
                Console.WriteLine(i + " ");
            }
        }


    }
}
