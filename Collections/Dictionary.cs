namespace Collections
{
    class MyDictionary
    {
        public Employee[] employeeDatabase = new Employee[]
        {
            new Employee("Gwyn", "CEO" , 95, 200),
            new Employee("Joe", "Manager", 35, 25),
            new Employee("Lora", "HR", 32, 21),
            new Employee("Petra", "Secretary", 28, 18),
            new Employee("Artorias", "Lead Developer", 55, 35),
            new Employee("Ernest", "Intern", 22, 8), 
        };

    }

    class MyDictionaryTester
    {
        public static void RunDictionary()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(0, "Hello");
            keyValuePairs.Add(1, "there");
            keyValuePairs.Add(2, "!");
        }
        public static void ParenthesesGame(string parens)
        {
            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>(){ {'(', ')'}, {'{', '}' }, {'[', ']' } };
            
            Stack<char> stack = new Stack<char>();
            
            if(parens.Length > 0)
            {
                foreach(char c in parens)
                {
                    if(keyValuePairs.ContainsKey(c)) stack.Push(c);
                    else if (c == keyValuePairs[stack.Peek()]) stack.Pop();
                }
                if(stack.Count == 0) Console.WriteLine("It is a valid parenthises string");
                else Console.WriteLine("Invalid string");
            } 
        }
        public static void CreateEmployeeDirectory()
        {
            MyDictionary employeeList = new MyDictionary();
            
            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();

            foreach(Employee e in employeeList.employeeDatabase)
            {
                employeeDirectory.Add(e.Role, e);
            }

            //Getting the KeyValuePair from a Dictionary at an Index...
            KeyValuePair<string, Employee> employeeKeyValuePair = employeeDirectory.ElementAt(0);

            //Getting the Employee from a Dictionary using the KeyValuePair
            Employee employee = employeeDirectory.GetValueOrDefault(employeeKeyValuePair.Key);

            //Updating a Value at a Key Location
            string keyUpdateLocation = "Secretary";
            employeeDirectory[keyUpdateLocation] = new Employee("Stephanie", "Secretary", 26, 20);


            
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }

        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        public Employee(string name, string role, int age, float rate)
        {
            Name = name;
            Role = role;
            Age = age;
            Rate = rate;
        }
    }
}

