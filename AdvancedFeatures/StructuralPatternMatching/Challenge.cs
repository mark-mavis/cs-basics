
namespace Patterns;

public class SecuritiesTrade{
    public int Quantity;
    public decimal Price;
}

public class StockTrade : SecuritiesTrade{
    public string? Symbol;
}

public class BondTrade : SecuritiesTrade{
    public string? Name;
    public int Duration;
}


public class CommissionCalculator{

    public static SecuritiesTrade[] Trades = new SecuritiesTrade[]{
        new StockTrade(){Symbol="ABCD", Quantity=1200, Price=27.81m},
        new StockTrade(){Symbol="WXYZ", Quantity=1000, Price=7.92m},
        new StockTrade(){Symbol="ABCD", Quantity=200, Price=27.81m},
        new StockTrade(){Symbol="WXYZ", Quantity=400, Price=7.92m},
        new BondTrade(){Name="Abcd 5yr", Duration=5, Price=100.0m, Quantity=10},
        new BondTrade(){Name="Qwert 10yr", Duration=10, Price=100.0m, Quantity=10},
        new BondTrade(){Name="Abcd 20yr", Duration=20, Price=100.0m, Quantity=100},
        new BondTrade(){Name="Qwert 20yr", Duration=20, Price=50.0m, Quantity=10},
        new BondTrade(){Name="Qwert 50yr", Duration=50, Price=50.0m, Quantity=10},
        new StockTrade(){Symbol="WXYZ", Quantity=0, Price=9.55m},
    };

    public static decimal CalculateTradeCommission(SecuritiesTrade trade) => trade switch {
        StockTrade {Quantity: int q} when q == 0 => throw new ArgumentException("Invalid Trade"),
        
        StockTrade {Quantity: int q, Price: decimal p} when q >= 1000 && (q*p) >= 10_000.0M => 5.00m,
        StockTrade {Quantity: int q} when q >= 1000 => 10.00M,

        StockTrade {Quantity: int q, Price: decimal p} when (q*p) >= 5000 => (q*p)*0.05M,
        StockTrade {Quantity: int q, Price: decimal p} when (q*p) < 5000 => (q*p)*0.01M,

        BondTrade {Price: decimal p, Quantity: int q} when (p*q) >= 5000 && (p*q) < 10_000.0M => 5.00M,
        
        BondTrade {Duration: int d, Quantity: int q, Price: decimal p} when d == 5 && (p*q) >=10_000.0M => 15.0M,
        BondTrade {Duration: int d} when d == 5 => 20.00M,
        
        BondTrade {Duration: int d} when d == 10 => 12.00M, 
        
        BondTrade {Duration: int d, Quantity: int q, Price: decimal p} when d == 20 && (p*q) >= 5_000.0M => 5.0M,
        BondTrade {Duration: int d} when d == 20 => 10.0M,
       
        BondTrade => throw new ArgumentException("Invalid Trade"),
        _ => throw new ArgumentException("Invalid Trade")
    };
    
    public static void PrintTradeCommission(){
        foreach(SecuritiesTrade st in Trades){
            Console.WriteLine(CalculateTradeCommission(st));
        }
    }
}
