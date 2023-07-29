using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_62
{
    internal class Program
    {
        static int[] TaoMang(int n)
        {
            int[] A = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                A[i] = rand.Next(1, 100);
            }
            return A;
        }

        static void XuatMang(int[] A)
        {
            Console.WriteLine("Xuất Mảng:");
            for(int i=0;i<A.Length; i++)
            {
                Console.Write(A[i]+"{0,2}"," ");
            }
            Console.WriteLine();
        }

        static int TongLeViTriChan(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i += 2)
            {
                if (A[i] % 2 != 0)
                {
                    sum+= A[i];
                }
            }
            return sum;
        }

        static int TongChanViTriLe(int[] A)
        {
            int sum = 0;
            for (int i = 1; i < A.Length; i += 2)
            {
                if (A[i] % 2 == 0)
                {
                    sum += A[i];
                }
            }
            return sum;
        }

        static int UCLN(int a,int b)
        {
            while(b!=0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return Math.Abs(a);
        }

        static void TimCapNguyenToCungNhau(int[] A)
        {
            for (int i = 0; i < A.Length-1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (UCLN(A[i], A[j]) == 1)
                    {
                        Console.WriteLine("({0}, {1})", A[i], A[j]);
                    }    
                }    
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            do
            {
                Console.WriteLine("Nhập n [1, 99]: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 99);
            int[] A = TaoMang(n);
            Console.WriteLine("a)");
            XuatMang(A);
            Console.WriteLine("b)");
            int LeChan = TongLeViTriChan(A);
            int ChanLe = TongChanViTriLe(A);
            if (LeChan == ChanLe)
            {
                Console.WriteLine("Tổng Lẻ ở vi trí Chẵn ({0}) bằng Tổng Chẵn ở vị trí Lẻ ({1})", LeChan, ChanLe);
            }
            else
            {
                Console.WriteLine("Tổng Lẻ ở vi trí Chẵn ({0}) không bằng Tổng Chẵn ở vị trí Lẻ ({1})", LeChan, ChanLe);
            }
            Console.WriteLine("c)");
            TimCapNguyenToCungNhau(A);
        }
    }
}
