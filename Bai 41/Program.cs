using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char[] sign = { '+', '-', '*', '/' };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            for (int m = 0; m < 4; m++)
                            {
                                if (d(d(d(d(d(1, 2, i), 3, j), 4, k), 5, l), 6, m) == 36)
                                {
                                    Console.WriteLine("((((1 {0} 2) {1} 3) {2} 4) {3} 5) {4} 6 = 36", sign[i], sign[j],
                                        sign[k], sign[l], sign[m]);
                                }    
                            }    
                        }    
                    }    
                }    
            }    
        }

        static double d(double x, double y, int d)
        {
            switch(d)
            {
                case 0:
                    return (double)x + y;
                case 1:
                    return (double)x - y;
                case 2:
                    return (double)x * y;
                case 3:
                    return (double)x / y;
            }
            return 0;
        }
    }
}
