using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n để kiểm tra:");
            int n = int.Parse(Console.ReadLine());
            if (CheckPrime(n) == true)
            {
                Console.WriteLine("{0} là 1 số nguyên tố", n);
            }
            else
            {
                Console.WriteLine("{0} không phải là số nguyên tố, số nguyên tố nhỏ hơn gần nhất là: {1}", n, NearestPrime(n));
            }
        }

        static int NearestPrime(int n)
        {
            int near = n - 1;
            while (CheckPrime(near) == false)
            {
                near--;
            }
            return near;
        }

        static bool CheckPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }    
            return true;
        }
    }
}
