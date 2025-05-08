
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace MovieLab
{

    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Starting program");
            string userCategory = "";
            string userInput = "";
            bool exit = false;
            bool userContinue = true;

            List<Movie> movies = new List<Movie>();

            Movie myNeighborTotoro = new Movie("My Neighbor Totoro", "animated");
            movies.Add(myNeighborTotoro);
            Movie shawshankRedemption = new Movie("The Shawshank Redemption", "drama");
            movies.Add(shawshankRedemption);
            Movie schindlersList = new Movie("Schindler's List", "drama");
            movies.Add(schindlersList);
            Movie insidious = new Movie("Insidious", "horroe");
            movies.Add(insidious);
            Movie theConjuring = new Movie("The Conjuring", "horror");
            movies.Add(theConjuring);
            Movie aNewHope = new Movie("Star Wars Episode IV: A New Hope", "scifi");
            movies.Add(aNewHope);
            Movie alienPredator = new Movie("Alien vs Predator", "scifi");
            movies.Add(alienPredator);
            Movie pokemonTheMovie = new Movie("Pokemon The Movie", "animated");
            movies.Add(pokemonTheMovie);
            Movie yourName = new Movie("Your Name", "animated");
            movies.Add(yourName);
            Movie rememberTheTitans = new Movie("Remember The Titans", "drama");
            movies.Add(rememberTheTitans);

            do
            {
                do
                {
                    Console.WriteLine("Would you like to look at Animated, Drama, Horror, or SciFi?");
                    userCategory = Console.ReadLine().ToLower().Trim();

                    if (userCategory != "animated" && userCategory != "drama" && userCategory != "horror" && userCategory != "scifi")
                    {
                        Console.WriteLine("That input was incorrect. Please enter Animated, Drama, Horror, or SciFi.");

                    }
                    else
                    {
                        break;
                    }
                } while (userCategory != "animated" && userCategory != "drama" && userCategory != "horror" && userCategory != "scifi");

                foreach (Movie movie in movies)
                {
                    if (movie.Category.Equals(userCategory))
                    {
                        Console.WriteLine(movie);
                    }
                }

                do
                {
                    Console.WriteLine("Would you like to search again? Y/N");
                    userInput = Console.ReadLine().ToLower().Trim();
                    if(userInput != "y" && userInput != "n")
                    {
                        Console.WriteLine("That input is invalid. Please enter Y or N.");
                        
                    }
                    else
                    {
                        if(userInput == "n")
                        {
                            userContinue = false;
                            exit = true;
                            break;
                        }
                        else if(userInput == "y")
                        {
                            continue;
                        }
                    }
                } while (userContinue);
            } while (!exit);

            Console.WriteLine("Ending Program");
        }
    }
}
