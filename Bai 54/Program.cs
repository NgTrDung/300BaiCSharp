using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập 2 số nguyên dương n, k: ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k (k<n<25) = ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("C(k, n) = {0}", ToHop1(n, k));
            Console.WriteLine("C(n - k, n) = {0}", ToHop2(n, k));
        }

        static double ToHop2(int n, int k)
        {
            return Math.Round(GiaiThua(n) / (GiaiThua(n - k) * GiaiThua(n - (n - k))), 2);
        }

        static double ToHop1(int n,int k)
        {
            return Math.Round(GiaiThua(n) / (GiaiThua(k) * GiaiThua(n - k)), 2);
        }

        static double GiaiThua(int x)
        {
            double rst = 1;
            for(int i=1;i<=x;i++)
            {
                rst *= i;
            }
            return rst;
        }
    }
}
