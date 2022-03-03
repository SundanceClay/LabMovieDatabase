using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movie
    {
        private string _title { get; set; }
        private string _category { get; set; }

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public string GetMovieCategory()
        {
            return _category;
        }

        public string GetMovieTitle()
        {
            return _title;
        }

    }
}
