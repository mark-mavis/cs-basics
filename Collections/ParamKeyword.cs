using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ParamKeyword
    {
        public static void RunParamExample(params string[] sentence)
        {
            for(int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
            }
        }

        public static void RunParamObjExample(params object[] parameter)
        {
            for(int i = 0; i < parameter.Length; i++)
            {
                Console.WriteLine(parameter[i]);
            }
        }

        public static void RunParamMin(params int[] ints)
        {
            int min = int.MaxValue;
            foreach(int i in ints)
            {
                if(i < min) min = i;
            }
            Console.WriteLine($"Min value: {min}");
        }
    }
}
