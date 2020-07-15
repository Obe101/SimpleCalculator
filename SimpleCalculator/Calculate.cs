using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Calculate
    {
        public int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int Subtract(int num1, int num2)
        {
            int sum = num1 - num2;
            return sum;
        }

        public int Multiply(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }

        public int Divide(int num1, int num2)
        {
            int sum = num1 / num2;
            return sum;
        }
    }
}
