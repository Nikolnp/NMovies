
//    using Microsoft.AspNetCore.Builder;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//    using System;
//    using System.Linq;
   


//    namespace NMovies.Models
//{
//        public static class SeedData
//        {

//            public static void EnsurePopulated(IApplicationBuilder app)
//        {
//            MovieContext context = app.ApplicationServices
//                .CreateScope().ServiceProvider.GetRequiredService<MovieContext>();
//            if (context.Database.GetPendingMigrations().Any())
//            {
//                context.Database.Migrate();
//            }


//            // Look for any movies.
//            if (!context.Movies.Any())
//            {
//                context.Movies.AddRange(
//                    new Movie
//                    {
//                        Title = "When Harry Met Sally",
//                        ReleaseDate = DateTime.Parse("1989-2-12"),
//                        Genre = "Romantic Comedy",
//                        AverageRating = 5.0m
//                    },

//                    new Movie
//                    {
//                        Title = "Ghostbusters ",
//                        ReleaseDate = DateTime.Parse("1984-3-13"),
//                        Genre = "Comedy",
//                        AverageRating = 4.0m
//                    },

//                    new Movie
//                    {
//                        Title = "Ghostbusters 2",
//                        ReleaseDate = DateTime.Parse("1986-2-23"),
//                        Genre = "Comedy",
//                        AverageRating = 3.0m
//                    },

//                    new Movie
//                    {
//                        Title = "Rio Bravo",
//                        ReleaseDate = DateTime.Parse("1959-4-15"),
//                        Genre = "Western",
//                        AverageRating = 4.5m
//                    },
//                    new Movie
//                    {
//                        Title = "Dune",
//                        ReleaseDate = DateTime.Parse("2021-9-20"),
//                        Genre = "Fantasy",
//                        AverageRating = 5.0m
//                    },
//                    new Movie
//                    {
//                        Title = "Spiderman",
//                        ReleaseDate = DateTime.Parse("2021-10-25"),
//                        Genre = "Fantasy",
//                        AverageRating = 4.0m

//                    }); context.SaveChanges();
//            }
//        }
//    }
//        }
    

