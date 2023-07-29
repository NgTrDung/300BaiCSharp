using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập tử số a:");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mẫu số b:");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("Rút gọn: {0}/{1}",a/UCLN(a,b),b/UCLN(a,b));
        }

        public static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
