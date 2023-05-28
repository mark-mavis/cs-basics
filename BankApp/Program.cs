namespace BankingApp;

class Program
{
    public static void Main()
    {

        Bank bank = new Bank("Bank of America");
        bank.CreateNewClient();
        bank.InitializeDirectory();
        bank.CreateNewClient();
        

        



    }
}



