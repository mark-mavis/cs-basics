
namespace ConstructorInjection
{
    public interface IDependency
    {
        void DependencyMethod();
    }

    public class Dependency : IDependency
    {
        public string? Title { get; set; }
        public Dependency(string? title)
        {
            Title = title;
        }

        public void DependencyMethod()
        {
            Console.WriteLine($"{Title}: IDependency Dependency Class Called");
        }
    }
    public class DependentClass
    {
        public IDependency? _dependency;
        public DependentClass()
        {
            _dependency = null;
        }

        public DependentClass(IDependency dependency)
        {
            _dependency = dependency;  
        }

        public void AddDependency(IDependency dependency)
        {
            if(dependency != null) _dependency = dependency;
            else
            {
                Console.WriteLine("You Didn't Pass a dependency");
            }
        }

        public void RunDependencyMethod()
        {
            if( _dependency != null )
            {
                _dependency.DependencyMethod();
            }
            else
            {
                Console.WriteLine("Is not dependent on a dependency");
            }
            
        }
    }

    public class Program
    {
        public static void Run()
        {
            IDependency C1dependency = new Dependency("DC1 Dependency");
            DependentClass dc1 = new DependentClass();
            
            dc1.RunDependencyMethod();
            dc1.AddDependency(C1dependency);
            dc1.RunDependencyMethod();

            IDependency C2dependency = new Dependency("DC2 Dependency");
            DependentClass dc2 = new DependentClass(C2dependency);
            dc2.RunDependencyMethod();

            Console.WriteLine("Press Enter to shutdown...");
            Console.ReadLine();
        }
    }
}

