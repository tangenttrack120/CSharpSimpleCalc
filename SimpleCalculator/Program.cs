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
            return x / y;
        }

        static void Main(string[] args)
        {
            double x, y, result;
            
            Console.WriteLine("This is a simple calculator");
            Console.WriteLine("You can do addition, subtraction, multiplication and division");
            Console.WriteLine(
                "Type A for \"Addition\", S for \"Substraction\", M for \"Multiplication\", and D for \"Division\"");
            Console.Write("What operation would you like to do?\n");
            String choice = Console.ReadLine().ToUpper();
            
            Console.Write("Your first number is: ");
            String firstNumber = Console.ReadLine();
            x = Convert.ToDouble(firstNumber);
            Console.Write("Your second number is: ");
            String secondNumber = Console.ReadLine();
            y = Convert.ToDouble(secondNumber);

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

            Console.WriteLine("The result of the operation is: " + result);
        }
    }
}