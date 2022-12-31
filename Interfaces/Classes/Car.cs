
namespace Interfaces
{
    internal class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }
        
        //Creating a new property to store the destroyable objects nearby
        //when a car gets destroyed it should also destroy the nearby object
        //this list is of type IDestroyable which means it can store any object
        //that implements this interface and we can only access the properties and 
        //methods in this interface

        public List<IDestroyable> DestroyableItemsNearBy;
        public Car() { }
        public Car(int speed, string color) : base(speed, color){
            DestructionSound = "CarExplosionSound.mp3";
            DestroyableItemsNearBy = new List<IDestroyable>();
        }
        public void Destroy()
        {
            Console.WriteLine($"{DestructionSound}");
            foreach(IDestroyable destroyable in DestroyableItemsNearBy)
            {
                destroyable.Destroy();
            }
        }
    }
}
