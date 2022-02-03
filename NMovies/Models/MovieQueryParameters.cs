using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NMovies.Models
{
    public class MovieQueryParameters : QueryParameters
    {
        
            public decimal? MinRating { get; set; }
            public decimal? MaxRating { get; set; }

            public string SearchTerm { get; set; }
      

    }
}
