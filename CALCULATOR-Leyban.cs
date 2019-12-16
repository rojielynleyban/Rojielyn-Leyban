using System;

namespace ConsoleApp1
{
    class CalculatorLeyban
    {
        static void Main(string[] args)
        {
            float num1 = 0; float num2 = 0;
            char redo;

            do
            {
                Console.WriteLine("\n\n\t\t------------------------------------------------\n");
                Console.WriteLine("\t\t\t\tCALCULATOR IN C#\r");
                Console.WriteLine("\t\t------------------------------------------------\n");

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Subtract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divide");

                Console.WriteLine("Enter your first number:");
                num1 = Convert.ToSingle(Console.ReadLine());

                Console.Write("What is your option?:\n");

                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine("Enter your second number: ");
                        num2 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine("Enter your second number: ");
                        num2 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine("Enter your second number: ");
                        num2 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "/":
                        Console.WriteLine("Enter your second number: ");
                        num2 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Enter your second number: ");
                        num2 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("ERROR");
                        break;
                }
                Console.Write("\nType E or e to try again: \n");
                redo = char.Parse(Console.ReadLine());
            }
            while (redo == 'E' || redo == 'e');
        }
    }
}
