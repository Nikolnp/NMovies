using System;
using System.Collections.Generic;

namespace NMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal AverageRating { get; set; }

        public IEnumerable<MovieRating> MovieRatings { get; set; }
    }
}
