using System;
using System.Collections;
using System.Collections.Generic;


namespace IEnumerables
{
    public class DogShelterExamples
    {
        internal class Dog
        {
            public string Name { get; set; }
            public bool IsGood { get; set; }

            public Dog(string name, bool isGood)
            {
                Name = name;
                IsGood = isGood;
            }

            public void GiveTreat(int numberOfTreats)
            {
                Console.WriteLine("Dog: {0} said wuoff {1} times!.", Name, numberOfTreats);
            }
        }

        internal class DogShelter : IEnumerable<Dog>
        {
            public List<Dog> dogs;

            public DogShelter()
            {
                dogs = new List<Dog>()
                {
                    new Dog("Casper", false),
                    new Dog("Sif", true),
                    new Dog("Oreo", false),
                    new Dog("Pixel", false)
                };
            }

            public IEnumerator<Dog> GetEnumerator()
            {
                return dogs.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        public static void Run()
        {
            DogShelter dogShelter = new DogShelter();
            foreach (Dog dog in dogShelter)
            {
                if (dog.IsGood)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }
    }

    
    
}
