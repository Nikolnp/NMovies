using System.Collections.Generic;

namespace NMovies.Models
{
    public class User
    {
        public int Id { get; set; }

        public IEnumerable<MovieRating> MovieRatings { get; set; }
    }
}
