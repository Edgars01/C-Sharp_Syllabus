using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    internal class Employee : Person
    {
        public Employee(string name, string lastName, string address, int id, string jobTitle) : base(name, lastName,
            address, id)

        {
            JobTitle = jobTitle;
        }

        public string JobTitle { get; }

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, lives at {Address}, is {JobTitle} points. ID: {Id}");
        }
    }
}
