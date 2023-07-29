using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Xuat(j, i);
                }
                Console.WriteLine(" |");
            }    
        }

        public static void Xuat(int x,int y)
        {
            Console.Write(" | {0} x {1} = {2,2}", x, y, x * y);
        }
    }
}
