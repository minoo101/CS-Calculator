using System.IO;
using System;

class Calculator
{
    static void Main()
    {
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to select an operation
        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        // Read the user's choice
        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        // Perform the selected operation based on the user's choice
        switch (choice)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        // Display the result
        Console.WriteLine("The result is: " + result);
    }
}