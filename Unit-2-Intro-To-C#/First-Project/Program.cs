// This is a comment - everything after the "/" is ignored
/*
 *This is a block comment - everything between the slash-asterisk is a comment 
 * 
 *This is useful if you have a lot to say or to deactivate code
 * 
 * 
 * The * at the start of each line is optional
 */


// A namespace identifies a context in which a word is known
// allows the same name to be used in different context to mean different things
namespace First_Project
{

    // Everything in C# is defined in a class
    // a class is a group of related things
    // a class starts with the class keyword
    class Program

        //{} surround blocks of related code aka code-blocks

    { // Start of code for class
        // Every application has a method called Main()
        // Method is a self-contained set of code that performs a function
        // Also known as a function or simply a program
        // A method may return a value and accept data to process
        // Method Signature identifies what the method returns, its name, and what it accepts
        //      return-type name(data-it-accepts)
        // Main() is where every application starts
        // Every application has one and only one Main() method

        // Below Main() is a method that returns void and accepts string[] called args

        // void means it returns nothing
        // static means there can only be one of these in the application

        //  return
        //  type name(data-it-accepts)
        static void Main(string[] args)
        { // Start of the code for Main ()
            // This code will display whatever is between the ("") on the screen

            // Console is an object defined by C# to represent the screen
            // An object has certain behaviors
            // A behavior is something an object can do with data
            // Behaviors are implemented using methods

            // object.method(data) - Object Oriented Programming

            // When you see a . after a name, the name to the left of the dot is probably an object. 
            // name( <-- the name is a method
            // name after the . the name is usually a method
            // object.Method(data-for-the-method-to-process)

            Console.WriteLine("Hello, World!"); // EVERY C# STATEMENT ENDS WITH A ;
        } // End of the code for Main()
    } // End of code for the class
} 
