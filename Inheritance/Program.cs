using SocialMediaApp;
using Inheritance.ElectricalDevice;
using Inheritance.Car;

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
            //CarTest.Run();
            //ElectricalDeviceTest.Run();
            //PostTest.Run();
            EmployeeTest.Run();

        }
    }

}


