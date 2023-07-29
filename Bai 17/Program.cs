using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bai_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int y, m, dow, s, p = 0, i, top = 0, d;
            Console.WriteLine("Nhập năm: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Thứ cho ngày đầu tiên của năm: ");
            dow = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tháng: ");
            m = int.Parse(Console.ReadLine());

            //Ngày đầu tháng m là ngày thứ s trong năm
            s = 0;
            for (i = 1; i <= m; ++i, s += top)
            {
                switch(i)
                {
                    case 4: case 6: case 9: case 11:
                        top = 30;
                        break;
                    case 2:
                        if (DateTime.IsLeapYear(y) == true)
                        {
                            top = 29;
                        }    
                        else
                        {
                            top = 28;
                        }
                        break;
                    default:
                        top = 31;
                        break;
                }
            }

            //top hiện là số ngày của tháng m, vì vậy s phải trừ bớt top
            s -= top;

            //Thứ tự người trực p vào đầu tháng m
            for (p = 0, i = dow; i < s + dow; ++i)
            {
                //Có 5 người trực và Chủ Nhật không trực
                if (i % 7 != 0)
                {
                    p = (p + 1) % 5;
                }
            }

            //Thứ dow của ngày đầu tháng m
            dow = i % 7;
            Console.WriteLine("    Sun    Mon    Tue    Wes    Thu    Fri    Sat");
            for (d = 0; d < dow; ++d)
            {
                Console.Write("{0,7}", ' '.ToString());
            }
            char[] P = { 'A', 'B', 'C', 'D', 'E' };
            int PI = 0;
            for (d = 1; d <= top; ++d)
            {
                Console.Write("{0,3}".ToString(), d.ToString());
                if (((dow + d - 1) % 7) != 0)
                {
                    Console.Write(" [{0}]".ToString(), P[PI].ToString());
                    PI = (PI + 1) % 5;
                }
                else
                {
                    Console.Write(" [ ]".ToString());
                }

                if ((dow + d) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            if ((dow + top) % 7 != 0)
            {
                Console.WriteLine();
            }
        }
    }
}
