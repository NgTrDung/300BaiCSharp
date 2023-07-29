using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Diem
    {
        private double x, y;

        public Diem()
        {
        }

        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public static void NhapToaDoDiem(ref Diem I)
        {
            Console.Write("Nhập tọa độ: ");
            string input = Console.ReadLine();

            string[] a = input.Split(' ');

            double xi = double.Parse(a[0]);
            double yi = double.Parse(a[1]);

            I = new Diem(xi, yi);
        }

        public static double KhoangCachGiua2Diem(Diem a, Diem b)
        {
            return Math.Round(Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)), 2);
        }
    }
}
