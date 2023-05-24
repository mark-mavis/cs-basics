namespace Inheritance.Employee;
internal class Employee
{
    public string FirstName { get; set; } = "unknown";
    public string LastName { get; set; } = "unknown";
    public int Salary { get; set; } = 0;

    public Employee()
    {
        this.Salary = 0;
    }

    public Employee(string firstName, string lastName, int salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Salary = salary;
    }

    public virtual void Work()
    {
        Console.WriteLine("Employee Working");
    }

    public virtual void Pause()
    {
        Console.WriteLine("Employee Pausing Work");
    }

}

