using System.Diagnostics;

namespace Performance.Benchmark{
    class Program{
        public static void Main(string[] args){

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for(int i = 0; i < 100000; i++){
                Console.WriteLine($"{i}");
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }





}