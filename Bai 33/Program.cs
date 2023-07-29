using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Các số Armstrong có 3 chữ số là:");
            FindArmstrongNumbers(3);

            Console.WriteLine("\nCác số Armstrong có 4 chữ số là:");
            FindArmstrongNumbers(4);
        }

        static void FindArmstrongNumbers(int numDigits)
        {
            int start = (int)Math.Pow(10, numDigits - 1);
            int end = (int)Math.Pow(10, numDigits) - 1;

            for (int number = start; number <= end; number++)
            {
                if (IsArmstrongNumber(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static bool IsArmstrongNumber(int number)
        {
            int sum = 0;
            int temp = number;

            while (temp != 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, (int)Math.Log10(number) + 1);
                temp /= 10;
            }

            return sum == number;
        }
    }
}
