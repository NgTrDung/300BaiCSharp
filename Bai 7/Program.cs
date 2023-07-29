using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập a, b: ");
            string str = Console.ReadLine();

            string[] str_int = str.Split(' ');

            int a = int.Parse(str_int[0]);
            int b = int.Parse(str_int[1]);

            float x = (float)Math.Round((-(b) / (double)a), 2);
            Console.WriteLine("x = {0}", x.ToString());
        }
    }
}
