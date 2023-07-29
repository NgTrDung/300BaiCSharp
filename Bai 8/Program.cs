using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8
{
    internal class Program
    {
        public static void NhapABC(ref int a, ref int b, ref int c)
        {
            Console.Write("Nhập a, b, c: ");
            string str = Console.ReadLine();

            string[] arr_str = str.Split(' ');
            a = int.Parse(arr_str[0]);
            b = int.Parse(arr_str[1]);
            c = int.Parse(arr_str[2]);
            //Console.WriteLine(a.ToString() + b.ToString() + c.ToString());
        }

        public static double Delta(int a, int b, int c)
        {
            return (double)Math.Pow(b, 2) - (double)(4 * a * c);
        }

        public static void Nghiem(int a, int b, int c)
        {
            double delta = Delta(a, b, c);
            double x1 = 0;
            double x2 = 0;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else if (delta == 0)
            {
                x1 = Math.Round((double)-b / (2 * a));
                x2 = x1;
            }
            else
            {
                x1 = Math.Round((double)(-b + Math.Sqrt(delta)) / (2 * a), 2);
                x2 = Math.Round((double)(-b - Math.Sqrt(delta)) / (2 * a), 2);
            }    

            Console.WriteLine("x1 = {0}",x1.ToString());
            Console.WriteLine("x2 = {0}", x2.ToString());
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 0;
            int b = 0;
            int c = 0;
            NhapABC(ref a, ref b, ref c);
            Nghiem(a, b, c);
        }
    }
}
