
using System.Runtime.CompilerServices;

namespace AnimalWorldApp;



interface IMovable
{
    void Move(int x, int y, int rate);
}
class Swim : IMovable
{
    public void Move(int x, int y, int rate)
    {
        Console.WriteLine($"Swimming to position {x},{y} at a rate of {rate}");
    }
}
class Fly : IMovable
{
    private enum MovementType { Takeoff, Glide, Land };
    public void Move(int x, int y, int rate)
    {
        Console.WriteLine($"Moving to position {x}, {y}, at a rate of {rate}");
    }
}

interface IAnimalBehavior
{

}
interface IPreditor : IAnimalBehavior
{
    void Hunt();
}
class Preditor : IPreditor
{
    public void Hunt()
    {
        Console.WriteLine("Preditor Attacking");
    }
}
interface IPrey : IAnimalBehavior
{
    void Evade();

}
class Prey : IPrey
{
    public void Evade()
    {
        Console.WriteLine($"Prey is Evading");
    }
}



class Animal : IMovable, IAnimalBehavior
{
    private string _animalName;
    private IMovable _movementType;
    private IAnimalBehavior _animalBehavior;

    public Animal(IMovable movementType, IAnimalBehavior behavior)
    {
        _animalName = "unknown";
        _movementType = movementType;
        _animalBehavior = behavior;

    }
    public void Move(int x, int y, int rate)
    {
        Console.WriteLine($"Flying to ({x},{y}) at a rate of {rate} ft/sec");
    }
    public void Hunt()
    {
        Console.WriteLine("B");
    }
}


class Fish : IMovable, IAnimalBehavior
{
    private IMovable _movementType;
    private IAnimalBehavior _animalbehavior;
    public Fish(IMovable movementType, IAnimalBehavior behavior)
    {
        _movementType = movementType;
        _animalbehavior = behavior;
    }
    public void Move(int x, int y, int rate)
    {
        Console.WriteLine($"Swimming to {x},{y} at a rate of {rate}");
    }
    public void Evade()
    {
        Console.WriteLine("Fish swimming deeper");
    }
}




class Program
{


    public static void Main()
    {
        IAnimalBehavior preditor = new Preditor();
        IAnimalBehavior prey = new Prey();

        IMovable fly = new Fly();
        IMovable swim = new Swim();

        /*
        Bird eagle = new Bird(fly, preditor);
        eagle.Move(4, 6, 4);
        Bird pigeon = new Bird(fly, prey);
        pigeon.Move(10, 5, 2);
        */
        Fish salmon = new Fish(swim, prey);
        salmon.Move(1, 5, 3);


    }
}