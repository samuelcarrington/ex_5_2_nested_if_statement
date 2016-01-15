using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_2_nested_if_statement
{
    class Program
    {
        static void Main()
        {
            /*5-2 
            Write a program that finds the biggest of three integers, 
            using nested if statements. (Chapter 5, Exercise 3)*/

            Console.WriteLine("Enter three numbers.");
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggerNumber = firstNumber;
            if (secondNumber > firstNumber)
            {
                biggerNumber = secondNumber;
            }
            if (thirdNumber > biggerNumber)
            {
                biggerNumber = thirdNumber;
            }

            Console.WriteLine("The bigger number is: {0}", biggerNumber);
            Console.ReadKey();
        }
    }
