using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương n (n < 40): ");
            int n = int.Parse(Console.ReadLine());
            int Fi = 1, Fi1 = 1, Fi2 = 1;
            for (int i = 3; i <= n; ++i)
            {
                Fi = Fi1 + Fi2;
                Fi1 = Fi2;
                Fi2 = Fi;
            }
            Console.WriteLine("Fi({0}) = {1}", n, Fi);
        }
    }
}
