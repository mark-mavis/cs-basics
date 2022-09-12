namespace Validation
{
    public class ParenthesisValidater
    {
        public static bool Run(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count != 0 && ((c == ')' && stack.Peek() == '(') ||
                                        (c == ']' && stack.Peek() == '[') ||
                                        (c == '}' && stack.Peek() == '{')))
                    {
                        stack.Pop();
                    }
                    else return false;
                }
            }

            if (stack.Count == 0) return true;
            return false;
        }
    }
    public class TestParenthesisValidator
    {
        public static void Run()
        {
            Console.WriteLine(ParenthesisValidater.Run("(())"));
            Console.WriteLine(ParenthesisValidater.Run("(){}[]"));
            Console.WriteLine(ParenthesisValidater.Run("(]"));
            Console.WriteLine(ParenthesisValidater.Run("]"));
        }
    }
}
