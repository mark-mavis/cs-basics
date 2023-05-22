using System;

namespace Interface_Injection
{
    interface IPaymentCalculator
    {
        public decimal GetMonthlyPayment(decimal Price, decimal Deposit, int Years);
    }
    class PaymentCalculator : IPaymentCalculator
    {
        public decimal GetMonthlyPayment(decimal Price, decimal Deposit, int Years)
        {
            return (Price - Deposit) / (Years * 12);
        }
    }

    interface IPaymentCalculatorInjector
    {
        void CalculatorInjector(IPaymentCalculator calculator);
    }

    class PaymentTerms : IPaymentCalculatorInjector
    {
        public decimal Price { get; set; }
        public decimal Deposit { get; set; }
        public int Years { get; set; }

        IPaymentCalculator? _calculator;
        public void CalculatorInjector(IPaymentCalculator calculator)
        {
            _calculator = calculator;
        }
        public decimal GetMonthlyPayment()
        {
            if (_calculator != null)
            {
                return _calculator.GetMonthlyPayment(Price, Deposit, Years);
            }
            return 0;
        }


    }
    class Program
    {
        public static void run()
        {
            PaymentTerms pt = new();
            pt.CalculatorInjector(new PaymentCalculator());
            pt.Price = 900000;
            pt.Deposit = 180000;
            pt.Years = 30;
            Console.WriteLine(pt.GetMonthlyPayment());
        }
    }
}
