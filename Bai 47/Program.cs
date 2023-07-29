using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            if (n % 2 == 0)
            {
                for (int i = 2; i <= n; i += 2)
                {
                    sum += i;
                }    
            }    
            else
            {
                for (int i = 1; i <= n; i += 2)
                {
                    sum += i;
                }
            }
            Console.WriteLine("S(n) = " + sum);
        }
    }
}
