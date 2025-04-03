using System.Security.Cryptography.X509Certificates;

namespace NumberAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool breakOut = false;

            Console.WriteLine("Start Program");

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine().Trim(); // Initializing User's name. Trimming white space. 

            userName = CapitalizeName(userName);

            while (!breakOut)
            {
                Console.Write($"{userName}, please enter a number between 1 & 100: ");
                int number1 = int.Parse(Console.ReadLine());

                while (number1 < 1 || number1 > 100) //making sure the number is within range
                {
                    Console.Write($"That {number1} was outside of the expected range. {userName}, please enter a number between 1 and 100: ");
                    number1 = int.Parse(Console.ReadLine());
                }

                if (number1 % 2 != 0 && number1 < 60)
                {
                    Console.WriteLine($"{userName}'s number {number1} is: Odd and less than 60.");
                }
                else if (number1 % 2 == 0 && number1 >= 2 && number1 <= 24)
                {
                    Console.WriteLine($"{userName}'s number {number1} is: Even and less than 25.");
                }
                else if (number1 % 2 == 0 && number1 >= 26 && number1 <= 60)
                {
                    Console.WriteLine($"{userName}'s number {number1} is: Even and between 26 and 60 inclusive.");
                }
                else if (number1 % 2 == 0 && number1 > 60)
                {
                    Console.WriteLine($"{userName}'s number {number1} is: Even and greater than 60");
                }
                else if (number1 % 2 == 0 && number1 > 60)
                {
                    Console.WriteLine($"{userName}'s number {number1} is: Odd and greater than 60");
                }

                Console.Write($"{userName}, would you like to enter a new number? ");
                string yesNo = Console.ReadLine().ToLower().Trim();
                if (yesNo == "yes" || yesNo == "y")
                {

                    continue; // Continuing the loop

                }
                else
                {
                    Console.WriteLine($"Thank you for playing {userName}! Goodbye!");
                    breakOut = true; // Breaking out of the loop
                }
                Console.WriteLine("End Program");
            }
        }    
        // Takes the user's name and accesses the first char of the string, capitalizes, then combining with the rest of the string.
        // Forms the new and improved, properly capitalized, user's name. 
       public static string CapitalizeName(string userName)
        {
            return userName.First().ToString().ToUpper() + userName.Substring(1);
        }
        
    }
}
