using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số thực x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập độ chính xác n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Sau khi làm tròn: " + MoPhongRound(x, n));
        }

        public static double MoPhongRound(double x, int n)
        {
            if (n > 0)
            {
                double temp = Math.Pow(10, n);
                double result = Math.Round(x * temp) / temp;
                return result;
            }
            else if (n == 0)
            {
                return Math.Round(x);
            }
            else if (n < 0)
            {
                double temp = Math.Pow(10, Math.Abs(n));
                double result = Math.Round(x * temp) / temp;
                return result;
            }
            return x;
        }
    }
}
