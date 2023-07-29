using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + " số nguyên tố đầu tiên là:");
            int k = 2, cnt = 0, i;
            while (cnt < n)
            {
                for (i = 2; i * i <= k; i++)
                {
                    if (k % i == 0)
                    {
                        break;
                    }    
                }
                if (i * i > k)
                {
                    Console.Write(k + "{0,3}", " ");
                    cnt++;
                }
                k++;
            }    
            Console.WriteLine();
        }
    }
}
