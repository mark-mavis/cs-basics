

public partial class BasicsOfStrings{

    public static void StringFormatting(){

        int var1 = 46;
        string var2 = "How Are You";

        int i1 = 2000;
        float f1 = 123.53f;
        //decimal d1 = 53.242M;
        

        System.Console.WriteLine("Idx 0: {0} Idx 1: {1} ", var1, var2);
        System.Console.WriteLine($"{var1}, {var2}");

        //Spacing and Alignment: INDEXES
        System.Console.WriteLine("{0, -15} {1, 10}", "Float Val", "Int Val");
        System.Console.WriteLine("{0, -15} {1, 10}", f1, i1);

        //Spacing and Alignment: INTERPOLATION
        System.Console.WriteLine($"{"Float", -15} {"Int Val", 10}");
        System.Console.WriteLine($"{f1, -15} {i1, 10}");
    }
}