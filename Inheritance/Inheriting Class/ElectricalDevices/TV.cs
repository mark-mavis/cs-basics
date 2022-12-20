namespace Inheritance.ElectricalDevice
{
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }


        public override void SwitchOn()
        {
            Console.WriteLine("Switching on TV");
            IsOn = true;
        }
        public override void SwitchOff()
        {
            Console.WriteLine("Switching off TV");
            IsOn = false;
        }


        public override void Listen()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV");
            }
            else
            {
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
