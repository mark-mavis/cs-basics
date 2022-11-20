using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class GridTraveler
    {
        /*
            * Say that you are a travelor on a 2D grid. You begin
            * in the top-lefl corner and your goal is to travel to
            * the bottom-right corner. You may only move down or right.
            * 
            * In how many ways can you travel to the goal on a grid 
            * with dimensions m * n?
        */

        private Dictionary<string, int> _map = new Dictionary<string, int>();

        public int RecursiveFunction(int m, int n)
        {
            string key = $"{m},{n}";
            //Memoization
            if (_map.ContainsKey(key))
            {
                return _map[key];
            }

            if (m == 1 && n == 1) return 1;
            if (m == 0 || n == 0) return 0;

            _map.Add(key, RecursiveFunction(m - 1, n) + RecursiveFunction(m, n - 1));

            return _map[key];
        }

        public static void RunProgram()
        {
            GridTraveler gt = new GridTraveler();
            
            Stopwatch sw;
            sw = new Stopwatch();
            Console.WriteLine(gt.RecursiveFunction(2, 3));
            Console.WriteLine(sw.ElapsedTicks);

            sw = new Stopwatch();
            Console.WriteLine(gt.RecursiveFunction(9, 9));
            Console.WriteLine(sw.ElapsedTicks);

            sw = new Stopwatch();
            Console.WriteLine(gt.RecursiveFunction(30, 30));
            Console.WriteLine(sw.ElapsedTicks);
        }
        
    }
}
