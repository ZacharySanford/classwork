namespace Day_1_Student_Class_Example
{
    internal class Program
    {
        // This is an application program
        // it instantiates and uses objects to perform processing
        // Every application has exactly one method called Main()
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Student Class example");

            // Instantiate (define) a Student Class object
            // A class is a data type
            // Define an object of a Class like any other variable with a slight difference

            // data-type = initializer; int sum = 0;
        
            // A class is instantiated with the new keyword
            //         is initialized using one of it's constructors 
            // className name = new className(initializers);

            // We need to be sure to have all the data we want to store in our object
            // Before we instantiate the object

            List<int> scores = new List<int>();
            scores.Add(100);
            scores.Add(90);
            scores.Add(80);

            // Instantiate a Student using the data we want to store in the Student object

            Student aStudent = new Student("Frank", scores);

            // Display the Student object we created
            // Console.WriteLine() does not know how to display an object of our class
            Console.WriteLine($"aStudent: {aStudent}");

            // Use the Student Class method to display Student Class object
            //
            // object.method() <--- object oriented programming
            aStudent.ShowStudent();
        }
    }
}
