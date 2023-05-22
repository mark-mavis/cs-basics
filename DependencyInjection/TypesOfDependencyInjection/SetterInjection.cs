

namespace Setter_Injection
{
    public interface IDependency
    {
        void SomeMethod();
    }
    public class Dependency : IDependency
    {
        public void SomeMethod()
        {
            Console.WriteLine($"Some method action");
        }
    }


    public class Dependent
    {
        IDependency? _dependency;
        public IDependency SetDependency
        {
            get { if(_dependency != null) return _dependency;
            return new Dependency(); }
            set { _dependency = value; } 
        }

        public void CallDependency()
        {
            if(_dependency != null) _dependency.SomeMethod();
        }
    }


    public class Program
    {
        public static void Run()
        {
            Dependent d = new Dependent();
            IDependency dependancy = new Dependency();
            d.SetDependency = dependancy;
            d.CallDependency();

        }
    }

}
