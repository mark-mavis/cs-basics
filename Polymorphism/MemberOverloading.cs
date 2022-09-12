namespace Polymorphism.MemberOverloading
{
    //Exercise Helper Class
    public class Calculate
    {
        public static int Add(int a, int b)
        {
            return a+b;
        }
        public static double Add(float a, float b)
        {
            return a+b;
        }

        public static int Add(int a, int b, int c)
        {
            return a+b+c;
        }
    }
    public static class MemberOverloading
    {
        public static void ChangeArgs()
        {
            Console.WriteLine(Calculate.Add(12, 23));
            Console.WriteLine(Calculate.Add(12, 23, 25));
        }

        public static void ChangeDateType()
        {
            Console.WriteLine(Calculate.Add(12, 23));
            Console.WriteLine(Calculate.Add(12.4f, 21.3f));
        }
    }
}
