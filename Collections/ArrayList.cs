using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class MyArrayList
    {
        private static ArrayList objList = new ArrayList();
        public static void AddAllElementsToArrayList(params object[] parameters)
        {
            foreach(object obj in parameters)
            {
                objList.Add(obj);
            }
        }

        public static void RemoveElementMatchingValue(object o)
        {
            objList.Remove(0);
        }

        public static void RemoveAtSpecificPosition(int i)
        {
            objList.RemoveAt(i);
        }

        public static void PrintCount()
        {
            Console.WriteLine(objList.Count);
        }

        public static void PrintObjects()
        {
            foreach(object o in objList)
            {
                Console.WriteLine(o);
            }
        }
        public static void SumAllValues()
        {
            double sum = 0;
            foreach(object o in objList)
            {
                if(o is int)
                {
                    sum += Convert.ToDouble(o);
                }else if(o is double)
                {
                    sum += (double)o;
                }else if(o is string)
                {
                    continue;
                }
            }
            Console.WriteLine($"Sum is: {sum}");
        }
    }
}
