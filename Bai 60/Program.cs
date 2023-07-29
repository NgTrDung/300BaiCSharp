using System;

namespace PerfectShuffle
{
    class Program
    {
        // Hàm để tạo mảng ngẫu nhiên chứa các số nguyên trong đoạn [-100, 100]
        static int[] CreateRandomArray(int n)
        {
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-100, 101);
            }
            return arr;
        }

        // Hàm để trộn hoàn hảo một mảng
        static int[] PerfectShuffle(int[] arr)
        {
            int n = arr.Length;
            int mid = n / 2;
            int[] shuffledArr = new int[n];
            int index = 0;
            for (int i = 0; i < mid; i++)
            {
                shuffledArr[index] = arr[i];
                shuffledArr[index + 1] = arr[i + mid];
                index += 2;
            }
            return shuffledArr;
        }

        // Hàm để kiểm tra xem mảng có trở về như ban đầu sau bao nhiêu lần trộn hoàn hảo
        static int CountPerfectShuffles(int[] arr)
        {
            int[] originalArr = new int[arr.Length];
            Array.Copy(arr, originalArr, arr.Length);
            int cnt = 0;
            do
            {
                arr = PerfectShuffle(arr);
                cnt++;
            } while (!ArraysEqual(arr, originalArr));

            return cnt;
        }

        // Hàm kiểm tra hai mảng có bằng nhau không
        static bool ArraysEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }

        // Hàm chính
        static void Main(string[] args)
        {
            Console.Write("Nhap n (n chan): ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                Console.WriteLine("n phai la so chan.");
            }
            else
            {
                int[] array = CreateRandomArray(n);
                Console.WriteLine("Mang ban dau:");
                Console.WriteLine(string.Join(" ", array));

                int[] shuffledArray = PerfectShuffle(array);
                Console.WriteLine("Mang sau khi tron hoan hao:");
                Console.WriteLine(string.Join(" ", shuffledArray));

                int count = CountPerfectShuffles(array);
                Console.WriteLine($"Can {count} lan shuffle de mang tro ve ban dau.");
            }
        }
    }
}
