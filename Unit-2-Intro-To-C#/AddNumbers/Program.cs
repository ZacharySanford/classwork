namespace AddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Program");

            // Ask the user for three numbers one at a time
            // Produce a sum

            int sum = 0;

            //Console.Write("Please enter a number: ");
            //sum += int.Parse(Console.ReadLine());

            //Console.Write("Please enter a number: ");
            //sum += int.Parse(Console.ReadLine());

            //Console.Write("Please enter a number: ");
            //sum += int.Parse(Console.ReadLine());

            //Console.WriteLine(sum);

            // Loop through our process 3 times
            // If you know the number of times you want to loop
            //      Use a for loop
            //
            // Syntax of a for loop:
            //
            //      for (int variable = initial value; variable < # of times to loop; variable++) {
            //      }
            //
            // The for-loop is controlled by the variable defined within it:
            //
            //  1. int variable=initial value - initializes the variable (usually to 0)
            //  2. the condition following the variable definition is tested:
            //      a. if true - perform the process between the {} for the for-loop
            //      b. increment the variable according to the last part of the loop
            //      c. if false - exit the loop after the closing brace }

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter a number: ");
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum is {sum}.");

            Console.WriteLine("End Program");
        }
    }
}
