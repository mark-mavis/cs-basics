
using System;

namespace ParseDateTime;

public class ParseInput{
    public DateTime today;
    private string CalculateDays(DateTime dt1, DateTime dt2){
        if(dt1 > dt2) return $"Happens in {(dt1-dt2).Days} days";
        else if (dt2 > dt1) return $"Happened {(dt2-dt1).Days} days ago";
        else return $"That is today!";
    }
    public void Initialize(){
        
        today = DateTime.Today;
        DateTime dt;
        string? str_dt;

        do{
            Console.WriteLine($"Enter a date... (or 'exit')");
            str_dt = Console.ReadLine();
            if(str_dt.ToLower() == "exit"){
                break;
            }

            if(DateTime.TryParse(str_dt, out dt)){
                Console.WriteLine(CalculateDays(dt, today));
            }else{
                Console.WriteLine("That doesn't seem to be a valid date");
            }
        }while(str_dt != "exit");
    }
}