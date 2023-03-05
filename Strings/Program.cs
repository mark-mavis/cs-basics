
using System.Net.Security;

class StringsExerciseController
{
    static StringsExerciseController()
    {
        BasicsOfStrings.StringInterpolation();
        BasicsOfStrings.StringManipulationFunctions();
        BasicsOfStrings.StringSearchFunctions();
    }


    public class BasicsOfStrings
    {
        public static string? _string = "Default string";
        public static void StringInterpolation()
        {
            Console.WriteLine($"Example of string interpolation {_string}\n");
        }

        public static void StringManipulationFunctions()
        {
            string greetings = "                   Hello world!              ";
            Console.WriteLine($"Length: {greetings.Length} String: [{greetings}] - Original String");

            string trimmedGreeting = greetings.TrimEnd();   //Removes trailing white space
            Console.WriteLine($"Length: {trimmedGreeting.Length} String: [{trimmedGreeting}] - TrimEnd()");
           
            trimmedGreeting = greetings.TrimStart();        //Removes leading white space
            Console.WriteLine($"Length: {trimmedGreeting.Length} String: [{trimmedGreeting}] - TrimStart()");

            trimmedGreeting = greetings.Trim();  //Removes leading and trailing white space
            Console.WriteLine($"Length: {trimmedGreeting.Length} String: [{trimmedGreeting}] - Trim()");

            string replacedGreeting = greetings.Replace("Hello", "Goodbye");
            Console.WriteLine($"Length: {trimmedGreeting.Length} String: [{replacedGreeting}] - Replace(Hello, Goodbye)");

            Console.WriteLine(replacedGreeting.ToUpper());
            Console.WriteLine(replacedGreeting.ToLower());
        }

        public static void StringSearchFunctions()
        {
            string sentence = "You say goodbye, and I say hello";
            bool answer = sentence.Contains("goodbye");

            if(sentence.Contains("goodbye") && sentence.Contains("hello"))
            {
               sentence = sentence.Replace("goodbye", "hello");
               sentence = sentence.Replace("hello", "goodbye");
            }

            Console.WriteLine($"Replaced Sentence: {sentence}");

        }
    }
}




class Program
{
    public static void Main()
    {
       new StringsExerciseController();
    }
}