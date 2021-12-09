using System;
using System.Collections.Generic;

namespace Exercise4
{
    public class Movie
    {
        public string _title;
        public string _studio;
        public string _rating;
        public List<Movie> PgRating = new List<Movie>();    

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public Movie(string title)
        {
            _title = title;
            _studio = "Unknown";
            _rating = "PG";
        }

        public Movie()
        {
            _title = "this is for testing purposes only";
            _studio = "TEST";
            _rating = "PG";
        }

        public static List<Movie> GetPG(Movie[] arr)
        {
            List<Movie> pgArray = new List<Movie>();
            foreach (var i in arr)
            {
                if (i._rating.Contains("PG"))
                {
                    pgArray.Add(i);
                }
            }
            return pgArray;
        }

        public void PrintMovie()
        {
            Console.WriteLine($"{_title} from {_studio} is {_rating} rated.");
        }
    }
}

   