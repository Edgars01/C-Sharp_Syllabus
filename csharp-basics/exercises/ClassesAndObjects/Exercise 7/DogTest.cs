using System;
using System.Collections.Generic;

namespace Exercise_7
{
    internal class DogTest
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Max", "male", "Lady", "Rocky");
            Dog dog2 = new Dog("Rocky", "male", "Molly", "Sam");
            Dog dog3 = new Dog("Sparky", "male");
            Dog dog4 = new Dog("Buster", "male", "Lady", "Sparky");
            Dog dog5 = new Dog("Sam", "male");
            Dog dog6 = new Dog("Lady", "female");
            Dog dog7 = new Dog("Molly", "female");
            Dog dog8 = new Dog("Coco", "female", "Molly", "Buster");

            Console.WriteLine(dog1);
            Console.WriteLine(dog1.HasSameMotherAs(dog4));
            Console.WriteLine(dog1.HasSameMotherAs(dog2));

            List<Dog> Dogs = new List<Dog>(2);
            Dogs.Add(dog1);
            Dogs.Add(dog2);

            foreach (var goodBoy in Dogs)
            {
                goodBoy.ShowDogStats();
            }
        }
    }
}
