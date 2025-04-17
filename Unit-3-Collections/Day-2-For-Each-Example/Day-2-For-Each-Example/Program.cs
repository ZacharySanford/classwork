namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        // Ask the user to enter a sentence
        // (series of words separated by whitespace - space, tab, something you can't see)
        //Display each word in the sentence

        Console.WriteLine("Please enter a sentence");
        string sentence = Console.ReadLine(); // Get what they type and put it in a string

        // .split() will extract parts of a string into an array based on the character inside ()
        string[] splitSentence = sentence.Split(" ");

        // Display each word in the sentence - arrayName.Length returns the number of elements
        for (int i = 0; i < splitSentence.Length; i++)
        {
            // Note: to add 1 to i and use in the string we have to put it in ()
            //        + for a string means concatenate
            //        + for a numeric means add i+1 in the output for Write
            //        (i+1) - () indicates do this first - add 1 to i and then use it in the WriteLine output
            Console.WriteLine(splitSentence[i]);
            Console.WriteLine("Word #: " + (i + 1) + " is: " + splitSentence[1]);
        }

        // for-each loop can also process arrays and Lists
        //
        // Syntax: foreach(datatype variable-name in array-or-list)
        //         datatype is the type of data in the array or list
        //         use the variable name inside the foreach loop to access an element in the array
        //
        // Foreach goes through the array or List from start to end assigning each element to the variable
        //
        // for-loop vs foreach
        //
        // Both can process an array or List from beginning to end
        // for-loop can start and end at any element by setting int i= and changing the condition
        // for-each ALWAYS processes from the beginning to end
        // for-loop 

        foreach (string aWord in splitSentence)
        {
            Console.WriteLine(aWord);
        }


        // Display all the words using a do-while loop
        //
        // do
        // {
        //  loop processing
        // }while(condition) // loop while the condition is true
        //
        // We always do the loop process at least once
        //      because the condition is checked at the end of the loop process

        // Define a variable to keep track of the element in the array/List we are processing
        // We will use it as an index into array or List
        int currentElementNumber = 0;

        do
        {
            Console.WriteLine("Word #: " + (currentElementNumber + 1) + " is: " + splitSentence[currentElementNumber]);
            currentElementNumber++; // increment our index variable to move through the array or list
        }while (currentElementNumber < splitSentence.Length);
        
    }
}