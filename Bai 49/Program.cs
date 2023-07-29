using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 1;
            for (double k = 2; k <= n; k++)
            {
                sum = Math.Pow(k + sum, 1 / (k + 1));
            }
            Console.WriteLine("Kết quả: " + sum.ToString());
        }
    }
}
