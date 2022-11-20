


class Mortgage
{
    decimal principleAmount;
    decimal interestRate;
    decimal totalInterest = 0;
    int loanTerm;
    int numberOfPayments;

    public Mortgage(decimal interestRate, decimal principleAmount, int years)
    {
        this.principleAmount = principleAmount;
        this.interestRate = interestRate;
        this.loanTerm = years;
        this.numberOfPayments = years * 12;
    }
    
    public void Estimate(decimal monthlyPayment)
    {
        
        
        for(int i = 0; i < loanTerm; i++)
        {
            for (int j = 0; j < 12 ; j++)
            {
                decimal principleInterest = Math.Round((principleAmount * interestRate) / (decimal)12, 2);
                
                totalInterest += principleInterest;
                decimal principlePaid = monthlyPayment - principleInterest;
                principleAmount -= principlePaid;
                Console.WriteLine($"Principle Paid: {principlePaid} Interest Paid: {principleInterest}");
            }
            Console.WriteLine($"Total Interest Paid: {totalInterest}");
        }
    }
}



class PorfolioManager
{
    List<Property> properties;
    //Add Property
    //Remove Property


}

class Property
{


}


class Program
{
    public static int Main()
    {

        Mortgage m = new Mortgage(.03m, 2000000m, 30);
        m.Estimate(8432.08m);


        return 0;
    }
}