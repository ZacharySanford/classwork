namespace StringExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /********************************************************************************************************
             *  Strings in C# are a special data type - they don't work like you think they should
             *  
             *  String literals are enclosed in " "
             *  
             *  A literal is something that says what it is 1 1.24 "Bob"
             *  
             *  String variables sometimes require special processing
             *       you can't use < > to compare strings
             *       Beware: Early versions of C# do not allow use of == with strings
             *
             * C# provides several methods to operate on strings:
             * 
             *       .Equals(string) - compare the string to the left of the . to string inside () for equals
             *       .CompareTo(string - return a number indicating how the first string relates to the second
             *                           returns a negative number if first string is less than the second
             *                           returns a 0 if first string is equal to the second
             *                           returns a positive number if first string is more than the second
             **********************************************************************************************************/

            // if (condition) {
            //  What to do if condition is true
            //}
            // else { 
            //  What to do if condition is false
            // }

            string string1 = "a";
            string string2 = "b";

            if (string1.CompareTo(string2) > 0)
            {
                Console.WriteLine("string1 is greater than string2");
            }else if (string1.CompareTo(string2) < 0)
            {
                Console.WriteLine("string1 is less than string2");
            }else
            {
                Console.WriteLine("string1 equals string2");
            }
        }
    }
}
