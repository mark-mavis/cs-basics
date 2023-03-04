namespace Delegate.PredicateDelegate.WithAnonymousMethod
{
    class PredicateDelegateWithAnonymousMethod
    {
        public static void RunProgram()
        {
            //Assigning an Anonymous Method to a Predicate Delegate type
            Predicate<string> isUpper = delegate (string s)
            {
                //Anonymous Method
                return s.Equals(s.ToUpper());
            };
            Console.WriteLine(isUpper("hello world"));
        }
    }
}
