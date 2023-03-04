namespace Delegate.Generic.MultiTypeDelegate
{ 
    //---------MULTIPLE TYPE DELEGATE
    //public delegate TResult TwoInputDelegate<in T1, in T2, out TResult>(int param1, int param2, bool answer);
    public delegate T2 MyCustomDelegate<in T1, out T2>(T1 param1, T1 param2);
    public delegate T4 MyCustomDelegate2<in T1, in T2, in T3, out T4>(T1 param1, T2 param2, T3 param3);

    internal class ClassObj
    {
        public static bool CompareInt(int param1, int param2)
        {
            //Returns true if param1 is larger than param2
            return param1 > param2;
        }
        public static bool CompareString(string param1, string param2)
        {
            //Returns Zero is strings are equal
            return String.Compare(param2 + param1, param1) == 0;
        }
        public static decimal AddMultiType(int param1, double param2, float param3)
        {
            return (decimal)param1 + (decimal)param2 + (decimal)param3;
        }
    }
}
