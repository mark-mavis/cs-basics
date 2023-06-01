
using System;

namespace ParseDateTime;

public class ParseInput{
    public DateTime today;
    public void Initialize(){
        
        today = DateTime.Today;

        Console.WriteLine($"Enter a date...");

        DateTime input_date;

        if(DateTime.TryParse(Console.ReadLine(), out input_date)){
            if(input_date == today){
                Console.WriteLine($"is today!");
            }
            TimeSpan ts = input_date > DateTime.Now ? input_date - DateTime.Now : DateTime.Now - input_date;
        }



    }
}