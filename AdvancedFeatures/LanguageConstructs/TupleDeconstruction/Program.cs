using System;

namespace TupleDeconstruction;

class Program{

    public static void Main(){
        (decimal, decimal, decimal) t1 = GetStockPrices("Msft");
        Console.WriteLine($"Day High: {t1.Item1} Day Low: {t1.Item2} Day End: {t1.Item3}");

        // To avoid tuples Item1, Item2 etc
        var (high, low, end) = GetStockPrices("Amzn");
        Console.WriteLine($"Day High: {high} Day Low: {low} Day End: {end}");

        // Can also use explicit variable types, and the _ character can be used to ignore any values that you don't plan to use
        decimal endingprice;
        (_, _, endingprice) = GetStockPrices("Gogl");
        Console.WriteLine($"Low of the day is {endingprice}");


    }


    private static (decimal, decimal, decimal) GetStockPrices(string stock){
        if(stock == "Msft") return (22.0m, 19.0m, 20.5m);
        else if(stock == "Amzn") return (50.0m, 47.0m, 49.0m);
        else return (0.0m, 0.0m, 0.0m);
    }
}