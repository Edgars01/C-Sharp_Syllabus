using System;
using System.Collections.Generic;

namespace Exercise_9
{
    internal class Program
    {
        public static bool stop = false;
        public static HashSet<string> myhash1 = new HashSet<string>();

        public static void Main(string[] args)
        {
            do
            {
                OptionsForUser();
            } while (!stop);
        }

        public static void OptionsForUser()
        {
            while (true)
            {
                Console.WriteLine("1) Add 5 string values to HashSet \n2) Display all items \n3) " +
                                  "" + "Remove all values from the set\n 4) Exit\n");
                var oneOfOptions = Convert.ToInt32(Console.ReadLine());
                switch (oneOfOptions)
                {
                    case 1:
                        FirstOption();
                        break;
                    case 2:
                        SecondOption();
                        break;
                    case 3:
                        ThirdOption();
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        continue;
                }

                break;
            }
        }

        public static void FirstOption()
        {
            for (var f = 1; f < 5; f++)
                myhash1.Add($"{f}");
        }

        public static void SecondOption()
        {
            foreach (var b in myhash1) Console.WriteLine(b);
        }

        public static void ThirdOption()
        {
            myhash1.Clear();
        }

        public static void Exit()
        {
            stop = true;
            Environment.Exit(0);
        }
    }
}
