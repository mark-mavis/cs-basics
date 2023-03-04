namespace Delegate.Generic.FunctionDelegate
{
    /*
    * ---------------LIBRARY PROVIDED GENERIC TYPE FUNC--------------
    *  C# includes built-in generic delegate types FUNC and ACTION, so that you don't need to define
    *  custom delegates manually in most cases.
    *  
    *  FUNC is a generic delegate included in the System namespace. It has zero or more input parameters
    *  and one out parameter. The last parameter is considered as an on parameter.
    *
    *  public delegate TResults Func<in T, out TResult>(T arg);
    */
    public delegate T func_del<T>(T param1, T param2);
    class ClassObj
    {
        public static string TargetMethodAddString(string param1, string param2)
        {
            return param1 + param2;
        }
        public static int TargetMethodAddInt(int param1, int param2)
        {
            return param1 + param2;
        }
        public static int TargetMethodMultiplyInt(int param1, int param2)
        {
            return param1 * param2;
        }
    }
}
