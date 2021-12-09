using System;
using System.Collections.Generic;

namespace Exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Movie[] array =
            {
                new("Casino Royale", "Eon Productions", "PG13"),
                new("Glass", "Buena Vista International", "test"),
                new("Spider-Man: Into the Spider-Verse", "Columbia Pictures"),
                new("Batman movie"),
                new()
            };
            List<Movie> pgArray = Movie.GetPG(array);

            foreach (var movie in pgArray)
            {
                movie.PrintMovie();
            }

            Console.ReadKey();
        }
    }
}
