using System;
using System.Collections.Generic;

namespace MovieListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Movie Mania!");
            Console.WriteLine();
            Console.WriteLine("There are 10 movies in this list.");

            List<Movie> listMovies = new List<Movie>
            {
                new Movie("Anime","Up"),
                new Movie("Anime", "Black Clover"),
                new Movie("Anime","One Piece"),
                new Movie("Anime", "Dragon Ball Z"),
                new Movie("Sci-Fi", "Star Trek"),
                new Movie("Sci-Fi", "Anna"),
                new Movie("Drama", "Eagle Eye"),
                new Movie("Drama", "Waiting to Exhale"),
                new Movie("Thriller", "Redemption"),
                new Movie("Thriller", "Unstoppable")
            };

            bool runProgram = true;
            string category = "";
            while (runProgram)
            {
                Console.WriteLine("What category are you interested in?");
                Console.WriteLine();
                Console.WriteLine("Anime, Drama, Thriller or Sci-Fi");
                category = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        if (category != null)
                        {

                            break;
                        }
                    } 
                    catch (Exception e)
                    {
                        Console.WriteLine("That was not a valid choice");
                    }
                   
                }

                foreach (Movie movie in listMovies)
                {
                    //Console.WriteLine(movie.Category);
                    // Console.WriteLine(category);
                    if (movie.Category == category)
                    {
                        Console.WriteLine(movie.Title);
                    } 
                    

                }

                Console.WriteLine("Would you like to continue? y/n");
                while (true)
                {
                    string result = Console.ReadLine();
                    if (result == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (result == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a y/n");
                    }
                }
            }

        }
    }
}
