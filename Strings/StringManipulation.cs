

public partial class BasicsOfStrings{

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
}