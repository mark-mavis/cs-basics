
using System;
namespace Indexers;

public class StockRecord{
    public static decimal[] prices = new decimal[]{
        105.1m, 103.12m, 106.93m, 104.5m, 103.7m
    };

    public decimal Average{
        get => prices.Sum()/prices.Length;
    }
    public decimal High{
        get => prices.Max();
    }
    public decimal Low{
        get => prices.Min();
    }

    public int Length{
        get => prices.Length;
    }

    // This indexer method enables types to use indexing
    public decimal this[int index]{
        get => prices[index];
    }

    // Overloading the indexer
    public decimal this[string day]{
        get{
            if(day == "mon"){
                return prices[0];
            }
            if(day == "tue"){
                return prices[1];
            }
            if(day == "wed"){
                return prices[2];
            }
            if(day == "thu"){
                return prices[3];
            }
            if(day == "fri"){
                return prices[4];
            }
            return 0.0m;
        }
    }
}


class Program{
    public static void Main(){
        StockRecord record = new StockRecord();
        Console.WriteLine($"Average: {record.Average}");
        Console.WriteLine($"High: {record.High}");
        Console.WriteLine($"Low: {record.Low}");


        for(int i = 0; i < record.Length; i++){
            Console.WriteLine($"Record {i}: {record[i]:C}");
        }

        Console.WriteLine($"Monday: {record["mon"]:C}");
        Console.WriteLine($"Wednesday: {record["wed"]:C}");
    }
}