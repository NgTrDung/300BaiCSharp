using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số nguyên dương b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("UCLN của {0} và {1} là = {2}", a, b, UCLN(a, b));
            Console.WriteLine("BCNN của {0} và {1} là = {2}", a, b, BCNN(a, b));
        }

        public static int BCNN(int a, int b)
        {
            return (a / UCLN(a, b)) * b;
        }

        public static int UCLN(int a, int b)
        {
            while(b!=0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
