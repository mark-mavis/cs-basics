namespace _01_Classes_Structs_Records;
using System;

// CLASSES ARE REFERENCE TYPES!!
/*
    Any variable carrying an instance of a class, it pointing to a reference
*/
public class Employee : IPerson
{
    public Employee(string firstName, string lastName, int employeeId, Age age, DateOnly startDate)
    {
        FirstName = firstName;
        LastName = lastName;
        EmployeeId = employeeId;
        Age = age;
        StartDate = startDate;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int EmployeeId { get; set; }
    public Age Age { get; set; }

    //Employee class implements additional Auto-properties
    public DateOnly StartDate { get; set; }

    public override string ToString()
    {
        return $"Employee Name: {FirstName} {LastName} Employee Id: {EmployeeId} Birthday: {Age.BirthDate.ToShortDateString()} Age: {Age.YearsOld} Start Date: {StartDate.ToShortDateString()}";
    }

    // override object.Equals
    public override bool Equals(object? obj)
    {
        //Check for null and compare run-time types.
        if ((obj == null) || !this.GetType().Equals(obj.GetType()))
        {
            return false;
        }
        else
        {
            Employee emp = (Employee)obj;
            return (FirstName == emp.FirstName) &&
               (LastName == emp.LastName) &&
               (EmployeeId == emp.EmployeeId);
        }
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName, EmployeeId, Age);
    }

    public static bool operator ==(Employee e1, Employee e2)
    {
        return e1.FirstName == e2.FirstName &&
        e1.LastName == e2.LastName &&
        e1.Age == e2.Age;
    }
    public static bool operator !=(Employee e1, Employee e2)
    {
        return e1.FirstName != e2.FirstName ||
        e1.LastName != e2.LastName ||
        e1.Age != e2.Age;
    }
}




public class Manager : Employee
{
    protected static int _managerCount = 0;
    public int ManagerID { get; set; }
    public Manager(string firstName, string lastName, int id, Age age, DateOnly startDate) : base(firstName, lastName, id, age, startDate) { }
    public void SetReports(int numberOfReports)
    {
        NumberOfDirectReports = numberOfReports;
    }
    public int NumberOfDirectReports { get; private set; }

}
