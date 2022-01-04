using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("person", "test", "little ave", 8);
            var student1 = new Student("Student", "Scolar", "school district 8", 1, 5);
            var employee1 = new Employee("eployee", "surname", "little st 9", 7, "astrophysicist");
            person1.Display();
            student1.Display();
            employee1.Display();
            Console.ReadKey();
        }
    }
}