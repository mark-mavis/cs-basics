using Inheritance;
internal class Program
{
    private static void Main(string[] args)
    {
        ElectricalDevice radio = new Radio(false, "Sony");
        ElectricalDevice tv = new TV(true, "Samsung");
        radio.SwitchOn();
        tv.SwitchOff();

    }
}