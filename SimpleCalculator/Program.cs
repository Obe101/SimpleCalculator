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
            Console.WriteLine("What operation do you want to use (Add, Subtract, Multiply, Divide)?");
            string answer = Console.ReadLine();

            Console.Write("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); 

        }

        
    }
}
