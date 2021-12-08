using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string studio, int rating)
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
    }
}

   