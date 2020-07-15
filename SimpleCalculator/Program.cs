using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What operation do you want to use (Use sign symbol. Ex: +, -, *, or /)?");
            string answer = Console.ReadLine();

            Console.Write("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Calculate sum = new Calculate();

            if (answer.Equals("+"))
            {
                Console.WriteLine(sum.Add(num1, num2));
            }
            else if (answer.Equals("-"))
            {
                Console.WriteLine(sum.Subtract(num1, num2));
            }
            else if (answer.Equals("*"))
            {
                Console.WriteLine(sum.Multiply(num1, num2));
            }
            else if (answer.Equals("/"))
            {
                Console.WriteLine(sum.Divide(num1, num2));
            }
            else
            {
                Console.WriteLine("Invalid operation. Enter a correct sign (+, -, *, or /).");
            }
        }
        
  
    }
}
