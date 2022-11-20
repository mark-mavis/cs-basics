using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class RecursionExamples
    {
        static Dictionary<int, int> _memo = new Dictionary<int, int>() { { 0, 0 }, { 1, 1 } };
        public static int TabulationFibinacci(int n)
        {
            //Memoization
            if(_memo.ContainsKey(n)) return _memo[n];
            if(n <= 1) return n;

            //starting at position 3/index 2
            for(int i = 2; i <= n; i++)
            {
                //Adding Key and Value to dictionary at the ith position
                _memo.Add(i, _memo[i - 2] + _memo[i - 1]);
            }
            //Return the value at 
            return _memo[n];
        }
        public static int RunBruteForceFibinacci(int n)
        {

            // Time Complexity:     O(n^2)
            // Space Complexity:    O(n^2)

            //Base Cases n = 2 or 1
            if (n <= 2) return 1;

            // Lots of Repetative Calls in this method. Does not work for large numbers 
            return RunBruteForceFibinacci(n - 1) + RunBruteForceFibinacci(n - 2);
        }
        public static int RunMemoizationFibinacci(int n)
        {
            
            //If the Fib number "n" has already been computed
            if (_memo.ContainsKey(n))
            {
                // Return the element in the memo at key n
                return _memo[n];
            }

            //Base Cases: When n == 1 or 2, return 1;
            if (n <= 2)
            {
                return 1;
            }

            _memo[n] = RunMemoizationFibinacci(n - 1) + RunMemoizationFibinacci(n - 2);

            return _memo[n];
        }

        public static void Run()
        {

        }
    }
}
