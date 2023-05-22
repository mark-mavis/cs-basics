using System;
using DocumentApp;
using CalculatorApp;
using SearchingApp;


class Program
{
    public static void Main()
    {
        FileManagement.OutputData("This is the data entered in the system");  
        Calculator.Run();
        DelegateSearch.Run();

    }
}