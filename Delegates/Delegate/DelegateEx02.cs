namespace Delegate.Delegate.Ex02
{
    internal delegate void Delegate(string text);
    internal class ClassObj
    {
        public class StringFormat
        {
            public void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
            public void ToLowerCase(string text) => Console.WriteLine(text.ToLower());
        }
    }
}
