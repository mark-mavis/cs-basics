namespace Delegate.Delegate.Ex01
{
    //Delegate that matches the method signatures in both Class A and Class B
    internal delegate void MyDelegate(string message);
    internal class Delegate
    {
        public class ClassA
        {
            public static void MethodA(string message)
            {
                Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
            }
        }
        public class ClassB
        {
            public static void MethodA(string message)
            {
                Console.WriteLine("Called ClassB.MethodA() with parameter: " + message);
            }
        }
    }
}
