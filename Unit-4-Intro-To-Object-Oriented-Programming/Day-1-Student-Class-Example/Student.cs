using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Student_Class_Example
{
    // internal attribute so we can use the class anywhere
    // public - anyone can use this class
    // class - this is the definition of a C# class
    // Student - name of the class - Class names are in PascalCase

    // A class is a description of an object that is used in object oriented programming
    // A class contains data and methods (class methods)
    // A class is a programmer defined data type (much like int, string, double, List<>)
    // Because it is a PROGRAMMER defined data type, the programmer is responsible for:
    //
    //  the data in the class
    //  the methods that manipulate the class data
    //
    // Class can do whatever a programmer decides it should or shouldn't do

    public class Student
    {
        // Define the data for our class
        // private indicates only members of the class can access the data
        // private implements the Object-Oriented principle of Encapsulation
        // Encapsulation - class should protect the data from outside access
        //                 only methods in the class can access the data
        //
        // Users of the class access the data using methods that are defined in the class
        //
        // Note: the data is defined without an initial value
        //       Class data should be initialized in constructors

        private string studentName;
        private List<int> testScores;


        // Define methods for the class

        // One special method for a class is called a constructor
        // A constructor is responsible for initializing the data in a class
        // (data should never be uninitialized - the starting value needs to be known)
        //
        // A constructor has no return type; not even void
        //
        // 1. it has no return type; not even void
        // 2. it has the same name as the Class
        // 3. it may or may not receive parameters (initializers)
        //      (a constructor with no parameters is called a default constructor)

        // Define a constructor to initialize  our data with values
        //          specified by the user

        public Student(string name, List<int> scores)
        {
            studentName = name;
            testScores = scores;
        }


        // Provide a method to display our data
        // Console.WriteLine() doesn't know how to do it
        public void ShowStudent()
        {
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine("Scores: ");

            foreach (int score in testScores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
