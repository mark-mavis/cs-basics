namespace Access_Modifiers
{
    // Internal - Relates to the assembly
    // Protected - Relates to the inheritance

    public class AccessDemo
    {
        private void PrivateDemo()
        {
            /* Summary: Accesible only in the class it is a member of
             * 
             * The only other things that will be able to call this method, are the
             * the methods inside of the AccessDemo class
             */
        }
        private protected void PrivateProtectedDemo()
        {
            /* Summary: Accesible within the class it is a member to and the derived
             *          classes that are in the same assembly
             * 
             * Accessible within any method that is a part of the class that the 
             * private protected method is a member of and also to methods that are 
             * a part of classes that have been derived from this class AND
             * inside the same assembly
             */
        }

        protected void ProtectedDemo()
        {
            /* Summary: Accesible within the class it is a member to and the derived
             *          classes in any assembly
             *          
             * Accessible within any method that is a part of the class that 
             * it belongs too and within any method inside a class that is 
             * derived from that same class regaurdless of the assembly it
             * belongs too
             * 
             * Do not see it very often because we don't see inheritance 
             * a lot
             */
        }
        protected internal void ProtectedInternalDemo()
        {
            /* Accessible anywhere in the same assembly and also in any class
             * derived from the class that the method is a member of regaurdless
             * of assembly.
             */
        }

        internal void InternalDemo()
        {
            /* Accessible inside the entire assembly. So within the project
             */
        }

        public void PublicDemo()
        {
            //Accessible Anywhere
        }
    }
}
