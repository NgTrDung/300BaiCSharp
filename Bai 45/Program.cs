using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n (n<5): ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= 2 * n - 1; j++)
                {
                    if ((j <= i && j <= 2 * n - i) || (j >= i && j >= 2 * n - i))
                    {
                        Console.Write("{0,2}", j);
                    }    
                    else
                    {
                        Console.Write("  ");
                    }
                }    
            }
            Console.WriteLine();
        }
    }
}
