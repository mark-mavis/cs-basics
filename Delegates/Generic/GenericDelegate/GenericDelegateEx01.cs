namespace Delegate.Generic.GenericDelegate
{
    // Generic Delegate that works with many functions of the same signature
    public delegate T GenericDelegate<T>(T param1, T param2);
    internal class ClassObj
    {
        public static int Sum(int param1, int param2)
        {
            return param1 + param2;
        }
        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
