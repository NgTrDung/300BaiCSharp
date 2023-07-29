using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap mot so nguyen co dau: ");
        int n = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(n, 2).PadLeft(32, '0'); // Đảm bảo in 32 bit nhị phân
        string hex = n < 0 ? Convert.ToString((uint)n, 16) : n.ToString("X"); // Xử lý số âm và không âm

        Console.WriteLine("{0} = {1}", n, binary);
        Console.WriteLine("Hex: {0}", hex.ToUpper());
    }
}
