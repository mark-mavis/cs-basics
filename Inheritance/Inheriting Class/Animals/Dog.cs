namespace Inheritance
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }
        public override void Eat()
        {
            //base.Eat(); Tells the base class eat to be called

        }

    }
}
