namespace DependencyInjection.Applications.Calculator
{
    public interface IDelegateCalculate
    {

    }
    
    class Addition<T> : IDelegateCalculate
    {
        private T _value;
        public T Value { 
            get{ return _value; } 
            set{ _value = value; } 
        }
        public Addition(T val){
            _value = val;
        }
    }
    
    
    
    
    
    public interface ICalculateService
    {
        
    }

    class Addition : ICalculateService
    {

    }

    class Multiplication : ICalculateService
    {

    }
    public class Calculator
    {


        private List<ICalculateService> _services;

        public Calculator()
        {
            _services = new List<ICalculateService>();
        }
        public void Add(ICalculateService service)
        {
            _services.Add(service);
        }

    }
}
