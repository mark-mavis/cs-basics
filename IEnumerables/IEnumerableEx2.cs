using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
    internal class IEnumerableEx2
    {
        public class IEnumerableSum
        {
            public void CollectionSum(IEnumerable<int> collection)
            {
                int sum = 0;
                foreach (int i in collection)
                {
                    sum += i;
                }
                Console.WriteLine($"Sum: {sum}");
            }
        }
        public static void Run()
        {
            IEnumerableSum iEnumSum = new IEnumerableSum();

            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            iEnumSum.CollectionSum(list);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            iEnumSum.CollectionSum(queue);
        }

    }
}
