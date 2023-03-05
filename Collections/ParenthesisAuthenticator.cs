using System;
namespace Collections;
class Authenticator
{
    public static void Parentheses(string parens)
    {
        Dictionary<char, char> keyValuePairs = new Dictionary<char, char>() { { '(', ')' }, { '{', '}' }, { '[', ']' } };

        Stack<char> stack = new Stack<char>();

        if (parens.Length > 0)
        {
            foreach (char c in parens)
            {
                if (keyValuePairs.ContainsKey(c)) stack.Push(c);
                else if (c == keyValuePairs[stack.Peek()]) stack.Pop();
            }
            if (stack.Count == 0) Console.WriteLine("It is a valid parenthises string");
            else Console.WriteLine("Invalid string");
        }
    }
}

