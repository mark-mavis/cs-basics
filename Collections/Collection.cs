
using System.Collections;
using System.Net.Mime;

namespace Collections;
/*
 * Collections are classes that we can use to store a collection of objects
 * Not Limited to one type of object
 * No size contraints, it can grow in size as we add more elements
 * We use them to store, manage, and manipulate groups of objects more efficiently
 */


class CollectionsExerciseController
{
    static CollectionsExerciseController()
    {
        MyArray<int>.SingleDimensionalArray(new int[] {1, 2, 3, 4, 5 });
        MyArray<string>.TwoDimensionalArray(new string[,]{ 
            {"1", "2", "3"}, 
            {"4", "5", "6"}, 
            {"7", "8", "9"}});
        MyArray<int>.ThreeDimensionalArray(new int[,,] { 
            {   {1, 2, 3},  {4, 5, 6}   }, 
            {   {1, 2, 3},  {4, 5, 6}   }, 
            {   {7, 8, 9},  {10,11,12}  }});
        MyArray<string>.ThreeDimensionalArray(new string[,,]{
            {
                {"000", "010", "020" },
                {"100", "110", "120" },
                {"200", "210", "220" }
            },
            {
                {"001", "011", "021" },
                {"101", "111", "121" },
                {"201", "211", "221" }
            },
            {
                {"003", "013", "023" },
                {"103", "113", "123" },
                {"203", "213", "223" }
            }
        });
    }
    public class MyArrayList
    {
        private static ArrayList? objList = new();
        public void AddAllElementsToArrayList(params object[] parameters)
        {
            foreach (object obj in parameters)
            {
                if(objList != null){
                    objList.Add(obj);
                }
                
            }
        }
        public void RemoveElementMatchingValue(object o)
        {
            objList.Remove(0);
        }
        public static void RemoveAtSpecificPosition(int i)
        {
            objList.RemoveAt(i);
        }
        public static void PrintCount()
        {
            Console.WriteLine(objList.Count);
        }
        public static void PrintObjects()
        {
            foreach (object o in objList)
            {
                Console.WriteLine(o);
            }
        }
        public static void SumAllValues()
        {
            double sum = 0;
            foreach (object o in objList)
            {
                if (o is int)
                {
                    sum += Convert.ToDouble(o);
                }
                else if (o is double)
                {
                    sum += (double)o;
                }
                else if (o is string)
                {
                    continue;
                }
            }
            Console.WriteLine($"Sum is: {sum}");
        }
    }

    public class MyArray<T1>
    {
   /*
    * Stores a fixed size of sequential collection of elements
    * ONLY of the SAME TYPE Stores all kinds of types: int, string, object, etc.
    * Great to store a collection of data - easier to thing of a collection of
    * variables of the same type stored at contiguous memory locations.
    */
        public static void SingleDimensionalArray(T1[] arr)
        {
            foreach(T1 t in arr)
            {
                Console.Write(t);
            }
            Console.WriteLine("\n");
        }
        public static void TwoDimensionalArray(T1[,] arr)
        {
            for(int i_idx = 0; i_idx < arr.GetLength(0); i_idx++)
            {
                for(int j_idx = 0; j_idx < arr.GetLength(1); j_idx++)
                {
                    Console.Write(arr.GetValue(i_idx, j_idx) + " ");
                }
                Console.WriteLine("\n");
            }
            
        }
        public static void ThreeDimensionalArray(T1[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr.GetValue(i, j, k) + " ");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }
        }
        public static void ForeachLoopsSwitchChallenge()
        {
            Console.WriteLine("Enter a value => ");
            string input = Console.ReadLine();
            string cleanedinput = input.Replace(" ", "");


            Console.WriteLine("Select the Data Type to validate the input you have entered => ");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            string choice = Console.ReadLine();

            int choice_int;
            int.TryParse(choice, out choice_int);

            Console.WriteLine($"You have entered a value: {input}");


            switch (choice_int)
            {
                case 1:
                    if (isAllAlphabetic(cleanedinput)) Console.WriteLine("It is a valid: String");
                    else Console.WriteLine("It is an invalid: String");
                    break;
                case 2:

                    int temp_int;
                    if (int.TryParse(cleanedinput, out temp_int))
                    {
                        Console.WriteLine("It is a valid: Integer");
                    }
                    else
                    {
                        Console.WriteLine("It is an invalid: Integer");
                    }
                    break;
                case 3:
                    bool temp_bool;
                    if (bool.TryParse(cleanedinput, out temp_bool))
                    {
                        Console.WriteLine("It is a valid: Boolean");
                    }
                    else
                    {
                        Console.WriteLine("It is an invalid: Boolean");
                    }
                    break;
            }

        }
        static bool isAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetter(c)) return false;
            }
            return true;
        }
    }

    public class MyDictionary
    {
        private static int EmployeeNum { get; set; } = 0;

        public static Dictionary<int, Employee> _employeeDirectory = new Dictionary<int, Employee>();
        public MyDictionary()
        {
            PopulateDirectory();
        }
        public void PopulateDirectory()
        {
            if(EmployeeDatabase.employeeDatabase != null && _employeeDirectory != null)
            {
                foreach (Employee e in EmployeeDatabase.employeeDatabase)
                {
                    Console.WriteLine($"Adding: {e.Name} to Employee Directory");
                    _employeeDirectory.Add(++EmployeeNum, new Employee(e.Name, e.Role, e.Age, e.Rate));
                }
            }  
        }
        public void Print()
        {
            foreach(KeyValuePair<int, Employee> record in _employeeDirectory)
            {
                Console.WriteLine($"Employee Name: {record.Value.Name} Role: {record.Value.Role} Rate: {record.Value.Rate}");
            }
        }
    }
}

