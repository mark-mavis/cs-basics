

class Program{
    public static void Main(string[] args){

        /*
            $"{var1[alignment]:[format][precision]}"

            FORMAT CODES
            N - Number
            D - Decimal
            G - General
            P - Percent
            F - Fixed-Point
            X - Hexadecimal
            E - Exponential
            C - Currency
        */

        int[] Quarter = { 1, 2, 3, 4};
        int[] sales = {100000, 150000, 200000, 225000};
        double[] intlMixPct = {.386, .413, .421, .457};
        int val1 = 1234;
        decimal val2 = 1234.3525M;

        // TODO: Specifiy Numberical Formatting
        // general format is {indexl}
        Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G}");
        Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G}");

        //Setting Precision
        Console.WriteLine($"{val1:D6}, {val1:N2}, {val1:F1}, {val1:G3}");
        
        for(int i = 0; i < Quarter.Count(); i++){
            Console.WriteLine($"{"Quarter: " + Quarter[i]} Sales: {sales[i], 12:C2}");
        }

        for(int i = 0; i < intlMixPct.Count(); i++){
            System.Console.WriteLine($"{"Percentage: " + intlMixPct[i], -20:P0}");
        }
           
        

        


        /*
        System.Console.WriteLine("Idx 0: {0} Idx 1: {1} ", var1, var2);
        System.Console.WriteLine($"{var1}, {var2}");

        //Spacing and Alignment: INDEXES
        System.Console.WriteLine("{0, -15} {1, 10}", "Float Val", "Int Val");
        System.Console.WriteLine("{0, -15} {1, 10}", f1, i1);

        //Spacing and Alignment: INTERPOLATION
        System.Console.WriteLine($"{"Float", -15} {"Int Val", 10}");
        System.Console.WriteLine($"{f1, -15} {i1, 10}");

        */
    }
}