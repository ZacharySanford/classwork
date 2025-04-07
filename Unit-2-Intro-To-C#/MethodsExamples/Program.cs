namespace MethodsExamples
{
    internal class Program
    {

        /****************************************************************************************************************
         *  Demonstrate the use of Programmer defined methods
         *  
         *  A method is a program that processes data and usually returns a value
         *  
         *  A method starts with a method signature identifies the name of the method
         *                                                           what type of data it returns
         *                                                           what data it will accept for processing
         * 
         *  Method signature: return-type Name(data-it-will-accept)
         *  
         *          return-type - the type of data returned from the method
         *                        use void if the method does not return data
         *          
         *          Name() - name of method - method names are in PascalCase
         *                                    PascalCase - the first letter of every word is capitalized
         *                                                         
         *          (data-it-will-accept) - data-type and name of any parameters
         *          
         *          parameter is a piece of data passed/given to a method for its processing
         * 
         **************************************************************************************************************/
        // Every application has one and only one method called Main()
        //
        // Main() method signature
        //
        // static - indicates there can be one of this in an application
        //
        // return-type name(parameters-it-may-accept)
        static void Main(string[] args) // Main is a method that returns nothing and receives a string[] called args
        {
            Console.WriteLine("Hello, World!");

            int mySum = Addem(4, 5); // Send the numbers 4 and 5 to Addem to get the sum
                                     // Addem() will be executed with the numbers 4 and 5
                                     // it will return the sum
                                     // which will be stored in the variable mySum

        } // End of Main()

        // After a method you may define other methods that method can use
        // Helper Methods - help a method to perform a certain task

        // Define a method to receive two numbers and return the sum

        // If a method will be used  by a static method, it must be static itself
        // Any method used by Main() must be static because Main() is static

        // return-type name(parameters)
        static int     Addem(int num1, int num2) // Addem is a method that receives two integers named num1 and num2

        {
            return num1 + num2; // Add the two parameters and return the sum
        }
    }
}
