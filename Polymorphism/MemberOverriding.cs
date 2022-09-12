namespace Polymorphism.MemberOverriding
{
    
    
    public class SuperClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Super Class Method1 Called");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Super Class Method2 Called");
        }
    }

    public class DerivedClass : SuperClass
    {
        public override void Method1()
        {
           base.Method1();  //Accessing the base class Method1
           Console.WriteLine("Derived Class Method Called");
        }

        //To avoid having to rename Method2 in the derived class,
        //you can use the New keyword hide the superclasses
        //"Method2"
        public new void Method2()
        {
            
            Console.WriteLine("Derived Class Method2 Called");

        }
        
    }

    public class MemberOverriding
    {
        public static void Run()
        {
            
            SuperClass sclass = new SuperClass();
            DerivedClass dclass = new DerivedClass();
            sclass.Method1();
            dclass.Method1();
            dclass.Method2();
            

        }
    }
}
