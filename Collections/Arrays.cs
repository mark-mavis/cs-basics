

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
    }
}
