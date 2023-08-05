using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

namespace Bai_65
{
    internal class Program
    {
        static void XoaTrung(int[] A)
        {
            Console.WriteLine();
            HashSet<int> set = new HashSet<int>(A);
            int[] temp = set.ToArray();
            foreach (int i in temp)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
        }

        static double TBC(int[] A)
        {
            double sum = 0;
            int cnt = 0;
            foreach (int i in A)
            {
                if (i < 0)
                {
                    cnt++;
                    sum += i;
                }
            }
            return sum/cnt;
        }

        static int[] TaoMang(out int n)
        {
            Console.Write("Nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }

        static void Main(string[] args)
        {
            int n;
            int[] A = TaoMang(out n);
            Console.Write("Trung binh cong cac so nguyen am le = {0}", TBC(A));
            XoaTrung(A);
        }
    }
}