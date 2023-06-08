using System;
namespace Patterns;

public class DiscountGenerator{

    public static (int, DateTime)[] PurchaseDates = new (int, DateTime)[]{
        (4, new DateTime(2022, 9, 3)),
        (7, new DateTime(2023, 2, 6)),
        (20, new DateTime(2023, 4, 17)),
        (15, new DateTime(2023, 8, 8)),
        (9, new DateTime(2023, 8, 9))
    };

    public static decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate) => (groupSize, visitDate.DayOfWeek) switch {
        (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0M,
        (>=5 and < 10, DayOfWeek.Monday) => 0.20M,
        (>=10, DayOfWeek.Monday) => 0.30M,
        (>=5 and < 10, _) => 0.12M,
        (>= 10, _) => 0.15M,
        (<=0, _) => throw new ArgumentException("Group size must be positive number"),
        _ => 0.0m
    };

    public static void TestPurchaseData(){
        foreach((int size, DateTime dt) in PurchaseDates){
            Console.WriteLine($"Discount: {GetGroupTicketPriceDiscount(size, dt)}");
        }
    }
}