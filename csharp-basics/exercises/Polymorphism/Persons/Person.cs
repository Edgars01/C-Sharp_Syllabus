using System;

namespace Persons
{
    public class Person
    {
        public Person(string name, string lastName, string address, int id)
        {
            FirstName = name;
            LastName = lastName;
            Address = address;
            Id = id;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public string Address { get; }

        public int Id { get; }

        public virtual void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, lives at {Address}. ID: {Id}");
        }
    }
}
