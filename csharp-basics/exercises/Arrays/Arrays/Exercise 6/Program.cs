using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var randomArray =  CreateRandomArray(10);
            var copiedArray = CopyArray(randomArray);
            randomArray[randomArray.Length - 1] = -7;
            Console.WriteLine(String.Join(" ", randomArray));
            Console.WriteLine(String.Join(" ", copiedArray));
        }

        public static int[] CreateRandomArray(int length)
        {
            int[] randomArray = new int[length];
            Random randomNum = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randomNum.Next(1, 100);
            }
            return randomArray;
        }

        public static int[] CopyArray(int[] arrayToCopy)
        {
            int[] copiedArray = new int[arrayToCopy.Length];
            Array.Copy(arrayToCopy, copiedArray, 10);
            return copiedArray;
        }
    }
}
