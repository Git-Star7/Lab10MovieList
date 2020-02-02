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

            Console.WriteLine("Find a category you like and see the list of movies in that category\n");

            bool continueLoop = true;
            while (continueLoop == true)
            {
                Movie.PrintCategoryList(movies);
                Movie.PrintMoviesByType(movies, InputIsInt(movies, GetUserInput("Pick a movie category: ")));

                continueLoop = YesOrNo("\nWould you like to pick another category ? (y/n) : ");
            }
        }
        
        public static int InputIsInt(List<Movie> movies, string pick)
        {
            try
            {
                int intPick = int.Parse(pick) - 1;
                string tryExceptionT = Movie.GetCategoryList(movies)[intPick];
                return intPick;
            }
            catch
            {
                Console.Write($"Invalid selection, pick a number between 1 - {Movie.GetCategoryList(movies).Count}: ");
                return InputIsInt(movies, GetUserInput("Try again "));
            }
        }
        public static bool YesOrNo(string message)
        {
            string userContinue = "";
            while (userContinue != "y" && userContinue != "n")
            {
                Console.Write(message);
                userContinue = Console.ReadLine().ToLower();

                if (userContinue == "n")
                {
                    Console.WriteLine("Okay!!");
                    return false;
                }
            }
            Console.WriteLine();
            return true;
        }
        public static string GetUserInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
