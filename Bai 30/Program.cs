using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0,7}  {1,10}      {2,10}  {3,7}", "Celcius", "Fahrenheit", "Fahrenheit", "Celcius");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0,7}  {1,10}      {2,10}  {3,7}", i, CSangF(i), 32 + i, FSangC(32 + i)); 
            }    
        }

        public static double FSangC(int f)
        {
            return Math.Round((double)((f - 32) * 5) / 9, 2);
        }

        public static double CSangF(int c)
        {
            return Math.Round((double)((9 * c) / 5) + 32, 2);
        }
    }
}
