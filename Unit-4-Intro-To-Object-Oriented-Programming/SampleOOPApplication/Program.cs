namespace SampleOOPApplication
{
    internal class Program
    {

        //Application program will define and manipulate objects
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person aPerson = new Person("John", 78, 250.6, 69, "Male", "Red", "Green");
            Console.WriteLine(aPerson);
        }


    }
}
