using System;
namespace WorkingWithDateTime;

public class DateAndTimeFormatting{
    public static void Run(){
        DateTime aprilFools = new DateTime(DateTime.Now.Year, 4, 1, 13, 23, 30);

        // 'd' Short Date: mm/dd/yyyy (or dd/mm depending on locale)
        Console.WriteLine($"{aprilFools:d} - 'd' - Short Date");
        // 'D' Full Date: mm/dd/yyyy (or dd/mm depending on locale)
        Console.WriteLine($"{aprilFools:D} - 'D' - Long Date");

        // 'f' Full Date, short time
        Console.WriteLine($"{aprilFools:f} - 'f' - Full Date-Short Time");
        // 'F' Full Date, long time
        Console.WriteLine($"{aprilFools:F} - 'F' - Full Date-Long Time");

        // 'g' General Date and Time
        Console.WriteLine($"{aprilFools:g} - 'g' - General Date-Short Time");
        // 'G' General Date and Time
        Console.WriteLine($"{aprilFools:G} - 'G' - General Date-Long Time");
        
    }
}