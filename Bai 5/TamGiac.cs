using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class TamGiac
    {
        private Diem a, b, c;

        public TamGiac()
        {
        }

        public TamGiac(Diem a, Diem b, Diem c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        internal Diem A { get => a; set => a = value; }
        internal Diem B { get => b; set => b = value; }
        internal Diem C { get => c; set => c = value; }

        public static void NhapTamGiacABCVaDiemM(ref TamGiac ABC, ref Diem M)
        {
            Console.Write("A(xA;yA)? ");
            string str1 = Console.ReadLine();

            Console.Write("B(xB;yB)? ");
            string str2 = Console.ReadLine();

            Console.Write("C(xC;yC)? ");
            string str3 = Console.ReadLine();

            Console.Write("M(xM;yM)? ");
            string str4 = Console.ReadLine();

            string[] strDiemA = str1.Split(' ');
            string[] strDiemB = str2.Split(' ');
            string[] strDiemC = str3.Split(' ');
            string[] strDiemM = str4.Split(' ');

            Diem A = new Diem(float.Parse(strDiemA[0]), float.Parse(strDiemA[1]));
            Diem B = new Diem(float.Parse(strDiemB[0]), float.Parse(strDiemB[1]));
            Diem C = new Diem(float.Parse(strDiemC[0]), float.Parse(strDiemC[1]));
            
            M = new Diem(float.Parse(strDiemM[0]), float.Parse(strDiemM[1]));
            ABC = new TamGiac(A, B, C);
        }

        public float DoDaiCanh(Diem a, Diem b)
        {
            return (float)(Math.Round(Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2)), 2));
        }

        public float DienTichTamGiac(float f1,float f2, float f3)
        {
            float p = (float)Math.Round((f1 + f2 + f3) / 2, 2);
            return (float)Math.Round(Math.Sqrt(p * (p - f1) * (p - f2) * (p - f3)), 2);
        }

        public static void KiemTraViTri(TamGiac ABC, Diem M)
        {
            float AB = ABC.DoDaiCanh(ABC.A, ABC.B);
            float BC = ABC.DoDaiCanh(ABC.B, ABC.C);
            float CA = ABC.DoDaiCanh(ABC.C, ABC.A);

            float S_ABC = ABC.DienTichTamGiac(AB, BC, CA);

            float AM = ABC.DoDaiCanh(ABC.A, M);
            float BM = ABC.DoDaiCanh(ABC.B, M);
            float CM = ABC.DoDaiCanh(ABC.C, M);

            float S_ABM = ABC.DienTichTamGiac(AB, BM, AM);
            float S_ACM = ABC.DienTichTamGiac(CA, CM, AM);
            float S_BCM = ABC.DienTichTamGiac(BC, CM, BM);

            float S_Tong = S_ABM + S_ACM + S_BCM;

            if (S_Tong == S_ABC)
            {
                Console.WriteLine("Diem M nam trong tam giac");
            }
            else if (S_Tong > S_ABC)
            {
                Console.WriteLine("Diem M nam tren 1 canh tam giac");
            }
            else if (S_ABM == 0 || S_ACM == 0 || S_BCM == 0)
            {
                Console.WriteLine("Diem M nam ben ngoai tam giac");
            }
        }
    }
}
