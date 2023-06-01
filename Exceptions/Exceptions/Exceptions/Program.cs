using System;

namespace Exceptions;

public class Program{

    public static void Main(string[] args){
        string[] NumStrs = { " 1 ", " 1.45 ", "-100", "5e+04"};

        int testint;
        float testfloat;
        bool result;

        foreach(string str in NumStrs){
            try{
                testfloat = float.Parse(str);
                Console.WriteLine($"Parse number is {testfloat}");
                testint = int.Parse(str);
                Console.WriteLine($"Parsed number is {testint}");
            }catch(FormatException e){
                Console.WriteLine($"Could not parse '{str}'... {e.Message}");
            }
        }

        result = int.TryParse(NumStrs[0], out testint);
        System.Console.WriteLine($"{result} -- '{NumStrs[0]}' : {testint}");

        result = float.TryParse(NumStrs[1], out testfloat);
        System.Console.WriteLine($"{result} -- '{NumStrs[1]}' : {testfloat}");

        result = int.TryParse(NumStrs[2], out testint);
        System.Console.WriteLine($"{result} -- '{NumStrs[2]}' : {testint}");

        result = float.TryParse(NumStrs[3], out testfloat);
        System.Console.WriteLine($"{result} -- '{NumStrs[3]}' : {testfloat}");

    }
}