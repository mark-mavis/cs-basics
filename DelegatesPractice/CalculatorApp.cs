namespace CalculatorApp
{
    public delegate int CalculatorDel(int x, int Y);
    public class Calculator
    {
        public static int Addition(int x, int y)
        {
            Console.WriteLine($"Adding: {x} + {y}");
            return x + y;
        }

        public static int Subtraction(int x, int y)
        {
            Console.WriteLine($"Subtracting: {x} - {y}");
            return x - y;
        }

        public static int Divide(int x, int y)
        {
            Console.WriteLine($"Dividing: {x} / {y}");
            return x / y;
        }

        public static int Multiply(int x, int y)
        {
            Console.WriteLine($"Multiplying: {x} * {y}");
            return x * y;
        }

        public static void Run()
        {
            CalculatorDel calc = Addition;
            Console.WriteLine(calc(23, 51));

            calc = Subtraction;
            Console.WriteLine(calc(100, 22));

            calc = Divide;
            Console.WriteLine(calc(100, 5));
            
            calc = Multiply;
            Console.WriteLine(calc(100, 4));
        }
    }
}

