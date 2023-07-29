using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TamGiac ABC = new TamGiac();

            TamGiac.NhapDoDai3CanhTamGiac(ref ABC);

            TamGiac.LoaiTamGiac(ABC);
        }
    }
}
