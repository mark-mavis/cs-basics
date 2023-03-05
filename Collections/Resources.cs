namespace Collections
{
    public class Employee
    {
        public Employee(string name, string role, int age, float rate)
        {
            Name = name;
            Role = role;
            Age = age;
            Rate = rate;
        }
        public string Name { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get{ return Rate * 8 * 5 * 4 * 12; }
        } 
    }
    public class EmployeeDatabase
    {
        public static Employee[] employeeDatabase = new Employee[]
        {
            new Employee("Gwyn", "CEO" , 95, 200),
            new Employee("Joe", "Manager", 35, 25),
            new Employee("Lora", "HR", 32, 21),
            new Employee("Petra", "Secretary", 28, 18),
            new Employee("Artorias", "Lead Developer", 55, 35),
            new Employee("Ernest", "Intern", 22, 8)
        };
    }
}

