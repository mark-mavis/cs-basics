namespace Function.CallByReference
{
    class Program
    {

        public void Show(ref int val)
        {
            val *= val;
            Console.WriteLine("Value inside the show function " + val);
        }
    }
    public static class CallByReferenceExercise
    {
        public static void Run()
        {
            int val = 50;
            Program program = new Program();
            Console.WriteLine("Value before calling the function " + val);
            program.Show(ref val);
            Console.WriteLine("Value after calling the function " + val);
        }
    }
}
