namespace Inheritance.MediaDevice
{
    internal abstract class MediaDevice
    {
        public bool IsOn {get; set;} = false;
        public string Brand {get; set;}
        public MediaDevice(string brand){
            Brand = brand;
        }
        public abstract void TogglePower();

        public abstract void TuneDevice<T>(T station);

    }
}