using System;

namespace ClassDeconstruction;

class Program{

    public static void Main(){

        Planet Earth = new Planet("Earth", 6371, 1, 150_980_000);
        Planet Venus = new Planet("Venus", 6052, 0, 108_930_000);

        (string name, int moon_count) = Earth;
        Console.WriteLine($"{name}: {moon_count}");
        
        (name, moon_count, int distance) = Venus;
        Console.WriteLine($"{name}: {moon_count}, Distance {distance}");
        
    }


    public class Planet{
        public string Name{get; set;}
        public int Radius{get; set;}
        public int MoonCount{get; set;}
        public int DistanceFromSunKm{get; set;}

        public Planet(string n, int r, int moons, int distance){
            Name = n;
            Radius = r;
            MoonCount = moons;
            DistanceFromSunKm = distance;
        }
        public void Deconstruct(out string name, out int moons){
            name = Name;
            moons = MoonCount;
        }
        public void Deconstruct(out string name, out int moons, out int distance){
            name = Name;
            moons = MoonCount;
            distance = DistanceFromSunKm;
        }
        

    }
}