using System;
using System.Collections.Generic;

namespace Lab10MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("Star Wars V", "Sci-fi"),
                new Movie("The Princess Bride", "Fantasy"),
                new Movie("Goonies", "Comedy"),
                new Movie("Star Trek Wrath of Khan", "Sci-fi"),
                new Movie("The Lego Movie", "Animated"),
                new Movie("Toy Story 4", "Animated"),
                new Movie("Labyrinth", "Fantasy"),
                new Movie("Warcraft", "Fantasy"),
                new Movie("Isn't it Romantic", "Comedy"),
                new Movie("Lord of the Rings", "Fantasy")
            };

            Console.WriteLine("Pick a movie category");
            Movie.PrintCategoryList(movies);
            string input = Console.ReadLine();
            //int input = 0; //get user input
            Movie.PrintMoviesByType(movies, input);

        }

    }
}
