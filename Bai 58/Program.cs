using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 2 && n < 100)
        {
            bool[] primes = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (primes[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        primes[i] = false;
                    }
                }
            }

            Console.WriteLine("Cac so nguyen to nho hon {0} la:", n);
            for (int i = 2; i <= n; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Vui long nhap n trong khoang 2 den 99.");
        }
    }
}
