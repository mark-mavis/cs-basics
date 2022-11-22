using System.Collections;   //Non-Generics Library

namespace Collections
{
    //Can store any type of objects
    class NonGenerics
    {
        /*
         * ArrayList
         * SortedList
         * Stack
         * Queue
         * Hashtable
         * BitArray
         */
        
        public static ArrayList arr_list = new ArrayList(); //Depreicated because of boxing. Slow Performance

        public static void AddObjectsToArrayList(params object[] parameters)
        {
            foreach (object o in parameters)
            {
                arr_list.Add(o);
            }
        }
        public static void Sum()
        {
            double sum = 0;
            foreach(object o in arr_list)
            {
                if(o is int) {
                    sum += Convert.ToDouble(o);
                    continue;
                }
                if(o is double) {
                    sum += (double)o;
                    continue;
                }
                if(o is float) {
                    sum += Convert.ToDouble(0);
                    continue;
                }
                if(o is string) continue;
            }
            Console.WriteLine("Sum: " + sum);

        }
    }
}
