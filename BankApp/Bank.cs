namespace BankingApp;

public class Bank{
    private Dictionary<Client, CheckingAccount> checkingAccounts;
    private Dictionary<Client, SavingsAccount> savingAccounts;
    public string Title{get; set;}

    public Bank(string title){
        Title = title;
        checkingAccounts = new Dictionary<Client, CheckingAccount>();
        savingAccounts = new Dictionary<Client, SavingsAccount>();
    }
}