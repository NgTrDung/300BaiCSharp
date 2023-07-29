using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương n:");
            int n = int.Parse(Console.ReadLine());
            DemSo(n);
            CuoiCungDauTien(n);
            SoDaoNguoc(n);
        }

        public static void SoDaoNguoc(int n)
        {
            string x = n.ToString();
            char[] arr = x.ToCharArray();
            Array.Reverse(arr);
            string new_x = new string(arr);
            Console.WriteLine("d) Số đảo ngược là: " + int.Parse(new_x).ToString());
        }

        public static void CuoiCungDauTien(int n)
        {
            int temp1 = 0, tempLast = 0, tempFirst = 0;
            int x = n;
            while(x>0)
            {
                int sumTemp = x % 10;
                if(temp1==0)
                {
                    tempLast= sumTemp;
                    temp1++;
                }
                tempFirst = sumTemp;
                x /= 10;
            }    
            Console.WriteLine("b) Chữ số cuối cùng là: "+tempLast);
            Console.WriteLine("c) Chữ số đầu tiên là: " + tempFirst);
        }

        public static void DemSo(int n)
        {
            int cnt = 0;
            int temp = n;
            while(temp>0)
            {
                temp /= 10;
                cnt++;
            }
            Console.WriteLine("a) "+temp + " có {0} chữ số", cnt);
        }
    }
}
