using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập ký tự búa - kéo - bao (b - k - ba): ");
            string x = Console.ReadLine();
            Random rd = new Random();
            int y = rd.Next(1, 3);
            string y_Chu = ChuyenDoi(y);
            Console.WriteLine("Máy chọn: "+y_Chu);
            Console.WriteLine(XuLyThang(x, y_Chu));
        }

        public static string ChuyenDoi(int x)
        {
            if(x==1)
            {
                return "b";
            }    
            else if(x==2)
            {
                return "k";
            }
            return "ba";
        }

        public static string XuLyThang(string x, string y)
        {
            switch(y)
            {
                case "b":
                    if(x=="b")
                    {
                        return "Hòa";
                    }
                    else if (x == "k")
                    {
                        return "Máy thắng";
                    }
                    else if (x == "ba")
                    {
                        return "Người thắng";
                    }
                    break;
                case "k":
                    if (x == "k")
                    {
                        return "Hòa";
                    }
                    else if (x == "ba")
                    {
                        return "Máy thắng";
                    }
                    else if (x == "b")
                    {
                        return "Người thắng";
                    }
                    break;
                case "ba":
                    if (x == "ba")
                    {
                        return "Hòa";
                    }
                    else if (x == "b")
                    {
                        return "Máy thắng";
                    }
                    else if (x == "k")
                    {
                        return "Người thắng";
                    }
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
