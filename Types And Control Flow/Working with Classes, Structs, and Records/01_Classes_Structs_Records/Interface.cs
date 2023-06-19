namespace _01_Classes_Structs_Records;
public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int EmployeeId { get; set; }
    public Age Age { get; set; }
}