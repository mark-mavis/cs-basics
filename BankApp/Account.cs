
public enum AccountType{ Checking = 0, Savings = 1 }

namespace BankingApp{

    public class Account{
        protected Client? AccountHolder = null;
        protected AccountType AccountType {get; set;}
        protected decimal Balance{get; set;}
        public void Deposit(decimal amount)
        {
            if(amount > 0){
                Balance += amount;
                Console.WriteLine($"{amount} deposited.");
                Console.WriteLine($"new balance: {Balance}");
            }else{
                throw new NotImplementedException();
            }
        }
        public void Withdrawl(decimal amount)
        {
            if(Balance - amount >= 0){
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn.");
                Console.WriteLine($"new balance: {Balance}");
            }else{
                throw new NotImplementedException();
            }   
        }

    
    }
    public class CheckingAccount : Account {

        public CheckingAccount(decimal initialDeposit){
            AccountType = AccountType.Checking;
            Deposit(initialDeposit);
        }
    }

    public class SavingsAccount : Account {
        public SavingsAccount(decimal initialDeposit){
            AccountType = AccountType.Savings;
            Deposit(initialDeposit);
        }
    }
}