namespace Duplicates
{
    public class Easy_RemoveDuplicates
    {
        public static int RemoveDuplicatesFromSortedArray(int[] arr)
        {

            if(arr.Length == 0 || arr.Length == 1) return 1;
            
            for(int j = 1; j <= arr.Length; j++)
            {
                if(arr[j-1] == arr[j]) {
                    arr[j-1] = arr[j];

                }
            }
            return 1;
        }
    }
    public class TestRemoveDuplicates
    {
        public static void Run()
        {
            int[] arry = { 1, 2, 4, 4, 6, 7, 7, 8};
            Easy_RemoveDuplicates.RemoveDuplicatesFromSortedArray(arry);

        }
    }

}
