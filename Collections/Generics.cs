using System.Collections.Generic;

namespace Collections
{
    class Generics
    {
        /*
         * GENERIC COLLECTIONS
         * 
         * List<T>
         * Dictionary<TKey, TValue>
         * SortedList<TKey, TValue>
         * Queue<T>
         * Stack<T>
         * 
         */
        
        //Limited to one type of object
        //Located in System.Collections.Generic namespace
        //We need to state what data type the generic collection is going to hold
        
        //LISTS
        public List<int> listElements = new List<int>();
        
        //KEY VALUE PAIRS
        public Dictionary<string, int> DictionaryKeyValuePairs = new Dictionary<string, int>();
        public SortedList<int, int> SortedListKeyValuePairs = new SortedList<int, int>();
        
        //FIFO-LIFO
        public Queue<string> queue = new Queue<string>();
        public Stack<int> intStack = new Stack<int>();

        public void AddIntsToList(params int[] ints)
        {
            foreach (int i in ints)
            {
                listElements.Add(i);
            }
        }

        public void PrintList()
        {
            foreach (int i in listElements)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void ClearAll()
        {
            listElements.Clear();
            DictionaryKeyValuePairs.Clear();
            SortedListKeyValuePairs.Clear();
            queue.Clear();
            intStack.Clear();
        }
    }
}
