using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Generic.ActionDelegate.WithAnonymousFunction
{
    internal class ActionDelegateWithAnonymousMethod
    {
        public static void RunExercise01()
        {
            //Func with Lambda Expression
            Action<int> printInt1 = delegate (int x)
            {
                Console.WriteLine(x);
            };
            printInt1(3225252);

            //OR 

            Action<int> printInt2 = x => Console.WriteLine(x);
            printInt2(23525);
        }
    }
}
