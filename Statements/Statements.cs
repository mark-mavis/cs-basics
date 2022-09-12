namespace Statements
{
    public class SelectionStatement
    {
        public static void If_Run()
        {
            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");

            }
        }
        public static void IfElse_Run()
        {
            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            else
            {
                Console.WriteLine("It is odd number");
            }
        }
        public static void IfElseIf_Run()
        {
            static void DisplayCharacter(char ch)
            {
                if (char.IsUpper(ch))
                {
                    Console.WriteLine($"An uppercase letter: {ch}");
                }
                else if (char.IsLower(ch))
                {
                    Console.WriteLine($"A lowercase letter: {ch}");
                }
                else if (char.IsDigit(ch))
                {
                    Console.WriteLine($"A digit: {ch}");
                }
                else
                {
                    Console.WriteLine($"Not alphanumeric character: {ch}");
                }
            }

            DisplayCharacter('f');  // Output: A lowercase letter: f
            DisplayCharacter('R');  // Output: An uppercase letter: R
            DisplayCharacter('8');  // Output: A digit: 8
            DisplayCharacter(',');  // Output: Not alphanumeric character:
        }
        public static void Switch_Run()
        {
            DisplayMeasurement(-4);  // Output: Measured value is -4; too low.
            DisplayMeasurement(5);  // Output: Measured value is 5.
            DisplayMeasurement(30);  // Output: Measured value is 30; too high.
            DisplayMeasurement(double.NaN);  // Output: Failed measurement.

            static void DisplayMeasurement(double measurement)
            {
                switch (measurement)
                {
                    case < 0.0:
                        Console.WriteLine($"Measured value is {measurement}; too low.");
                        break;

                    case > 15.0:
                        Console.WriteLine($"Measured value is {measurement}; too high.");
                        break;

                    case double.NaN:
                        Console.WriteLine("Failed measurement.");
                        break;

                    default:
                        Console.WriteLine($"Measured value is {measurement}.");
                        break;
                }
            }
        }
    }
    public class IterationStatment
    {
        public static void ForLoop_Run()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i);
            }
        }

        public static void ForEach_Run()
        {
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibNumbers)
            {
                Console.Write($"{element} ");
            }
            // Output:
            // 0 1 1 2 3 5 8 13
        }
    }
}
