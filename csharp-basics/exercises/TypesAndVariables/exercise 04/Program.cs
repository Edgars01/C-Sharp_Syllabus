using System;

namespace exercise_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name: ");
            string userName = Console.ReadLine();
            userName = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(userName.ToLower());
            Console.WriteLine("Please Enter Your Year Of Birth: ");
            int userYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("My name is " + userName + " and I was born in " + userYear + ".");
            Console.ReadLine();
        }
    }
}
