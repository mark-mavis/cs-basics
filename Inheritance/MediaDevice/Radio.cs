namespace Inheritance.MediaDevice
{
    internal class Radio : MediaDevice
    {
        //Tell the Radio constructor to pass the arguments along to the 
        // base constructor
        public Radio(string brand) : base(brand){}

        public override void TogglePower()
        {
            if(IsOn){
                IsOn = false;
                Console.WriteLine($"Turning off {Brand} radio power");
            }else{
                IsOn = true;
                Console.WriteLine($"Turning on {Brand} radio power");
            }
        }
        public override void TuneDevice<T>(T station)
        {
            if(IsOn){
                Console.WriteLine($"Tuning Radio to station: {station}");
            }else{
                Console.WriteLine("Radio is off. Can not change station");
            }
            
        }
    }

}
