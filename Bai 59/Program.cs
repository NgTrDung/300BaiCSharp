using System;

class Program
{
    static void Main()
    {
        int n;
        string[] can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
        string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };

        Console.Write("Nhap nam: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} - {1} {2}", n, can[n % 10], chi[n % 12]);
        Console.WriteLine("{0} - {1} {2}", n + 60, can[n % 10], chi[n % 12]);
    }
}
