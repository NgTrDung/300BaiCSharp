using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập ngày: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tháng: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập năm:");
            int y = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < m; i++)
            {
                switch(i)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        sum += 31;
                        break;
                    case 2:
                        if (DateTime.IsLeapYear(y) == true)
                        {
                            sum += 29;
                        }    
                        else
                        {
                            sum += 28;
                        }
                        break;
                    default:
                        sum += 30;
                        break;
                }    
            }    
            Console.WriteLine("Ngày thứ: " + (sum+d).ToString());
        }
    }
}
