using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int y, m, dow, d, top, y1, m1;
            Console.WriteLine("Nhập năm: ");
            y = int.Parse(Console.ReadLine());

            //Công thức Zeller tính thứ cho ngày đầu năm (1/1)
            m = 1;
            y1 = y - (14 - m) / 12;
            m1 = m + 12 * ((14 - m) / 12) - 2;
            dow = (1 + y1 + y1 / 4 - y1 / 100 + y1 / 400 + (31 * m1) / 12) % 7;

            //Lặp cho 12 tháng
            for (int i = 1; i < 13; ++i)
            {
                Console.WriteLine("Thang " + i.ToString());
                switch (i)
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
                Console.WriteLine("  S  M  T  W  T  F  S");
                for (d = 0; d < dow; ++d)
                {
                    Console.Write("   ");
                }
                for (d = 1; d <= top; ++d)
                {
                    Console.Write("{0,3}", d.ToString());
                    if ((dow + d) % 7 == 0)
                    {
                        Console.WriteLine();
                    }    
                }

                //Tính lại thứ cho đầu mỗi tháng
                dow = (dow + top) % 7;
                if (dow!=0)
                {
                    Console.WriteLine();
                }    
            }
        }
    }
}
