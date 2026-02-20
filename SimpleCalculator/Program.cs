using System;

namespace Calculator
{
    class Program
    {
        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            if (y == 0) return 0; // Or handle as an error
            return x / y;
        }

        static void Main(string[] args)
        {
            double x, y, result;
            String choice;
            
            Console.WriteLine("This is a simple calculator");
            Console.WriteLine("You can do addition, subtraction, multiplication and division");
            Console.WriteLine(
                "Type A for \"Addition\", S for \"Substraction\", M for \"Multiplication\", and D for \"Division\"");
            Console.Write("What operation would you like to do?\n");
            while (true)
            {
                // Read input and convert to Uppercase to handle 'a' or 'A'
                choice = Console.ReadLine().ToUpper();

                // Check if the input is one of the valid options
                if (choice == "A" || choice == "S" || choice == "M" || choice == "D")
                {
                    break; // Input is valid, exit the loop
                }

                Console.Write("Invalid choice. Please enter A, S, M, or D: ");
            }
            
            
            Console.Write("Your first number is: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            Console.Write("Your second number is: ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            /* 
            if (!double.TryParse(Console.ReadLine(), out y)) 
            {
                Console.WriteLine("That's not a valid number!");
                return; // loop later
            }
            */


            switch (choice)
            {
                case "A": result = Add(x, y); break;
                case "S": result = Subtract(x, y); break;
                case "M": result = Multiply(x, y); break;
                case "D": result = Divide(x, y); break;
                default:
                    Console.WriteLine("Invalid operation choice");
                    return; // Will be changed by loop for another input later
            }

            /*
            if (choice == "A")
            {
                result = Add(x,y);
            } else if (choice == "S")
            {
                result = Subtract(x, y);
            } else if (choice == "M")
            {
                result = Multiply(x, y);
            } else if (choice == "D")
            {
                result = Divide(x, y);
            }
            else
            {
                Console.WriteLine("Invalid operation choice");
                result = 0;
            }
            */

            Console.WriteLine("The result of the operation is: " + result);
        }
    }
}