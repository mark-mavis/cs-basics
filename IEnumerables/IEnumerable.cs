using System.Collections;
using System.ComponentModel;

namespace IEnumerables
{
    public class IEnumerableClass
    {
        class MyArrayList : IEnumerable
        {
            object[] m_Items = null;
            int freeIndex = 0;

            public MyArrayList()
            {
                m_Items = new object[100];
            }

            public void Add(object item)
            {
                m_Items[freeIndex] = item;
                freeIndex++;
            }
            public IEnumerator GetEnumerator()
            {
                foreach (object o in m_Items)
                {
                    if(o == null)
                    {
                        break;
                    }
                    yield return 0;
                }
            }
        }
        class MyInfiniteEnumable : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                return new MyInfiniteEnumerator();
            }
        }

        class MyInfiniteEnumerator : IEnumerator<int>
        {
            //Default Value of Auto-Implemented Property
            [DefaultValue(0)]   //DefaultValueAttribute
            public int Current { get; private set; } = 0;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                Current++;
                return true;
            }

            public void Reset()
            {
                Current = 0;
            }
        }

        public static void RunExercise01()
        {
            var array = new int[] {1, 2, 3 };

            array.GetEnumerator();
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            /*
             *  Arrays are enumerables and foreach works on 
             *  enumerables
             */
            foreach (var a in array)
            {
                Console.WriteLine(a);
            }
        }
        public static void IterateArrayList()
        {
            ArrayList list = new ArrayList();
            list.Add("1");
            list.Add(2);
            list.Add("3");
            list.Add("4");

            foreach(object s in list)
            {
                Console.WriteLine(s);
            }
        }
        public static void IterateGenericCollection()
        {
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("one");
            listOfStrings.Add("two");
            listOfStrings.Add("three");
            listOfStrings.Add("four");

            foreach (string s in listOfStrings)
            {
                Console.WriteLine(s);
            }
        }
        public static void IEnumerableYield()
        {
            /* When using yield return....
                - Function should return an IEnumerable
                - The call should come from an iteraction block
            */
            static IEnumerable<int> YieldReturn()
            {
                //Yield Return saves the state and each time the function is called moves to the next uncalled line
                yield return 1;
                yield return 2;
                yield return 3;
            }

            foreach(int i in YieldReturn())
            {
                Console.WriteLine(i);
            }
        }
        public static void CustomIEnumerable()
        {
            
        }
    }
}
