using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_63
{
    internal class Program
    {
        static int[] TaoMang(int n)
        {
            int[] A = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                A[i] = rand.Next(-100, 100);
            }
            return A;
        }

        static void XuatMang(int[] A)
        {
            Console.WriteLine("a) Xuất mảng:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + "{0,4}", " ");
            }
            Console.WriteLine();
        }

        static void DemDieuKien(int[] A)
        {
            int cnt = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 4 == 0 && (A[i] % 10 == 6))
                {
                    cnt++;
                }    
            }
            Console.WriteLine("b) Có {0} phần tử chia hết cho 4, có tận cùng là 6", cnt);
        }

        static void XuatMangThayGiaTri(int[] A)
        {
            for (int i = 1; i < A.Length; i+=2)
            {
                A[i] *= 2;
            }    
            Console.WriteLine("Mảng sau khi nhân đôi giá trị ở phần tử lẻ là:");
            XuatMang(A);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số lượng phần tử:");
            int n = int.Parse(Console.ReadLine());
            int[] A = TaoMang(n);
            XuatMang(A);
            DemDieuKien(A);
            XuatMangThayGiaTri(A);
        }
    }
}
