using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    public  class NumberProgram
    {
        public static void SumOfNumbers(int num)
        {
            int sum = 0;

            while(num > 0)
            {
                int quotient = num / 10;
                int remainder = num % 10;
                sum += remainder;
                num = quotient;
            }
        }
    }
}
