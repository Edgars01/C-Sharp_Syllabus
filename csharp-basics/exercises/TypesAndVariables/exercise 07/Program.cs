using System;

namespace exercise_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string using Upper and Lower case letters : ");
            string input = Console.ReadLine();
            IsItUpper(input);
        }

        static string IsItUpper(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i])) count++;
            }
            Console.WriteLine($"Count of uppercase letters: {count}");
            return count.ToString();
        }
    }
}
