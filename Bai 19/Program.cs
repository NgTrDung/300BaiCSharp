using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập sô giờ 1:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số phút 1:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số giây 1:");
            int s = int.Parse(Console.ReadLine());
            int sumTemp = h * 3600 + m * 60 + s;

            Console.WriteLine("Nhập sô giờ 2:");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số phút 2:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số giây 2:");
            s = int.Parse(Console.ReadLine());
            sumTemp -= h * 3600 + m * 60 + s;
            if (sumTemp < 0)
            {
                sumTemp = (-1) * sumTemp;
            }
            Console.WriteLine("Khoảng cách giữa 2 khoảng thời gian là:");
            Console.WriteLine("{0}h {1}m {2}s", sumTemp / 3600, (sumTemp % 3600) / 60, (sumTemp % 3600) % 60);
        }
    }
}
