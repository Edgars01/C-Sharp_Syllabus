using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = File.ReadAllText("../../lear.txt");
            int lineCount = fileLocation.Split('\n').Length;
            int wrd = 1;
            for (int i = 0; i <= fileLocation.Length - 1; i++) {              
                if (fileLocation[i] == ' ' || fileLocation[i] == '\n' || fileLocation[i] == '\t') {
                    wrd++;
                }         
            }
            Console.WriteLine($"Lines = {lineCount}");
            Console.WriteLine($"Words = {wrd}");
            Console.WriteLine($"Chars = {fileLocation.Length}");
            Console.ReadKey();
        }     
    }
}
