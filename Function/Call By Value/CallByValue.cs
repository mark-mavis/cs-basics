namespace Function.CallByValue
{
    internal class Program
    {
        // User defined function  
        public void Show(int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
    }

    public static class CallByValueExercise
    {
        public static void Run()
        {
            int val = 50;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before calling the function " + val);
            program.Show(val); // Calling Function by passing value            
            Console.WriteLine("Value after calling the function " + val);
        }
    }
}
