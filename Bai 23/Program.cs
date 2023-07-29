using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương n:");
            int n = int.Parse(Console.ReadLine());
            int sum,j;
            for (int i = 1; i < n; i++)
            {
                for (sum = 0, j = 1; sum <= i && j <= i / 2; j++)
                {
                    if(i%j==0)
                    {
                        sum += j;
                    }    
                }    
                if(sum==i)
                {
                    Console.Write(i + "  ");
                }    
            }
            Console.WriteLine();
        }
    }
}
