using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for(int i=3;i<=n;i++)
            {
                sum += (double)Math.Pow(i, 3);
            }
            Console.WriteLine("Vế trái = " + sum);
            Console.WriteLine("Vế phải = {0}", (Math.Pow(n, 2) * Math.Pow(n + 1, 2)) / 4);
        }
    }
}
