namespace Inheritance.Employee;
internal class Trainee : Employee
{
    public string WorkingHours { get; set; }
    public string SchoolHours { get; set; }

    public Trainee()
    {
        this.WorkingHours = "8am - 5pm";
        this.SchoolHours = " 6pm - 9pm";
    }

    public Trainee(string firstName, string lastName, int salary, string workingHours, string schoolHours) : base(firstName, lastName, salary)
    {
        this.WorkingHours = workingHours;
        this.SchoolHours = schoolHours;
    }

    public void Learn()
    {
        Console.WriteLine("Trainee Learning");
    }
    public override void Work()
    {
        Console.WriteLine("Trainee Working");
    }
    public override void Pause()
    {
        Console.WriteLine("Trainee pausing work");
    }
}

