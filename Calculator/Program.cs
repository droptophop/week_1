using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var end = false;

            Console.WriteLine("Welcome to my basic calculator!");

            do {
                Console.WriteLine("\n------- Menu -------");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                Console.WriteLine("Press 5 to Exit\n");

                var operand = Console.ReadLine();

                switch(operand) 
                {
                    case "1":
                        // var input1 = Console.ReadLine() as double; // explicit casting with null
                        // var input2 = (double) Console.ReadLine(); // explicit casting with exception

                        var input1 = double.Parse(Console.ReadLine()); // explicit parsing with 0
                        double input2;
                        double.TryParse(Console.ReadLine(), out input2); // explicit parsing boolean exception
                        Add(input1, input2);
                        break;
                    case "2":
                        input1 = double.Parse(Console.ReadLine()); // explicit parsing with 0
                        double.TryParse(Console.ReadLine(), out input2); // explicit parsing boolean exception
                        Sub(input1, input2);
                        break;
                    case "3":
                        input1 = double.Parse(Console.ReadLine()); // explicit parsing with 0
                        double.TryParse(Console.ReadLine(), out input2); // explicit parsing boolean exception
                        Mul(input1, input2);
                        break;
                    case "4":input1 = double.Parse(Console.ReadLine()); // explicit parsing with 0
                        double.TryParse(Console.ReadLine(), out input2); // explicit parsing boolean exception
                        Div(input1, input2);
                        break;
                    case "5":
                        end = true;
                        break;

                }
            } while (!end);
        }

        static void Add(double operand1, double operand2) 
        {
            Console.WriteLine(operand1 + operand2);
        }

        static void Sub(double operand1, double operand2) 
        {
            Console.WriteLine(operand1 - operand2);
        }

        static void Mul(double operand1, double operand2) 
        {
            Console.WriteLine(operand1 * operand2);
        }

        static void Div(double operand1, double operand2) 
        {
            Console.WriteLine(operand1 / operand2);
        }
    }
}
