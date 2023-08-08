using System;
using System.Text;
using System.Xml.Serialization;

namespace Bai_67
{
    internal class Program
    {
        static void SapXepMang(int[] A)
        {
            int[] B = new int[A.Length];
            int sizeB = 0;
            int[] C = new int[A.Length];
            int sizeC = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    B[sizeB++] = A[i];
                }
                if (A[i] % 2 != 0)
                {
                    C[sizeC++] = A[i];
                } 
            }
            QuickSort(B, 0, sizeB - 1);
            QuickSort(C, 0, sizeC - 1);
            int posB = 0;
            int posC = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] %2==0)
                {
                    A[i] = B[posB++];
                }
                else
                {
                    A[i] = C[posC++];
                }
            }
            XuatMang(A);
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void XuatMang(int[] A)
        {
            for(int i=0; i < A.Length; i++)
            {
                Console.Write(A[i]+"  ");
            }
            Console.WriteLine();
        }

        static int[] TaoMang(int n)
        {
            int[] A = new int[n];
            Random rand = new Random();
            for(int i = 0; i < n; i++)
            {
                A[i]=rand.Next(-100,101);
            }
            return A;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập n [1,99]: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = TaoMang(n);
            Console.WriteLine("Mảng vừa nhập:");
            XuatMang(A);
            Console.WriteLine("Mảng sau khi sắp xếp theo yêu cầu:");
            SapXepMang(A);
        }
    }
}