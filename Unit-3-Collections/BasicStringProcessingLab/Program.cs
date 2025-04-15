namespace BasicStringProcessingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start program");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("String Processing");
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.White;
            StringProcessing();

            //Changed ConsoleColor for title because it was cluttered and I like there to be separation.

            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine();
            Console.WriteLine("Word Processing");
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.White;
            WordProcessing();

            Console.WriteLine("End program");
        }

        static void StringProcessing() //Prompt the user to enter a sentence.
                                       //Split the sentence into individual words
                                       //and display each word on its own line
        {
            Console.Write("Please enter a sentence: ");

            string sentence = Console.ReadLine().Trim(); //https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
            string[] splitWords = sentence.Split(' ');
            List<string> words = new List<string>();
            words.AddRange(splitWords);

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine($"{words[i]} ");
            }

                while (AnotherOne())
            {
                StringProcessing();
            }

            return;

        }

        

        static void WordProcessing() //Repeatedly prompt the user to enter a string.
                                     //Store the string in a list and display
                                     //the contents of the list with each element separated by a space.
        {
            List<string> words = new List<string>();

            do
            {
                Console.Write("Enter some text: ");
                words.Add(Console.ReadLine().Trim());
                foreach (string word in words)
                {
                    Console.Write($"{word} ");

                }
                Console.WriteLine();

                
            } while (AnotherOne());

            return;
        }

        static bool AnotherOne() // Took inspiration from Franks input handling. 
        {
            bool toContinue = false;
            string userInput = "";
            bool getInput = true;

            do
            {
                Console.Write("Would you like to continue? ");
                userInput = Console.ReadLine().ToUpper();
                string firstChar = userInput.Substring(0, 1);

                if (firstChar == "Y")
                {
                    getInput = false;
                    toContinue = true;
                }
                else
                {
                    if (firstChar == "N")
                    {
                        getInput = false;
                        toContinue = false;
                    }
                }
            } while (getInput);

            return toContinue;
        }



    }
}
