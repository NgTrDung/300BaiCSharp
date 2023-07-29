using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương n:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, pnt = 1;
            while (sum + pnt < n)
            {
                sum += pnt;
                Console.Write(pnt + " ");
                pnt++;
                if (sum + pnt < n)
                {
                    Console.Write("+ ");
                }    
            }
            Console.WriteLine("= {0} < {1}", sum, n);
            Console.WriteLine("pnt = {0}", pnt - 1);
        }
    }
}
