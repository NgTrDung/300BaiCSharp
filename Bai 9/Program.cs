using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_9
{
    internal class Program
    {
        public static void NhapSoDo(ref int x)
        {
            Console.Write("Nhập số đo góc của x (phút): ");
            x = int.Parse(Console.ReadLine());
        }

        public static void KetQua(int x)
        {
            var rs = x / 60;
            if ((int)rs > 0 && (int)rs < 90)
            {
                Console.WriteLine("x thuộc góc vuông thứ I");
            }    
            else if((int)rs > 90 && (int)rs < 180)
            {
                Console.WriteLine("x thuộc góc vuông thứ II");
            }
            else if ((int)rs > 180 && (int)rs < 270)
            {
                Console.WriteLine("x thuộc góc vuông thứ III");
            }
            else if ((int)rs > 270 && (int)rs < 360)
            {
                Console.WriteLine("x thuộc góc vuông thứ IV");
            }
            Console.WriteLine("Cos(x) = {0}", Math.Round(Math.Cos((int)rs), 2).ToString());
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 0;
            NhapSoDo(ref x);
            KetQua(x);
        }
    }
}
