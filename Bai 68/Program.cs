using System;

namespace MinDifference
{
    class Program
    {
        const int MAX = 100;

        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        static void Main(string[] args)
        {
            int[] a = new int[MAX];
            int n, i, j, i1=0, j1=0, k;
            Random random = new Random();

            do
            {
                Console.Write("Nhap n (n chan): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 2 || n % 2 != 0);

            for (i = 0; i < n; ++i)
            {
                a[i] = random.Next(100) + 100;
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            for (k = 0; k < n / 2; ++k)
            {
                int min = 101;
                for (i = k; i < n - k; ++i)
                {
                    for (j = i + 1; j < n - k; ++j)
                    {
                        if (Math.Abs(a[i] - a[j]) < min)
                        {
                            min = Math.Abs(a[i] - a[j]);
                            i1 = i;
                            j1 = j;
                        }
                    }
                }

                if (a[i1] < a[j1])
                    Swap(ref a[i1], ref a[j1]);

                Swap(ref a[i1], ref a[k]);
                Swap(ref a[j1], ref a[n - k - 1]);
            }

            int sum1 = 0;
            int sum2 = 0;

            for (i = 0; i < n / 2; ++i)
            {
                Console.Write(a[i] + " ");
                sum1 += a[i];
            }
            Console.Write(": " + sum1 + "\n");

            for (i = n / 2; i < n; ++i)
            {
                Console.Write(a[i] + " ");
                sum2 += a[i];
            }
            Console.Write(": " + sum2 + "\n");

            Console.WriteLine("Hieu nho nhat = " + (sum1 - sum2));
        }
    }
}
