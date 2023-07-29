using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TamGiac ABC  = new TamGiac();
            Diem M = new Diem();

            TamGiac.NhapTamGiacABCVaDiemM(ref ABC, ref M);

            TamGiac.KiemTraViTri(ABC, M);
        }
    }
}
