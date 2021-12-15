using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        public static List<Animal> animals = new List<Animal>();

        private static void Main(string[] args)
        {
            Console.WriteLine("1)mouse / 2)cat / 3)zebra / 4)tiger");
            var type = Convert.ToInt32(Console.ReadLine());

            switch (type)
            {
                case 1:
                    var mouse = new Mouse("mouse", "mammal", 2, 0, "basement");
                    var veg = new Vegetable("Vegetable", 2);
                    mouse.Eat(veg);
                    animals.Add(mouse);
                    Console.WriteLine(mouse.MakeSound());
                    break;

                case 2:
                    var cat = new Cat("cat", "feline", 5, 0, "near basement", "unknown");
                    animals.Add(cat);
                    Console.WriteLine(cat.MakeSound());
                    break;

                case 3:
                    var zebra = new Zebra("zebra", "mammal", 120, 0, "zoo");
                    var meat = new Meat("Meat", 5);
                    zebra.Eat(meat);
                    animals.Add(zebra);
                    Console.WriteLine(zebra.MakeSound());
                    break;

                case 4:
                    var tiger = new Tiger("tiger", "feline", 90, 0, "rich people homes");
                    animals.Add(tiger);
                    Console.WriteLine(tiger.MakeSound());
                    break;
            }

            foreach (var animal in animals) Console.WriteLine(animal.ReturnInfo());

            Console.ReadLine();
        }
    }
}