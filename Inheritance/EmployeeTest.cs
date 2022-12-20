

namespace Inheritance
{
    internal class EmployeeTest
    {
        public static void Run()
        {
            Boss boss = new Boss();
            boss.Lead();
            boss.Work();
            boss.Pause();

            Trainee trainee = new Trainee("Mark", "Mavis", 650000, "7am - 4pm", "5pm-7pm");
            trainee.Work();
            trainee.Learn();
            trainee.Pause();

            Employee employee = new Employee("Stephen", "Martineau", 35000);
            employee.Work();
            employee.Pause();
        }
    }
}
