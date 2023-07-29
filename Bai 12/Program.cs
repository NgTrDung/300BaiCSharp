using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double a1, b1, c1, a2, b2, c2, x, y;
            Console.WriteLine("Nhập a1, b1, c1: ");
            string str1 = Console.ReadLine();
            string[] str_1 = str1.Split(' ');
            a1= double.Parse(str_1[0]);
            b1= double.Parse(str_1[1]);
            c1= double.Parse(str_1[2]);
            Console.WriteLine("Nhập a2, b2, c2: ");
            str1 = Console.ReadLine();
            str_1 = str1.Split(' ');
            a2 = double.Parse(str_1[0]);
            b2 = double.Parse(str_1[1]);
            c2 = double.Parse(str_1[2]);

            double d = a1 * b2 - a2 * b1;
            double dx = c1 * b2 - c2 * b1;
            double dy = a1 * c2 - a2 * c1;

            if(d==0)
            {
                if (dx != 0 && dy != 0)
                {
                    Console.WriteLine("Vô nghiệm");
                }    
                else
                {
                    Console.WriteLine("Vô định");
                }    
            }   
            else
            {
                x = Math.Round(dx / d, 2);
                y = Math.Round(dy / d, 2);
                Console.WriteLine("x = {0}, y = {1}", x.ToString(), y.ToString());
            }  
            
        }
    }
}
