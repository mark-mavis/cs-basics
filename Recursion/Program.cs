
using System.Diagnostics;

using Recursion;

class Program
{
    public static void Main()
    {
        int fibInputValue = 5;

        //RecursionExamples.Run();
        Stopwatch sw;

        sw = Stopwatch.StartNew();
        Console.WriteLine(RecursionExamples.TabulationFibinacci(fibInputValue));
        Console.WriteLine(sw.ElapsedTicks);

        sw = Stopwatch.StartNew();
        Console.WriteLine(RecursionExamples.RunBruteForceFibinacci(fibInputValue));
        Console.WriteLine(sw.ElapsedTicks);

        sw = Stopwatch.StartNew();
        Console.WriteLine(RecursionExamples.RunMemoizationFibinacci(fibInputValue));
        Console.WriteLine(sw.ElapsedTicks);

        //CanSum cs;
        
        //cs = new CanSum(new List<int>() { 5, 3, 4, 7 });
        //Console.WriteLine(cs.RunCanSum(7));

        //cs = new CanSum(new List<int>() { 2, 3});
        //Console.WriteLine(cs.RunCanSum(7));

        //cs = new CanSum(new List<int>() { 2, 4 });
        //Console.WriteLine(cs.RunCanSum(7));

        //cs = new CanSum(new List<int>() { 7, 14 });
        //Console.WriteLine(cs.RunCanSum(300));
        
        
        
        
        
        //GridTraveler.RunProgram();

        //MissionariesCannibals mc = new MissionariesCannibals(3, 3, 0, 0);
        //mc.RunGame();
    }
}