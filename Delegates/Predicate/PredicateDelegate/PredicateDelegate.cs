namespace Delegate.Predicate.PredicateDelegate
{
    /*
     * C# - PREDICATE DELEGATE
     * 
     * Predicate is the delegate like Func and Action delegates. It represents a 
     * method containing a set of criteria and checks whether the passed parameter
     * meets those criteria. A predicate delegate methods must take one input parameter 
     * and return a boolean - true or false.
     * 
     * The Predicate delegate is defined in the System namespace, as shown below:
     *      Predicate signature: public delegate bool Predicate<in T>(T obj);
     *      
     *  Same as other delegate types, Predicate can also be used with any method, 
     *  anonymous method, or lambda expression.
     */

    internal class ClassObj
    {
        public static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
