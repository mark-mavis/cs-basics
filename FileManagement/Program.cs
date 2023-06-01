
using System;


namespace WorkingWithFiles{
    class Program{
        const string filename = "TestFile.txt";
        public static void Main(){
            File.CreateTest();
            using(StreamWriter sw = File.CreateTest(filename)){
                sw.WriteLine("This is a test file");
            }


        }
    }
}


