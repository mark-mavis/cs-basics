namespace ShootableWeapons;

interface IShootable
{
    string Shoot();
}

class Weapon
{
    public string Name { get; set; }
    
    public Weapon() 
    {
        Name = "Weapon";
    }
    public string Label()
    {
        return $"This is {Name}";
    }
}

class Pistol : Weapon, IShootable
{
    public Pistol()
    {
        Name = "Pistol";
    }
    public string Shoot()
    {
        return "Bang!";
    }
}

class Shotgun : Weapon, IShootable{

    public Shotgun(){
        Name = "Shotgun";
    }
    public string Shoot(){
        return "BOOM";
    }
}

class MachineGun : Weapon, IShootable{
    public MachineGun(){
        Name = "Machine Gun";
    }
    public string Shoot(){
        return "bang bang bang";
    }
}

public class WeaponsTest{
    public static void Run(){
        Weapon[] guns = new Weapon[3]{
        new Pistol(),
        new Shotgun(),
        new MachineGun()
        };
        
        Console.WriteLine("Firing all three guns...");
    
        foreach(IShootable s in guns)
        {
            if (s is Weapon && s is Weapon) Console.WriteLine(s.Shoot());
            
        }
    } 
}
