namespace Collections
{
    class JaggedArray
    {
        //Null-Conditional operators ?.
        public static int[][]? _jaggedArray;

        public JaggedArray(int[][] arr)
        {
            _jaggedArray = arr;
        }

        public static void PrintOutJaggedArray(int[][] arr)
        {
            for(int i = 0; i < _jaggedArray.GetLength(0); i++)
            {
                for(int j = 0; j < _jaggedArray.GetLength(1); j++)
                {
                    Console.WriteLine(_jaggedArray[i][j]);
                }
            }
        }  
    }

    class JaggedManager
    {
        public static void Run()
        {
           
        }
    }


}
