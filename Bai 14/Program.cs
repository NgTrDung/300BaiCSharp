using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int d, m, y;
            Console.WriteLine("Nhập ngày, tháng, năm: ");
            string str_in=Console.ReadLine();
            string[] str_out = str_in.Split(' ');
            d = int.Parse(str_out[0]);
            m = int.Parse(str_out[1]);
            y = int.Parse(str_out[2]);
            if (KiemTraNhap(d, m, y) == false)
            {
                Console.WriteLine("Nhập sai định dạng ngày, tháng, năm");
            }    
            else
            {
                d = d % DateTime.DaysInMonth(y, m) + 1;
                if (d == 1)
                {
                    m = m % 12 + 1;
                }
                if (m == 1 && d == 1)
                {
                    Console.WriteLine("Ngày mai: {0}/{1}/{2}", d.ToString(), m.ToString(), (y + 1).ToString());
                }    
                else
                {
                    Console.WriteLine("Ngày mai: {0}/{1}/{2}", d.ToString(), m.ToString(), y.ToString());
                }    
            }
            str_out = null;
            Console.WriteLine("Nhập ngày, tháng, năm: ");
            str_in = Console.ReadLine();
            str_out = str_in.Split(' ');
            d = int.Parse(str_out[0]);
            m = int.Parse(str_out[1]);
            y = int.Parse(str_out[2]);
            if (KiemTraNhap(d, m, y) == false)
            {
                Console.WriteLine("Nhập sai định dạng ngày, tháng, năm");
            }
            else
            {
                if (d == 1)
                {
                    if (m == 1)
                    {
                        m = 12;
                        y--;
                    }    
                    else
                    {
                        m--;
                    }
                    d = DateTime.DaysInMonth(y, m);
                }    
                else
                {
                    d--;
                }
                Console.WriteLine("Ngày hôm qua: {0}/{1}/{2}", d.ToString(), m.ToString(), y.ToString());
            }
        }

        public static bool KiemTraNhap(int d, int m, int y)
        {
            if (d < 1 || m < 1 || m > 12 || y < 1 || d > DateTime.DaysInMonth(y, m))
            {
                return false;
            }
            return true;
        }
    }
}
