using SocialMediaApp;
using Inheritance.Car;
using Inheritance.MediaDevice;
using Inheritance.Employee;

namespace Inheritance
{
    /*
     * Allows us to define a class in terms of another class, which makes
     * it easier to create and maintain an application. This also provides
     * oppurtunity to reuse the code functionality and speeds up
     * implementation time
     */

    public class BaseClass { }
    public class DerivedClass : BaseClass { }


    internal class Program
    {
        private static void Main(string[] args)
        {
            //Media Device Tests
            Radio radio = new Radio("Mitsubishi");
            radio.TogglePower();
            radio.TuneDevice<float>(99.9f);
            radio.TogglePower();
            radio.TuneDevice<float>(102.5f);

            TV tv = new TV("Samsung");
            tv.TogglePower();
            tv.TuneDevice<int>(65);
            tv.TogglePower();
            tv.TuneDevice<int>(555);

            //Employees Example
            Boss boss = new Boss();
            boss.Lead();
            boss.Work();
            boss.Pause();

            Trainee trainee = new Trainee("Mark", "Mavis", 650000, "7am - 4pm", "5pm-7pm");
            trainee.Work();
            trainee.Learn();
            trainee.Pause();

            Employee.Employee employee = new Employee.Employee("Stephen", "Martineau", 35000);
            employee.Work();
            employee.Pause();

            //Social Media Posts Example
            Post post = new Post("Happy Birthday Casey!", "markwmavis", true);
            Console.WriteLine(post.GetType().ToString() + ": " + post.ToString());
            post.Update("Happy Birthday Casey! I hope it is a good one.", true);
            Console.WriteLine(post.ToString());
            MoviePost moviepost = new MoviePost("People going crazy!", "markwmavis", true, "http:://www.youtube.com", 39);
            Console.WriteLine(moviepost.ToString());
            ImagePost imagePost1 = new ImagePost("hello from the cayman islands!", "cconroy", false, "http:://www.facebook.com");
            Console.WriteLine(imagePost1.ToString());
            ImagePost imagepost2 = new ImagePost();
            Console.WriteLine(imagepost2.ToString());

            //Automobile Example
            RaceCar racecar = new RaceCar(750, 2, 4);
            racecar.Drive();
            racecar.Honk();

            FamilyCar familyCar = new FamilyCar(128, 6, 4);
            familyCar.Drive();
            familyCar.Honk();
        }
    }
}


