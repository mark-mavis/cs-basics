namespace Inheritance.ElectricalDevice
{
    internal class Radio : ElectricalDevice
    {
        //Tell the Radio constructor to pass the arguments along to the 
        // base constructor
        public Radio(bool isOn, string brand) : base(isOn, brand) { }

        public override void SwitchOn()
        {
            Console.WriteLine("Switching on Radio");
            IsOn = true;
        }
        public override void SwitchOff()
        {
            Console.WriteLine("Switching off Radio");
            IsOn = false;
        }
        public override void Listen()
        {
            if (IsOn)
            {
                Console.WriteLine("Listen to the Radio");
            }
            else
            {
                Console.WriteLine("Radio is switced off, switch it on first");
            }
        }
    }

}
