namespace Inheritance.Employee;
internal class Boss : Employee
{
    public bool CompanyCar { get; set; }

    public Boss() { this.CompanyCar = false; }

    public Boss(string firstName, string lastName, int salary, bool companyCar) : base(firstName, lastName, salary)
    {
        this.CompanyCar = false;
    }

    public void Lead()
    {
        Console.WriteLine("Boss is Leading");
    }

    public override void Work()
    {
        Console.WriteLine("Boss Working");
    }
    public override void Pause()
    {
        Console.WriteLine("Boss pausing work");
    }
}

