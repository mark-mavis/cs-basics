

namespace Collections
{
    /*
     * Stores a fixed size of sequential collection of elements
     * 
     * ONLY of the SAME TYPE
     * 
     * Stores all kinds of types: int, string, object, etc.
     * 
     * Great to store a collection of data - easier to thing of a collection of
     * variables of the same type stored at contiguous memory locations.
     *
     */

    class MyArray
    {
        public static void SingleDimensionalArray_RunExercise()
        {
            int[] arr = new int[5];
            string[] strarr = new string[2] { "Hello","yes"};
        }
        public static void TwoDimensionalArray()
        {
            //2D String Matrix
            string[,] Array2D = new string[,]
            {
                {"1", "2"},
                {"3", "4"}
            };

            
        }
        public static void ThreeDimensionalArray()
        {
            //3D String 
            string[,,] Array3D = new string[,,]
            {
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
            };

            for(int i = 0; i < Array3D.GetLength(0); i++)
            {
                for(int j = 0; j < Array3D.GetLength(1); j++)
                {
                    for(int k = 0; k < Array3D.GetLength(2); k++)
                    {
                        Console.Write(Array3D[i,j,k] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void FiveFriendsExercise()
        {
            string[] friends = new string[] {"Robby", "Chase", "Steele", "Adam", "John"};
            
            foreach(string friend in friends)
            {
                Console.WriteLine(friend);
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
                    if(isAllAlphabetic(cleanedinput)) Console.WriteLine("It is a valid: String");
                    else Console.WriteLine("It is an invalid: String");
                    break;
                case 2:
                    
                    int temp_int;
                    if(int.TryParse(cleanedinput, out temp_int))
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
                    if(bool.TryParse(cleanedinput, out temp_bool))
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
            foreach(char c in value)
            {
                if(!Char.IsLetter(c)) return false;
            }
            return true;
        }
        public static void RunTickTackToe()
        {

            int[,] tickTackToeBoard = { 
                { 0, 0, 0}, 
                { 0, 0, 0}, 
                { 0, 0, 0} 
            };
        }

        //Start Tic Tac Toe Game
        // While true  - Running Game
        //  if(any tic tac toes) - return true
        //  else(proceed with game)
        //  
        //
            
    }

}
