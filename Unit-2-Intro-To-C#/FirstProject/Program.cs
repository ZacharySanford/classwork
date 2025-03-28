namespace FirstProject
{

    //This program will ask for three numbers
    //      add them together and display the total

    // Programming solution - Human thinking
    // Identify the detailed steps

    // Ask for the numbers one at a time
    // Write down each number as it's given
    // Add the numbers together to create a sum/total
    // Tell the requester the total (display)

    // Now that we have the steps in our solution
    // Identify any data/processes you need for the steps

    // 1. A place to write down each number - a variable in a program
    // 2. A place to hold the sum/total - a variable in a program/expression to add
    // 3. A way to ask for the numbers - a method in a program (object.method())
    // 4. A way to receive the numbers - a method in a program (object.method())
    // 5. A way to report the sum/total - a method in a program (object.method())

    // Place the steps in order and provide more detail if necessary if needed to solve the problem
    // 1. Ask for the numbers one at a time
    //      a. Tell whatever is giving us the numbers to give me the first number
    //      b. Receive the first number from sender
    //      c. Write down the number as it's given
    //      Repeat  two more times
    // 2. Add the numbers together to create a sum/total
    //      a. Add the first number
    //      b. Add the second number
    //      c. Add the third number
    //      d. Store the number
    // 3. Share the sum
    
    /*
     * To define a variable: data-type name = initial value;
     * 
     * 
     * Commonly used data types in C#:
     * 
     *  int     - Numeric data that is a whole nuimber between +/- 2 billion
     *  long    - A whole number greater than +/- 2 billion
     *  double  - Numberic value with decimal places
     *  char    - a single alpha-numeric character
     *  string  - a series of alpha-numeric characters (words or sentence)
     *  bool    - true or false value for conditions
     *  
     *  
     *  examples:   10 - int (or long)
     *              1.0 - double
     *              'a' - char 
     *              "some words" - string 
     *              
     *  variable names in C# are usually spelled in camelCase
     *  PascalCase 
     * 
     * **************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Starting Program ---");

            Console.Write("Please enter a number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter a second number:");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Please enter a third number: ");
            int number3 = int.Parse(Console.ReadLine());
            

            int sum = number1 + number2 + number3;
           
            Console.WriteLine($"{number1} + {number2} + {number3} = {sum}");

            Console.WriteLine("--- Ending Program ---");
        }
    }
}
