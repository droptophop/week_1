using System;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Enter your first name: ");
            // var first = Console.ReadLine(); // lazy, data type is given based on content of ReadLine()
            string firstName = Console.ReadLine(); // lazy, data type is given based on content of ReadLine()
            Console.Clear();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine(); // eager, data type is explicit prior to content of ReadLine()
            Console.Clear();
            Console.WriteLine($"Hello, {firstName} {lastName}!");
            Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");
        }
    }
}
