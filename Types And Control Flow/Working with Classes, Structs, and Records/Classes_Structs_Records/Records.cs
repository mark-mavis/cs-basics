namespace _01_Classes_Structs_Records;

// RECORDS
/*
    Records are intended for when want to have immutable(unchangable) objects where the object whose state cannot be modified after it is created. They dont have to be immutable
    but they can and it is usefull in scenarios where you maybe using it as a data object and you are passing it around between service layers or between application layers. Its about creating an object with state and passing it around.
*/

public record Customer : IPerson
{
    //Can implement Interfaces
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int EmployeeId { get; set; }
    public Age Age { get; set; }

    public Customer(string firstName, string lastName, int id, Age age)
    {
        FirstName = firstName;
        LastName = lastName;
        EmployeeId = id;
        Age = age;
    }
}

public record PremiereCustomer : Customer
{
    //init says that the Property HAS TO BE initialized when it is created and then it can not be changed after that! init is a way to create immutable objects so that can not be changed and passed arround
    public byte CustomerLevel { get; init; }
    public PremiereCustomer(string firstName, string lastName, int id, Age age, byte customerLevel) : base(firstName, lastName, id, age)
    {
        CustomerLevel = customerLevel;
    }
}

public record struct Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    public override string ToString()
    {
        return $"Order Number: {OrderId} Date Ordered: {OrderDate}";
    }
}