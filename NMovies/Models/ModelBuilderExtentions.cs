using Microsoft.EntityFrameworkCore;
using NMovies.Models;
using System;

namespace NMovies.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Movie>().HasData(
                 new Movie
                 {   Id = 1,
                     Title = "When Harry Met Sally",
                     ReleaseDate = DateTime.Parse("1989-2-12"),
                     Genre = "Romantic Comedy",
                     AverageRating = 5.0m
                 },

                    new Movie
                    {
                        Id = 2,
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        AverageRating = 4.0m
                    },

                    new Movie
                    {
                        Id = 3,
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        AverageRating = 3.0m
                    },

                    new Movie
                    {
                        Id = 4,
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        AverageRating = 4.5m
                    },
                    new Movie
                    {
                        Id = 5,
                        Title = "Dune",
                        ReleaseDate = DateTime.Parse("2021-9-20"),
                        Genre = "Fantasy",
                        AverageRating = 5.0m
                    },
                    new Movie
                    {
                        Id = 6,
                        Title = "Spiderman",
                        ReleaseDate = DateTime.Parse("2021-10-25"),
                        Genre = "Fantasy",
                        AverageRating = 4.0m

                    });

            modelBuilder.Entity<MovieRating>().HasData(
                new MovieRating {MovieRatingId=1, Rating = 4, MovieId = 1, UserId = 1},
                new MovieRating { MovieRatingId = 2, Rating = 5, MovieId = 5, UserId = 1 },
                new MovieRating { MovieRatingId = 3, Rating = 5, MovieId = 1, UserId = 2 },
                new MovieRating { MovieRatingId = 4, Rating = 3, MovieId = 3, UserId = 2 },
                new MovieRating { MovieRatingId = 5, Rating = 2, MovieId = 2, UserId = 1 },
                new MovieRating { MovieRatingId = 6, Rating = 1, MovieId = 4, UserId = 2 }
                );
               
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1 },
                new User { Id = 2,  });
        }
    }
}
