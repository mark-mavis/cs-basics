using System;
namespace RecordsClass;

public record DayTemperature(decimal High, decimal Low){
    public decimal Average{
        get => (High+Low)/2;
    }
}


class Program{
    public static void Main(){

        DayTemperature temp1 = new DayTemperature(92.5m, 65.4m);
        DayTemperature temp2 = new DayTemperature(89.5m, 61.4m);
        DayTemperature temp3 = new DayTemperature(92.5m, 65.4m);

        Console.WriteLine(temp1);
        Console.WriteLine(temp1 == temp2);
        Console.WriteLine(temp1 == temp3);

        Console.WriteLine($"Average {temp1.Average}");

        DayTemperature temp4 = temp1 with {High = 78.9m};
        Console.WriteLine(temp4);
    }
}