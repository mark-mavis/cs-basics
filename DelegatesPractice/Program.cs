using System;



namespace CalculatorApp
{
    public delegate int CalculatorDel(int x, int Y);
    public static class Calculator
    {
        public static int Addition(int x, int y)
        {
            Console.WriteLine($"Adding: {x} + {y}");
            return x + y;
        }

        public static int Subtraction(int x, int y)
        {
            Console.WriteLine($"Subtracting: {x} - {y}");
            return x - y;
        }

        public static int Divide(int x, int y)
        {
            Console.WriteLine($"Dividing: {x} / {y}");
            return x / y;
        }

        public static int Multiply(int x, int y)
        {
            Console.WriteLine($"Multiplying: {x} * {y}");
            return x * y;
        }
    }
    class Program
    {
        public static void Run()
        {           
            CalculatorDel calc = Calculator.Addition;
            
            Console.WriteLine(calc(23, 51));
            calc = Calculator.Subtraction;
            Console.WriteLine(calc(100, 22));
            calc = Calculator.Divide;
            Console.WriteLine(calc(100, 5));
            calc = Calculator.Multiply;
            Console.WriteLine(calc(100, 4));
        }
    }
}
namespace DocumentApp
{
    public delegate void OutputFile(string filename);
    class FileManagement
    {
        public static void OutputToFile(string filePath)
        {
            Console.WriteLine($"Output data to file: {filePath}");
        }
        public static void OutputToConsole(string filePath)
        {
            Console.WriteLine($"Output data to console: {filePath}");
        }
        public static void OutputToDrive(string filePath)
        {
            Console.WriteLine($"Output data to drive: {filePath}");
        }
    }

    class Program
    {
        public static void Run()
        {
            OutputFile fileOutput = new OutputFile(FileManagement.OutputToFile);
            fileOutput("Word Document");
            fileOutput = new OutputFile(FileManagement.OutputToConsole);
            fileOutput("Console Message");
            fileOutput = new OutputFile(FileManagement.OutputToDrive);
            fileOutput("Word Document");

            fileOutput = new OutputFile(FileManagement.OutputToFile);
            fileOutput += new OutputFile(FileManagement.OutputToConsole);
            fileOutput += new OutputFile(FileManagement.OutputToDrive);
            fileOutput("Delegate with 3 functions added");

            Notify(fileOutput);

        }

        public static void Notify(OutputFile output)
        {
            output("Sending all notifications");
        }
    }

}


class Program
{
    public static void Main()
    {
        CalculatorApp.Program.Run();
        DocumentApp.Program.Run();

    }
}











class Object
{
    public int Value { get; set; }
    public string Color { get; set; }

    public Object() {
        Value = 0;
        Color = "Blue";
    }
    public Object(int value, string color)
    {
        Value = value;
        Color = color;
    }
}
class Calculate
{
    public static int Sum(Object obj1, Object obj2)
    {
        return obj1.Value + obj2.Value;
    }

    public static string SumColor(Object obj1, Object obj2)
    {
        return String.Concat(obj1.Color + obj2.Color);
    }
}