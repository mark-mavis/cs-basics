namespace Inheritance.MediaDevice
{
    internal class TV : MediaDevice
    {
        public TV(string brand) : base(brand){}
        public override void TogglePower()
        {
            if(IsOn){
                IsOn = false;
                Console.WriteLine($"Turning off {Brand} TV power");
            }else{
                IsOn = true;
                Console.WriteLine($"Turning on {Brand} TV power");
            }
        }
        public override void TuneDevice<T>(T station)
        {
            if(IsOn){
                Console.WriteLine($"Tuning TV to station: {station}");
            }else{
                Console.WriteLine("TV is off. Can not change station");
            }
        }
    }
}
