public partial class BasicsOfStrings{
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