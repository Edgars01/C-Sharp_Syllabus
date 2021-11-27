using System;

namespace exercise_06
{
    internal class Program
    {
	static void Main(string[] args)
	{
	int number = 1;
	while (number <= 110)
	{
		for (int counter = 1; counter <= 11; counter++)
		{
		if ((number % 3 == 0) && (number % 5 == 0))
		{
			Console.Write("CozaLoza ");
		}
		else if ((number % 3 == 0) && (number % 7 == 0))
		{
			Console.Write("CozaWoza ");
		}
		else if ((number % 5 == 0) && (number % 7 == 0))
		{
			Console.Write("LozaWoza ");
		}
		else if (number % 3 == 0)
		{
			Console.Write("Coza ");
		}
		else if (number % 5 == 0)
		{
			Console.Write("Loza ");
		}
		else if (number % 7 == 0)
		{
			Console.Write("Woza ");
		}
		else
		{
			Console.Write(number + " ");
		}
		number++;
		}
	Console.WriteLine();
	}
}
}
}
  