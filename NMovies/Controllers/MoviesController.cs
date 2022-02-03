using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NMovies.Controllers
{
    [Route("ApiA/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieContext _context;
        public MoviesController(MovieContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IActionResult GetAllMovies([FromQuery] MovieQueryParameters queryParameters)
        {
            IQueryable<Movie> movies = _context.Movies;
            IQueryable<MovieRating> ratings = _context.Ratings;
           




                if (!string.IsNullOrEmpty(queryParameters.SearchTerm))
            {
                movies = movies.Where(p => p.Title.ToLower().Contains(queryParameters.SearchTerm.ToLower()));
            }



            if (!string.IsNullOrEmpty(queryParameters.SortBy))
            {
                if (typeof(Movie).GetProperty(queryParameters.SortBy) != null)
                {
                    movies = movies.OrderByCustom(queryParameters.SortBy, queryParameters.SortOrder);
                }
            }

            movies = movies
                .Skip(queryParameters.Size * (queryParameters.Page - 1))
                .Take(queryParameters.Size)
                .OrderBy(p => p.AverageRating);
            ;
            
            return Ok(movies.ToArray().Take(5));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovies( int Id)
        {
           var movie = await _context.Movies.FindAsync(Id);
            if (movie == null) { return NotFound(); }
            
            return Ok(movie);
        }

       

    }

}

