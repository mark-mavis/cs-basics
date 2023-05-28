namespace BankingApp;

public sealed class Bank{
    public string Title{get; set;}
    public int ClientCount {get; set;} = 0;
    private ClientDirectory? Directory {get; set;} = null;
    public Bank(string title){
        Title = title;
    }
    public void InitializeDirectory(){
        if(Directory == null){
            Directory = new ClientDirectory();
        }else{
            Console.WriteLine("Directory already exists");
        }
    }

    public void CreateNewClient(){
        if(Directory != null){
            bool IsRunning = true;
            while(IsRunning){
                Console.WriteLine("Enter Client Name...");
                string? name = Console.ReadLine();
                if(name != null){
                    Directory.AddClient( new Client(name));
                    IsRunning = false;
                }else{
                    Console.WriteLine("You didn't enter anything");
                }
            }
        }else{
            Console.WriteLine("Directory Does not exist. Try Initializing one");
        }
                
    }



    /*
    public void CreateAccount(AccountType type, decimal deposit){
        Account accountTemp;
        switch(type){
            case AccountType.Checking:
                accountTemp = new CheckingAccount(deposit);
                break;
            case AccountType.Savings:
                accountTemp = new SavingsAccount(deposit);
                break;
            
        }
    }*/


}