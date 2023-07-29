using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Bai_4
{
    internal class TamGiac
    {
        private Canh a, b, c;

        public TamGiac()
        {
        }

        public TamGiac(Canh a, Canh b, Canh c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        internal Canh A { get => a; set => a = value; }
        internal Canh B { get => b; set => b = value; }
        internal Canh C { get => c; set => c = value; }

        public static void NhapDoDai3CanhTamGiac(ref TamGiac ABC)
        {
            Console.Write("Nhập độ dài 3 cạnh tam giác: ");
            string input = Console.ReadLine();

            string[] A = input.Split(' ');

            Canh a = new Canh(double.Parse(A[0]));
            Canh b = new Canh(double.Parse(A[1]));
            Canh c = new Canh(double.Parse(A[2]));

            ABC = new TamGiac(a,b,c);
        }

        public static void LoaiTamGiac(TamGiac ABC)
        {
            if (ABC.a.D > 0 && ABC.b.D > 0 && ABC.c.D > 0 && ABC.a.D + ABC.b.D > ABC.c.D && ABC.a.D + ABC.c.D > ABC.b.D
                && ABC.b.D + ABC.c.D > ABC.a.D)
            {
                int f = 0;
                if (ABC.a.D == ABC.b.D || ABC.b.D == ABC.c.D || ABC.c.D == ABC.a.D)
                {
                    f += 1;
                }
                if (ABC.a.D == ABC.b.D && ABC.b.D == ABC.c.D)
                {
                    f += 1;
                }
                if (Math.Abs(ABC.a.D * ABC.a.D + ABC.b.D * ABC.b.D - ABC.c.D * ABC.c.D) < Math.E ||
                    Math.Abs(ABC.a.D * ABC.a.D + ABC.c.D * ABC.c.D - ABC.b.D * ABC.b.D) < Math.E ||
                    Math.Abs(ABC.b.D * ABC.b.D + ABC.c.D * ABC.c.D - ABC.a.D * ABC.a.D) < Math.E)
                {
                    f += 3;
                }
                switch (f)
                {
                    case 0:
                        Console.WriteLine("Tam giac thuong\n");
                        break;
                    case 1:
                        Console.WriteLine("Tam giac can\n");
                        break;
                    case 2:
                        Console.WriteLine("Tam giac deu\n");
                        break;
                    case 3:
                        Console.WriteLine("Tam giac vuong\n");
                        break;
                    case 4:
                        Console.WriteLine("Tam giac vuong can\n");
                        break;
                    default:
                        break;
                }
                double p = (ABC.a.D + ABC.b.D + ABC.c.D) / 2;
                Console.WriteLine("Dien tich S = {0}\n", Math.Sqrt(p * (p - ABC.a.D) * (p - ABC.b.D) * (p - ABC.c.D)));
            }
            else
            {
                Console.WriteLine("Khong hop le\n");
            }
        }
    }
}
