namespace Inheritance.ElectricalDevice
{
    internal class ElectricalDeviceTest
    {
        public static void Run()
        {
            ElectricalDevice radio = new Radio(false, "Sony");
            ElectricalDevice tv = new TV(true, "Samsung");
            radio.SwitchOn();
            radio.Listen();
            radio.SwitchOff();
            radio.Listen();

            tv.SwitchOff();
            tv.SwitchOn();
            tv.Listen();
            tv.SwitchOff();
            tv.Listen();
        }
    }
}
