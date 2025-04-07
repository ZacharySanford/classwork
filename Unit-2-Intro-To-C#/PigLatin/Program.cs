namespace PigLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Program");
            bool breakOut = false;
            
            while (!breakOut)
            {
                Console.Write("Please enter a word: ");
                string igPay = Console.ReadLine().ToLower().Trim();
                Console.WriteLine($"You entered {igPay}.");

                if(igPay.Substring(0,1) == "a" || igPay.Substring(0,1) == "e" || igPay.Substring(0, 1) == "i" || igPay.Substring(0, 1) == "o" || igPay.Substring(0, 1) == "u")
                {
                    Console.WriteLine($"The Pig Latin would be {igPay}way");
                }else






                    Console.WriteLine("Would you like to enter another word? ");
                string ontinueCay = Console.ReadLine().ToLower().Trim();

                if(ontinueCay == "yes" || ontinueCay == "y")
                {
                    continue;
                } else
                {
                    breakOut = true;
                }

            }
            Console.WriteLine("End Program");
        }
    }
}
