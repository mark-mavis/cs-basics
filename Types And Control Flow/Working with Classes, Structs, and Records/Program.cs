using System;
namespace _01_Classes_Structs_Records;

class Program
{
    public static void Classes_Structs_Records()
    {
        Employee employee01 = new Employee("Chase", "Jones", 10924, new Age { BirthDate = new DateTime(1983, 8, 19), YearsOld = 40 }, new DateOnly(2021, 07, 19)) { };
        Employee employee02 = new Employee("Chase", "Jones", 10924, new Age { BirthDate = new DateTime(1983, 8, 19), YearsOld = 40 }, new DateOnly(2021, 07, 19)) { };

        Console.WriteLine(employee01 == employee02);
        Console.WriteLine(employee01.ToString());
        Console.WriteLine(employee02.ToString());


        Employee employee03 = new Employee("Chase", "Stevens", 10924, new Age { BirthDate = new DateTime(1983, 8, 19), YearsOld = 40 }, new DateOnly(2021, 07, 19)) { };

        Console.WriteLine(employee01 == employee03);
        Console.WriteLine(employee01.ToString());
        Console.WriteLine(employee03.ToString());


        Employee manager01 = new Manager("Mark", "Mavis", 52523, new Age { BirthDate = new DateTime(1984, 2, 5), YearsOld = 39 }, new DateOnly(2020, 2, 10)) { };
        Employee manager02 = new Manager("Mark", "Mavis", 52523, new Age { BirthDate = new DateTime(1984, 2, 5), YearsOld = 39 }, new DateOnly(2020, 2, 10)) { };
        Console.WriteLine(manager01 == manager02);
        Console.WriteLine(manager01.ToString());
        Console.WriteLine(manager02.ToString());

        Employee manager03 = new Manager("Mark", "Davis", 52523, new Age { BirthDate = new DateTime(1984, 2, 5), YearsOld = 39 }, new DateOnly(2020, 2, 10)) { };
        Console.WriteLine(manager01 == manager03);
        Console.WriteLine(manager01.ToString());
        Console.WriteLine(manager03.ToString());

        Manager manager04 = new Manager("Burt", "Renolds", 34252, new Age { BirthDate = new DateTime(1954, 6, 23), YearsOld = 69 }, new DateOnly(2011, 4, 2));
        manager04.SetReports(10);
        Console.WriteLine(manager04.ToString());
    }

    public static void Main()
    {
        Classes_Structs_Records();

    }


}