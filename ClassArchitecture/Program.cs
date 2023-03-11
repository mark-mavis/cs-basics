using System;
using System.IO;    //FileStream

namespace Architecture
{
    // Interface to provide a way for the processor class to get data
    public interface IDataProvider<T>
    {
        IEnumerable<T> GetData();
    }

    // Data Provider
    public class RandomDataProvider : IDataProvider<int>
    {
        private readonly int _maxValue;
        private readonly int _count;
        private readonly Random _random;
        public RandomDataProvider(int maxValue, int count)
        {
            _maxValue = maxValue;
            _count = count;
            _random = new Random();
        }

        public IEnumerable<int> GetData()
        {
            for(int i = 0; i < _count; i++)
            {
                yield return _random.Next(_maxValue);
            }
        }
    }

    // Data Manipulate Interface
    public interface IDataManipulator<T, V>
    {
        V Manipulate(T value);
    }

    // Data Manipulator Behaviors
    public class ExponentialManipulator : IDataManipulator<int, int>
    {
        private readonly int _exponent;
        public ExponentialManipulator(int exponent)
        {
            _exponent = exponent;
        }
        public int Manipulate(int data)
        {
            return (int)Math.Pow(data, _exponent);
        }
    }
    public class ConstantManipulator : IDataManipulator<int, int>
    {
        private readonly int _constant;
        public ConstantManipulator(int constant)
        {
            _constant = constant;
        }
        public int Manipulate(int data)
        {
            return data * _constant;
        }
    }


    public interface IDataWriter<T>
    {
        void Write(T data);
    }

    public class LogWriter : IDataWriter<int>, IDisposable
    { 

        private readonly string _fileName;
        private readonly FileStream _fileStream;
        private readonly StreamWriter _streamWriter;
        public LogWriter(string fileName)
        {
            _fileName = fileName;
            Directory.CreateDirectory("logs");
            _fileStream = new FileStream($"logs/{fileName}", FileMode.OpenOrCreate);
            _streamWriter = new StreamWriter(_fileStream);
        }

        public void Write(int data)
        {
            _streamWriter.WriteLine(data);
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose Method Called");
            _streamWriter.Flush();
            _streamWriter.Dispose();
            _fileStream.Dispose();
        } 
    }


    class Processor
    {
        private readonly IDataProvider<int> _dataCollector;
        private readonly IDataManipulator<int, int> _dataManipulator;
        private readonly IDataWriter<int> _dataWriter;

        public Processor(IDataProvider<int> collector, IDataManipulator<int, int> manipulator, IDataWriter<int> dataWriter)
        {
            _dataCollector = collector;
            _dataManipulator = manipulator;
            _dataWriter = dataWriter;
        }

        public void Process()
        {
            foreach(int i in _dataCollector.GetData())
            {
                int result = _dataManipulator.Manipulate(i);
                _dataWriter.Write(result);
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            IDataProvider<int> provider = new RandomDataProvider(maxValue: 500, count: 40);
            IDataManipulator<int, int> exponentialManipulator = new ExponentialManipulator(3);
            IDataWriter<int> dataWriter = new LogWriter("Exponential-Manipulator.txt");
            
            Processor processor = new Processor(provider, exponentialManipulator, dataWriter);

            processor.Process();

            IDataManipulator<int, int> constantManipulator = new ConstantManipulator(10);
            IDataWriter<int> constantWriter = new LogWriter("Constant-Manipulator.txt");

            processor.Process();
        }
    }


}