using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Obtain the necessary data for the equation*/
            Console.Write("\nPlease enter the first number and press [enter]:");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("\nPlease enter the second number and press [enter]:");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("\nSelect an operator(+ - * /) you would like to use and press [enter]:");
            string input = Console.ReadLine();
            double result = 0;

            switch (input)
            {
                /*Use the case statements to perform the calculation*/
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

            }
            Console.WriteLine($"\n{num1} {input} {num2} = {result}");

        }
    }
}
