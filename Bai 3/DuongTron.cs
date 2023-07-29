using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class DuongTron
    {
        private Diem i;
        private double r;

        public DuongTron()
        {
        }

        public DuongTron(Diem i, double r)
        {
            this.i = i;
            this.r = r;
        }

        public double R { get => r; set => r = value; }
        internal Diem I { get => i; set => i = value; }

        public static void NhapDuongTron(ref DuongTron dt)
        {
            Diem I = new Diem();

            Diem.NhapToaDoDiem(ref I);

            Console.Write("Nhập bán kính đường tròn: ");
            double r = double.Parse(Console.ReadLine());

            dt = new DuongTron(I, r);
        }

        public static int NgoaiTrenTrong(DuongTron dt, Diem i)
        {
            double kC = Diem.KhoangCachGiua2Diem(dt.i, i);
            if (kC > dt.R)
            {
                return 0;
            }
            else if (kC == dt.R)
            {
                return 1;
            }    
            return 2;
        }
    }
}
