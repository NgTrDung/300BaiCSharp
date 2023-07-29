using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập độ cao n (số nguyên dương chẵn): ");
            int n = NhapChuan();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= n + i - 1; j++)
                {
                    Console.Write((j < n - i + 1) ? "  " : "* ");
                }    
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= n + i - 1; j++)
                {
                    Console.Write((j == n - i + 1 || j == n + i - 1 || i == n) ? "* " : "  ");
                }    
            }    
        }

        static int NhapChuan()
        {
            int n;
            do
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if(n>0 && n%2==0)
                    {
                        break;
                    }    
                    else
                    {
                        Console.WriteLine("Nhập sai, nhập lại:");
                    }    
                }
                catch
                {
                    Console.WriteLine("Nhập sai, nhập lại:");
                }
            } while (true);
            return n;
        }    
    }
}
