using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x, y, z;
            for (x = 1; x < 100 / 5; ++x)
            {
                for (y = 1; y < 100 / 3; ++y)
                {
                    z = 100 - (x + y);
                    if (300 == 15 * x + 9 * y + z)
                    {
                        Console.WriteLine("Trâu đứng: " + x);
                        Console.WriteLine("Trâu nằm: " + y);
                        Console.WriteLine("Trâu già: " + z);
                    }
                }
                Console.WriteLine();
            }    
        }
    }
}
