namespace Delegate.Ex02
{
    internal class Delegate
    {
        public delegate void MyDelegate(string text);
        public class StringFormat
        {
            public void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
            public void ToLowerCase(string text) => Console.WriteLine(text.ToLower());
        }
    }
}
