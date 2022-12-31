using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
    internal class IEnumerableEx1
    {
        public class CollectionClass
        {
            public IEnumerable<int> GetCollection(int option)
            {
                List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

                Queue<int> queue = new Queue<int>();
                queue.Enqueue(6);
                queue.Enqueue(7);
                queue.Enqueue(8);
                queue.Enqueue(9);
                queue.Enqueue(10);

                int[] array = new int[] { 11, 12, 13, 14, 15 };

                if (option == 1)
                {
                    return list;
                }
                else if (option == 2)
                {
                    return queue;
                }
                else
                {
                    return array;
                }
            }
        }

        public static void Run()
        {
            IEnumerable<int> unknownCollection;
            CollectionClass cc = new CollectionClass();
            unknownCollection = cc.GetCollection(1);
            
            foreach(int i in unknownCollection)
            {
                Console.WriteLine(i);
            }

            unknownCollection = cc.GetCollection(2);

            foreach(int i in unknownCollection)
            {
                Console.WriteLine(i);
            }

            unknownCollection = cc.GetCollection(5);

            foreach (int i in unknownCollection)
            {
                Console.WriteLine(i);
            }


        }
    }
}
