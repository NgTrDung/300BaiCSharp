using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class main
    {
        static void Main(string[] args)
        {
            // Thiết lập encoding cho Console
            Console.OutputEncoding = Encoding.UTF8;


            Console.Write("Nhập diện tích S: ");
            double S = double.Parse(Console.ReadLine());

            //double V = (4 / 3) * Math.PI * Math.Pow(Math.Sqrt(S / (4 * Math.PI)), 3);

            double V = (4 * Math.PI * Math.Pow(Math.Sqrt(S / (4 * Math.PI)), 3)) / 3;
            Console.WriteLine("Thể tích V: " + Math.Round(V, 6).ToString());
        }
    }
}
