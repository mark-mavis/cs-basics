namespace Delegate.Generic.ActionDelegate
{
    /*
     * C# - Action Delegate
     * Action is a delegate type defined in the System namespace. An Action type 
     * delegate is the same as Func delegate except that the Action delegate doesn't 
     * return a value. In other words, an Action delegate can be used with a method 
     * that has a void return type.
     * 
     * For example, the following delegate prints an int value.
     */

    public delegate void PrintActionDelegate(int message);
    internal class ClassObj
    {
        public static void ConsolePrint(int message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}
