using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        Bank bank = new Bank();
        bank.AddClient("Mark Mavis");
        bank.AddClient("Chase Jones");
        bank.AddClient("Robby Nelson");





    }
}

class Bank
{
    public static int _customerCount = 0;

    Dictionary<int, Client> ClientList;

    public Bank()
    {
        
        
    }
    public void AddClient(string name)
    {
        ClientList.Add(++_customerCount, new Client(name));
    }
}


class Client
{
    private static int _id = 0;
    public string Name { get; set; }
    public int UserId { get; set; }
    public Client()
    {
        _id++;
        Name = "Unknown";
        UserId = _id;
    }
    public Client(string name)
    {
        _id++;
        Name = name;
        UserId = _id;
    }
}

class Account : Bank
{
    public string AccountNum { get; set; }
    public 

}

class CheckingAccount : Account
{

}

class SavingsAccount : Account
{

}