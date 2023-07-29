using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập lãi suất: ");
            double lS = double.Parse(Console.ReadLine());
            Console.Write("Nhập tiền vốn: ");
            double tV = double.Parse(Console.ReadLine());
            Console.Write("Nhập thời hạn (năm): ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Lãi suất: {0}%", lS*100);
            Console.WriteLine("Vốn ban đầu: {0}", tV);
            Console.WriteLine("Thời hạn: {0} năm", y);

            Console.WriteLine("{0,3}   {1,7}","Năm","Vốn");
            for (int i = 1; i <= y; i++)
            {
                tV *= 1 + lS;
                Console.WriteLine("{0,3}   {1,7}", i, tV);
            }    
        }
    }
}
