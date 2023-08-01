using System.Text;

namespace Bai_64
{
    internal class Program
    {

        static void XuatMang(int[] A)
        {
            for(int i=0;i<A.Length;i++)
            {
                Console.Write(A[i]+"    ");
            }
            Console.WriteLine();
        }

        static int[] XoaTrung(int[] A, int n, out int newSize)
        {
            newSize = A.Length;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == n)
                {
                    newSize--;
                }
            }
            int[]rst= new int[newSize];
            int index = 0;
            for(int i=0; i<A.Length; i++)
            {
                if (A[i] != n)
                {
                    rst[index++] = A[i];
                } 
                    
            }
            return rst;
        }

        static int DemLuyThua2(int[] A)
        {
            int cnt = 0;
            for(int i=0; i<A.Length; i++)
            {
                if (CheckLuyThua2(A[i]) == true)
                {
                    cnt++;
                }    
            }
            return cnt;
        }

        static bool CheckLuyThua2(int n)
        {
            if (n % 2 != 0)
            {
                return false;
            }
            if (n == 0)
            {
                return false;
            }
            return (n & (n - 1)) == 0;
        }

        static int[] TaoMang(ref int n)
        {

            Console.WriteLine("Nhập số lượng phần tử trong mảng:");
            n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for(int i= 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int[] A = TaoMang(ref n);
            Console.WriteLine("Trong mảng có {0} phần tử là lũy thừa của 2", DemLuyThua2(A));
            Console.WriteLine("Nhập số x muốn xóa trong mảng:");
            int x = int.Parse(Console.ReadLine());
            int newSize;
            A = XoaTrung(A, x, out newSize);
            Console.WriteLine("Mảng sau khi xóa {0}:", x);
            XuatMang(A);
        }
    }
}