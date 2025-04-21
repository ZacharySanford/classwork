namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    /*********************************************************
        //     * Example use of a Dictionary with array/List value
        //     *********************************************************/


            Dictionary<string,List <double>> gradeBook = new();

            // Lets add students and grades until the user indicates they are done
            // Loop until the user satisfies a condition instead of a specific # of times
            // Replace the for-loop with either a while-loop or do-while()
            // Do we want to loop at least once? Yes - do-while loop; No - while loop
            // Is it ok to loop 0 times? Yes - while loop; No - do-while loop
            //
            // In this case we have to ask the user at least once to enter some data
            // How do we want the user to let us know they are done?
            // Create an on/off switch
            // Prompt - ask if they are done

            // Set a condition based on what they tell us
            string userResponse = "";
            double grade = 0;
            string userGrade = "";
            List<double> grades = new();
            do
            {
                // Ask the user for the student name and grade
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
                //Console.Write("Enter grade: ");
                // Because the user might enter a non-numeric grade causing an exception
                // We should handle the exception so the program doesn't end
                //   with a message that will scare the human
                // We can use a try/catch to handle the exception
                // When the user enters a non-numeric grade:
                //      1. ignore it - if we do this
                //                     don't put student data in dictionary
                //      2. Give them another chance
                //      3. Set the value to 0
                //
                try // A statement inside this try block might cause an exception
                { // We need to get multiple grades for each student and store them in a List

                    string whatTheyTyped = "";
                    
                    while (whatTheyTyped != "end") 
                    {
                        Console.Write("Enter grade or end: ");
                    //Get the user input as a string in case we need it later
                    whatTheyTyped  = Console.ReadLine();
                    if (whatTheyTyped == "end")
                        {
                            break; // exit the loop - continue would be OK too
                        }
                    grade = Double.Parse(userGrade); // convert the user input to number
                    grades.Add(grade); // Add the grade entered to the List
                    }
                    // at the end of this look the grades list has all the grades
                }
                catch (FormatException exceptionObject) // if it throws a FormatException ...
                {
                    Console.WriteLine($"The data you entered ({userGrade}) is not a valid number");
                    Console.WriteLine("The data is ignored");
                    // Skip adding the student to the dictionary
                    continue; // skip the rest of the loop processing
                }
                

                // Add the data to our Dictionary only if we have a valid grade
                // Dictionary[key}     = value;
                gradeBook[studentName] = grades; // adding list of grades for the student
                userResponse = "";
                while (userResponse != "y" && userResponse != "n") { 

                    Console.WriteLine("Are you done?");
                    userResponse = Console.ReadLine().ToLower(); 
                    if(userResponse != "y" && userResponse != "n")
                    {

                        Console.WriteLine("Sorry we only accept 'y' or 'n'");
                    }

                }
               

            } while (userResponse == "n");
            
            // Display the entrys in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary
            foreach (KeyValuePair<string, List <double>> anEntry in gradeBook)
            {
                Console.WriteLine(anEntry.Key + " has a grade of " + anEntry.Value);
                foreach (double grade in grades)
            }
            
            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}
