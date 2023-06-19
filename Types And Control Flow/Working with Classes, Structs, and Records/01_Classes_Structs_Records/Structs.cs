namespace _01_Classes_Structs_Records;
// STRUCTS ARE VALUE TYPES!!
/*
    Any variable holding a struct is holding the value of that struct
*/
public struct Age
{
    public Age(DateTime dob)
    {
        BirthDate = dob;
        YearsOld = DateTime.Now.Year - dob.Year;
    }
    public DateTime BirthDate { get; set; }
    public int YearsOld { get; set; }

    public static bool operator ==(Age a1, Age a2)
    {
        return a1.BirthDate == a2.BirthDate &&
                a1.YearsOld == a2.YearsOld;
    }
    public static bool operator !=(Age a1, Age a2)
    {
        return a1.BirthDate != a2.BirthDate ||
                a1.YearsOld != a2.YearsOld;
    }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

}

// Because structs are value types, they can not be inherited from. All value types are this way
//public struct BiologicalAge : Age{ }

public struct Vendor : IPerson
{
    // Structs can implement interfaces
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int EmployeeId { get; set; }
    public Age Age { get; set; }

    // Structs can implement methods too!
    public string GetFullName()
    {
        return $"Name: {FirstName} {LastName}\n";
    }

}