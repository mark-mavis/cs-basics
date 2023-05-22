using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SearchingApp
{
    public delegate bool Search_Del(string str, char ch);
    
    public class DelegateSearch
    {
        public static List<string> people = new List<string>() { "Jenny Johnson", "Erik Peterson", "Josh Roberts", "Jose Gonzales", "Peter Navaro"};

        public static void Run()
        {
            List<string> search_results;
            Search_Del search = new Search_Del(ContainingChar);
            
            search_results = people.FindAll(str => ContainingChar(str, 'e') && StartingWith(str, 'J'));
            Print(search_results);
            search_results.Clear();
            
            search_results = people.FindAll(str => StartingWith(str, 'J'));
            Print(search_results);
            search_results.Clear();

            people.RemoveAll( (str) => ContainingStr(str, "onz"));
            Print(people);
        }

       
        static bool ContainingStr(string str, string criteria)
        {
            return str.Contains(criteria);
        }

        static bool ContainingChar(string str, char ch)
        {
            return str.Contains(ch);
        }
        static bool StartingWith(string str, char ch)
        {
            return str.StartsWith(ch);
        }

        public static void Print(List<string> list)
        {
            foreach(string str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}
