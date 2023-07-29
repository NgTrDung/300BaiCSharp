using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương x: ");
            double x = double.Parse(Console.ReadLine());
            double sum = x;
            for (int i = 256; i > 0; i /= 2)
            {
                sum = x + (i / sum);
            }
            sum = Math.Round(sum, 5);
            Console.WriteLine("F = " + sum);
        }
    }
}
