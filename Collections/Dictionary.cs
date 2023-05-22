using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DictionaryExample
{

    public class Employee
    {
        private static int _employeeCount = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int EmploeeCount { get{ return ++_employeeCount; } }
        public int Age { get; set; }
        public int Rate { get; set; }
        public Employee(string name, string role, int age, int rate)
        {
            Id = EmploeeCount;
            Name = name;
            Role = role;
            Age = age;
            Rate = rate;
        }
        public int Salary()
        {
            return Rate * 8 * 5 * 4 * 12;
        }

    }

    
    public class EmployeeDatabase
    {
        private readonly Dictionary<int, Employee> _database;
        public EmployeeDatabase()
        { 
            _database = new Dictionary<int, Employee>();
        }
        private static Employee CollectEmployeeDetails()
        {
            
            Console.WriteLine("Enter Employee Name...");
            string? name_str = Console.ReadLine();

            while (String.IsNullOrEmpty(name_str) || !Regex.IsMatch(name_str, "[a-zA-Z+$]"))
            {
                Console.WriteLine("You entered an incorrect input. Name can only include letters and spaces");
                name_str = Console.ReadLine();
            }

            Console.WriteLine("Enter Employee Role...");
            string? role_str = Console.ReadLine();

            while (String.IsNullOrEmpty(role_str) || !Regex.IsMatch(role_str, "[a-zA-Z+$]"))
            {
                Console.WriteLine("You entered an incorrect role. Roles can only include letters and spaces");
                role_str = Console.ReadLine();
            }

            Console.WriteLine("Enter Employee Age...");
            string? age_str = Console.ReadLine();
            Int32.TryParse(age_str, out int age);

            Console.WriteLine("Enter Employee Pay Rate...");
            string? rate_str = Console.ReadLine();
            Int32.TryParse(rate_str, out int rate);


            return new Employee(name_str, role_str, age, rate);

        }
        
        public void AddEmployee()
        {
            Employee temp = CollectEmployeeDetails();
            if (!_database.ContainsValue(temp))
            {
                _database.Add(temp.Id, temp);
            }
            else
            {
                Console.WriteLine($"Employee already exists in database. Try again....");
            }
            
        }
        public void RemoveEmployee(int employeeIdNumber)
        {
            if (_database.ContainsKey(employeeIdNumber))
            {
                _database.Remove(employeeIdNumber);
            }
            else
            {
                Console.WriteLine("Role does not currently exist");
            }   
        }
        public void UpdateEmployeeRole(Employee current_employee, Employee updated_employee)
        {
            if (_database.ContainsKey(current_employee.Id))
            {
                _database[current_employee.Id] = updated_employee;
            }
            else
            {
                Console.WriteLine("Employee does not exist and can not be updated");
            }
        }
        public void DisplayEmployeeDetails(int employeeIdNumber)
        {
            if (_database.ContainsKey(employeeIdNumber))
            {
                Console.WriteLine($"Name: {_database[employeeIdNumber].Name} Role: {_database[employeeIdNumber].Role} Age: {_database[employeeIdNumber].Age} Rate: {_database[employeeIdNumber].Rate} Salary: {_database[employeeIdNumber].Salary()}");
            }
        }

    }

    public class EmployeeDatabaseController
    {
        public static void Run()
        {   
            EmployeeDatabase db = new EmployeeDatabase();
            db.AddEmployee();
            db.AddEmployee();


            //db.AddEmployee(new Employee(1, "Chase Jones", "Legal", 39, 200));
            //db.DisplayEmployeeDetails(1);
            //db.AddEmployee(new Employee(2, "Robby Nelson", "Accounting", 38, 200));
            //db.DisplayEmployeeDetails(2);


        }
    }
    
}
