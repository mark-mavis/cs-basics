

namespace Collections
{
    class Array
    {
        public static void SingleDimensionalArray_RunExercise()
        {
            int[] arr = new int[5];
            string[] strarr = new string[2] { "Hello","yes"};
            
            //2D String Matrix
            string[,] Array2D = new string[,] 
            { 
                {"1", "2"}, 
                {"3", "4"} 
            };

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
        }
    }
}
