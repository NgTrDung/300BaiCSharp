using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập a, b, c: ");
            string str = Console.ReadLine();

            string[] str_int = str.Split(' ');
            int a = int.Parse(str_int[0]);
            int b = int.Parse(str_int[1]);
            int c = int.Parse(str_int[2]);
            int t;
            if(a<b)
            {
                t = a;
                a = b;
                b = t;
            }    
            if(b<c)
            {
                t = b;
                b = c;
                c = t;
            }
            if(c<a)
            {
                t = c;
                c = a;
                a = t;
            }
            Console.WriteLine("Chuỗi tăng dần: {0}, {1}, {2}", a.ToString(), b.ToString(), c.ToString());
        }
    }
}
