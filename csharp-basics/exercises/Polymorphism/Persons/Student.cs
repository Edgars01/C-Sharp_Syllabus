using System;

namespace Persons
{
    public class Student : Person
    {
        public Student(string name, string lastName, string address, int id, double gpa) : base(name, lastName, address,
            id)

        {
            Gpa = gpa;
        }

        public double Gpa { get; }

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, lives at {Address}, have gpa of {Gpa} points. ID: {Id}");
        }
    }
}
