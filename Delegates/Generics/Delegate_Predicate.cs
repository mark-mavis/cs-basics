namespace Delegate
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

    public delegate bool CustomPredicate(List<int> l);
    
    internal class SystemDefinedDelegate_Predicate
    {
        internal class ClassObj
        {
            public static bool IsUpperCase(string str)
            {
                return str.Equals(str.ToUpper());
            }
        }
        public static void Predicate()
        {
            Predicate<string> isUpper = ClassObj.IsUpperCase;
            bool result = isUpper("hello world!!");
            Console.WriteLine(result);

            Predicate<string> isUpperPred = delegate (string str) 
            {
                return str.All( (x) => Char.IsUpper(x) );
            };
            
            Predicate<string> isLowerPred = (string s) => {
                return s.All( (ch) => Char.IsLower(ch) );
            };

            Console.WriteLine(isUpperPred("UIUROEIOW"));
            Console.WriteLine(isUpperPred("KJjkfdlsDF"));
            Console.WriteLine(isLowerPred("j"));
            Console.WriteLine(isLowerPred("ERfkjTDkjl"));

        }

        public static void PredicateWithAnonymousFunction(){
            
            //Assigning an Anonymous Method to a Predicate Delegate type
            Predicate<string> isUpper = delegate (string s)
            {
                //Anonymous Method
                return s.Equals(s.ToUpper());
            };
            Console.WriteLine(isUpper("hello world"));
        }

        public static void PredicateWithLambdaExpression()
        {
            Predicate<string> isUpper = s => s.Equals(s.ToUpper());
            Console.WriteLine(isUpper("hello world!!"));
        }
    }
}
