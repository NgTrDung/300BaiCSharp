using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b, c;
            for (a = 1; a < 100; ++a)
            {
                for (b = 1; b < 100; ++b)
                {
                    for (c = 1; c < 100; ++c)
                    {
                        if (a * a + b * b == c * c)
                        {
                            if (b - a == 1 && c - b == 1)
                            {
                                Console.Write("({0}  {1}  {2}): ba so nguyen lien tiep\n", a, b, c);
                            }
                            if (b % 2 == 0 && b - a == 2 && c - b == 2)
                            {
                                Console.Write("({0}  {1}  {2}): ba so chan lien tiep\n", a, b, c);
                            }    
                        }
                    }    
                }    
            }    
        }
    }
}
