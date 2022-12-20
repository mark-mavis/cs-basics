namespace Inheritance.ElectricalDevice
{
    internal abstract class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        //Base Constructor
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }
        public abstract void SwitchOn();
        public abstract void SwitchOff();

        public abstract void Listen();
    }
}
