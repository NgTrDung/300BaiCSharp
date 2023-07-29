using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số giờ: ");
            int h = int.Parse(Console.ReadLine());
            int week = h / (24 * 7);
            int day = (h % (24 * 7)) / 24;
            int hour = (h % (24 * 7)) % 24;
            Console.WriteLine("Quy đổi thành: {0} tuần, {1} ngày, {2} giờ", week, day, hour);
        }
    }
}
