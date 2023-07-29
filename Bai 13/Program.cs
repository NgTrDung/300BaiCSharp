using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập ngày, tháng, năm: ");
            int d, m, y;
            string str = Console.ReadLine();
            string[] str_in = str.Split(' ');
            d = int.Parse(str_in[0]);
            m = int.Parse(str_in[1]);
            y = int.Parse(str_in[2]);
            if(IsDateValid(d,m,y)==true)
            {
                Console.WriteLine("Hợp lệ");
                int a = (14 - m) / 12;
                int year = y - a;
                int month = m + 12 * a - 2;
                int dayofweek = (d + y + y / 4 - y / 100 + y / 400 + (31 * month) / 12) % 7;
                switch (dayofweek)
                {
                    case 0:
                        Console.WriteLine("Chủ Nhật");
                        break;
                    case 1:
                        Console.WriteLine("Thứ 2");
                        break;
                    case 2:
                        Console.WriteLine("Thứ 3");
                        break;
                    case 3:
                        Console.WriteLine("Thứ 4");
                        break;
                    case 4:
                        Console.WriteLine("Thứ 5");
                        break;
                    case 5:
                        Console.WriteLine("Thứ 6");
                        break;
                    case 6:
                        Console.WriteLine("Thứ 7");
                        break;
                    default:
                        break;
                }
            } 
            else
            {
                Console.WriteLine("Không hợp lệ");
            }    
        }

        public static bool IsDateValid(int day, int month, int year)
        {
            // Kiểm tra giá trị hợp lệ của ngày, tháng và năm
            if (year < 1 || month < 1 || month > 12 || day < 1)
                return false;

            // Kiểm tra số ngày hợp lệ trong tháng
            int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Xử lý năm nhuận (nếu là năm nhuận, tháng 2 có 29 ngày)
            if (IsLeapYear(year))
                daysInMonth[1] = 29;

            // Kiểm tra số ngày hợp lệ trong tháng
            if (day > daysInMonth[month - 1])
                return false;

            return true;
        }

        public static bool IsLeapYear(int year)
        {
            // Kiểm tra năm có phải là năm nhuận hay không
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

    }
}
