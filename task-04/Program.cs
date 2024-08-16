using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_04
{

    using System;

    class Calculator
    {
        static void Main()
        {
            double num1, num2;
            string operation;

            Console.WriteLine("Welcome to the Simple Calculator!");

            // Input first number
            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Input operation
            Console.Write("Enter an operator (+, -, *, /): ");
            operation = Console.ReadLine();

            // Input second number
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Perform calculation based on the operator
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    // Check for division by zero
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}
