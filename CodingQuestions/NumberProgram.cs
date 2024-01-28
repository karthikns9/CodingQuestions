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

        public static void CountDigits(int num)
        {
            int count = 0;
            while(num > 0)
            {
                count++;
                num = num / 10;
            }

            //string x = to_string(n);
            //return x.length();

            //int digits = Math.Floor(Math.Log10(n) + 1);
            //return digits;
        }

        public static void ReverseNum(int num)
        {
            string reverseNum = string.Empty;
            while(num > 0)
            {
                reverseNum = reverseNum + num % 10;
                num = num / 10;

                //int digit = N % 10;
                //reverse = reverse * 10 + digit;
                //N = N / 10;
            }
        }

        public static void Palindrome(int num)
        {
            int reverseNum = 0;
            int copy = num;
            while(copy > 0)
            {
                reverseNum = reverseNum  * 10 + copy % 10;
                copy = copy / 10;
            }
            if(num == reverseNum)
            {
                Console.Write("Palindrome");
            }
        }

        public static void Amstrong(int num, int digit)
        {
            int copy = num;
            var amstrongNum = 0D;

            while (copy > 0)
            {
                var quotient = copy % 10;
                var cube = Math.Pow(quotient, digit);
                amstrongNum = amstrongNum + cube;
                copy = copy / 10;
            }
            if (num == amstrongNum)
            {
                Console.Write("Amstrong Number");
            }
        }

        public static void PrintAlDivisors(int num)
        {
            int copy = num;

            for (int i = 1; i <= copy; i++)
            {
                if(copy % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool isPrime(int N)
        {
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void GCD(int num1, int num2)
        {
            int ans = 1;
            for (int i = 1; i <= Math.Min(num1, num2); i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    ans = i;
                }
            }
        }
    }
}
