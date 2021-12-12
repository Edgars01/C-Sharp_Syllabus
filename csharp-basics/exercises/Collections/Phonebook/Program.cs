using System;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new PhoneDirectory();
            first.PutNumber("name", "12121212");
            Console.WriteLine(first.GetNumber("name"));
            Console.WriteLine(first.GetNumber("error"));
            Console.ReadKey();
        }
    }
}
