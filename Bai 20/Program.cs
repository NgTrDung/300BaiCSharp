using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bai_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số kW tiêu thụ:");
            int x = int.Parse(Console.ReadLine());
            int sum = 0;
            if (x <= 0)
            {
                Console.WriteLine("Bạn đã nhập sai, kết thúc chương trình");
                return;
            }
            if (x <= 100)
            {
                sum = x * 500;
            }
            else if (x > 100 && x <= 250)
            {
                sum = (x - 100) * 800 + 100 * 500;
            }
            else if (x <= 350)
            {
                sum = 500 * 100 + 800 * (250 - 100) + 1000 * (x - 250);
            }
            else
            {
                sum = 500 * 100 + 800 * (250 - 100) + 1000 * (350 - 250) + 1500 * (x - 350);
            }    
            Console.WriteLine("Chi phí tiền điện: " + sum.ToString());
        }
    }
}
