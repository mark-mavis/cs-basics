using System;
using ParseDateTime;

namespace WorkingWithDateTime;

class Program{
    public static void Main(){


        ParseInput obj = new ParseInput();
        obj.Initialize();

        DateTime now = DateTime.Now;
        Console.WriteLine($"It is currently: {now}");
        
        DateTime today = DateTime.Today;
        Console.WriteLine($"Today is: {DateTime.Today.ToShortDateString()} at {DateTime.Now.ToShortTimeString()}");
        Console.WriteLine($"The day of the week is {today.DayOfWeek}");
        Console.WriteLine($"{today.DayOfYear} day of the year");
        
        Console.WriteLine($"{today.Day} day of the {today.Month} month");

        DateOnly d_only = DateOnly.FromDateTime(DateTime.Now);
        Console.WriteLine(d_only.ToShortDateString());
        
        TimeOnly t_only = TimeOnly.FromDateTime(DateTime.Now);
        Console.WriteLine(t_only.ToShortTimeString());

        DateTime newyears = new DateTime(DateTime.Now.Year, 1, 1);
        DateTime aprilfools = new DateTime(DateTime.Now.Year, 4, 1);
        
        TimeSpan ts = aprilfools - newyears;

        Console.WriteLine(ts.TotalDays);


        DateAndTimeFormatting.Run();
        
    }
}