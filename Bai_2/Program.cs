using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tọa độ điểm A(xA;yA): ");
            string A = Console.ReadLine();

            string[] a = A.Split(' ');

            double A1 = double.Parse(a[0]);
            double A2 = double.Parse(a[1]);

            Console.Write("Nhập tọa độ điểm B(xB;yB): ");
            string B = Console.ReadLine();

            string[] b = B.Split(' ');

            double B1 = double.Parse(b[0]);
            double B2 = double.Parse(b[1]);

            double AB = Math.Sqrt(Math.Pow((B1 - A1), 2) + Math.Pow((B2 - A2), 2));

            Console.WriteLine("|AB| = " + Math.Round(AB, 4).ToString());
        }
    }
}
