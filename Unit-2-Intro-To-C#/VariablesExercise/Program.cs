namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Program");


            Console.Write("Please enter a string: ");
            string string1 = Console.ReadLine();
            Console.WriteLine(string1);

            Console.Write("Please enter a number: ");
            int int1 = int.Parse(Console.ReadLine());
            Console.WriteLine(int1);

            Console.Write("Please enter a number: ");
            float float1 = float.Parse(Console.ReadLine());
            Console.WriteLine(float1 + 0.5);

            Console.Write("Please enter a number: ");
             float1 = float.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            float float2 = float.Parse(Console.ReadLine());
            Console.WriteLine(float1 + float2);

            Console.Write("Please enter a number: ");
            float1 = float.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            float2 = float.Parse(Console.ReadLine());
            Console.WriteLine(float1 * float2);

            Console.Write("Please enter a number: ");
            int1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            int int2 = int.Parse(Console.ReadLine());
            Console.WriteLine(int1 / int2);

            Console.Write("Please enter a boolean: ");
            bool bool1 = bool.Parse(Console.ReadLine());
            Console.WriteLine($"You entered: {bool1}");
            Console.Write($"The opposite of what you entered is: {!bool1}");


            Console.WriteLine("Ending Program");
        }
    }
}
