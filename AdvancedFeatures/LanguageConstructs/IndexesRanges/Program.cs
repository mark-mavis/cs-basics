namespace IndexesRanges;

partial class Program{
    
    public static string[] words = new string[]{ "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"};
    
    public static void Main(){
        
        // The index operator provides access to array elements
        Console.WriteLine(words[1]);

        // The index-from-end operator (^) indexes from the end of the sequence
        Console.WriteLine(words[^1]);
        Console.WriteLine(words[^3]);

        // The Range operator (..) defines a range
        PrintRange(words[1..3]);    // Index 1 to not inclusive index 3
        PrintRange(words[2..]);     // Index 2 to the end
        PrintRange(words[..5]);     // Start Index to not inclusive index 5
        PrintRange(words[..]);      // Entire range

        // Indexes and ranges can be variables too
        // Index Type
        Index idx = ^4;
        string wordIdx = words[idx];
        Console.WriteLine(wordIdx);
        Console.WriteLine(idx.Equals(^4));
        
        // Range Type
        Range range = 2..4;
        string[] wordRange = words[range];
        PrintRange(wordRange);

    }

    private static void PrintRange(string[] range){
        Console.WriteLine($"Returned String: {string.Join(", ", range)}");
    }
}