using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("Nhập số SIN (Nhập '0' để thoát): ");
                string input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }
                else if (CheckSIN(input) == true)
                {
                    Console.WriteLine("Là số SIN hợp lệ");
                }
                else if (CheckSIN(input) == false)
                {
                    Console.WriteLine("Không là số SIN hợp lệ");
                }    
            } while (true);
  
        }

        public static bool CheckSIN(string sin)
        {
            // Kiểm tra độ dài của SIN
            if (sin.Length != 9)
                return false;

            int checkDigit = int.Parse(sin.Substring(8, 1));
            int s1 = 0;
            int s2 = 0;

            for (int i = 0; i < 8; i++)
            {
                int digit = int.Parse(sin.Substring(i, 1));

                if (i % 2 == 0)
                    s1 += digit;
                else
                {
                    int doubledDigit = digit * 2;
                    s2 += doubledDigit % 10 + doubledDigit / 10;
                }
            }

            int totalWeight = s1 + s2;
            return (totalWeight + checkDigit) % 10 == 0;
        }
    }
}
