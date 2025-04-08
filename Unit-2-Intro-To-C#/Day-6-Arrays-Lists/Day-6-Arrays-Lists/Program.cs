namespace Day_6_Arrays_Lists;

// This program will ask for five numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define an array to hold 5 integers
        int[] numbers = new int[5]; // Array holding 3 numbers
        


        // Define a variable to hold the sum of the numbers
        int sum = 0;

        Console.WriteLine("--- Starting program ---");

        // Normally we process an array from beginning to the end
        //  (from the first element to the last element, one at a time)
        //
        // A for loop will loop through procea process counting as it does so
        // A for loop is an excellent tool for processing an array from start to end. 
        //
        // Standard syntax: for(i = 0; i < array.Length; i++;

        // Index start at 0; loop as long; increment each loop
        //                   as the index 
        //                   is not outside array 
        for (int i = 0; i < numbers.Length; i++) // i = 0, 1, and 2 inside the loop and exit the loop at 3
        {
            Console.Write("Please enter a number: "); // Asking for a number
            numbers[i] = int.Parse(Console.ReadLine()); // Get a string from the keyboard, convert it to int, store in numbers [i]
        }


        // Verify the array received the numbers correctly
        // Go through the array one element at a time and display the element

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element #{i} is {numbers[i]}");
            sum = sum + numbers[i]; // add the current number in the array to sum
        }


        // Add the numbers together create a sum/total
        // Tell the requester the sum/total (display)
        Console.WriteLine($"The sum is: {sum}");


        Console.WriteLine($"The average of the numbers is: {(double) sum / numbers.Length}.");

        // sum / numbers.Length
        // int / int ---> integer arithmetic - divide gives two parts quotient and remainder
        // int     (quotient 2)                             7/3 - quotient = 2 remainder = 1

        // (double) sum / numbers.Length
        // convert sum
        // to double / int ----> floating point arithmetic
        //
        //          / convert int to double (C# does this automatically
        //  double  / double ---> floating point arithmetic
        //          double (2.333333)

        Console.WriteLine("--- Ending program ---");
    }
}