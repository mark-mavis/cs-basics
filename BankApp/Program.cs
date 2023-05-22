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



namespace Account
{

    public enum AccountType { Checking, Savings };

    
    interface IDepositType
    {
        AccountType Type { get; set; }
    }
    interface IDeposit
    {
        void Deposit();
    }
    
    class Account
    {
        protected string? _accountNumber;
        protected AccountType? _accountType;
        public string AccountNumber { 
            get{ 
                if(_accountNumber != null) return _accountNumber;
                else return "unknown";
            }
            set{ _accountNumber = value; } 
        }
        public AccountType AccountType { 
            get { return _accountType.Value; } 
            set { _accountType = value; }
        }

        public Account(string accNum, AccountType accType)
        {
            AccountNumber = accNum;
            AccountType = accType;
        }
    }
}



