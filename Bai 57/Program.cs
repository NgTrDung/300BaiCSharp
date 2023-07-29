using System;

class Program
{
    static int CountSetBits(int num)
    {
        int count = 0;
        while (num > 0)
        {
            count += num & 1;
            num >>= 1;
        }
        return count;
    }

    static void Main()
    {
        Console.Write("Nhap mot so nguyen: ");
        int n = int.Parse(Console.ReadLine());

        int numSetBits = CountSetBits(n);

        int evenParityBit = numSetBits % 2 == 0 ? 0 : 1;

        Console.WriteLine("Even parity bit = {0}", evenParityBit);
    }
}
