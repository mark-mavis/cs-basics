namespace ObjectClass.StaticClass
{

    static class MyMath
    {
        public static float PI = 3.14f;
        public static int Cube(int n)
        {
            return n*n*n;
        }
    }


    class StaticClass
    {
        public static void RunExercise()
        {
            Console.WriteLine("Value of PI is: " + MyMath.PI);
            Console.WriteLine("Cube of 3 is: " + MyMath.Cube(3));
        }

    }
}
