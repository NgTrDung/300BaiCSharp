using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n [1, 99]: ");
        int n = int.Parse(Console.ReadLine());

        // a. Tạo mảng ngẫu nhiên n phần tử trong đoạn [-100, 100]
        List<int> arr = GenerateRandomArray(n);
        Console.WriteLine("Mang vua tao:");
        PrintArray(arr);

        // b. Tính tổng các số nguyên dương có trong mảng
        int sumPositive = CalculateSumPositiveNumbers(arr);
        Console.WriteLine("Tong cac so nguyen duong = " + sumPositive);

        // c. Xóa phần tử có chỉ số p trong mảng
        Console.Write("Nhap p [0, " + (n - 1) + "]: ");
        int p = int.Parse(Console.ReadLine());
        arr = RemoveElementAtIndex(arr, p);
        Console.WriteLine("Mang sau khi xoa phan tu tai chi so " + p + ":");
        PrintArray(arr);
    }

    static List<int> GenerateRandomArray(int n)
    {
        List<int> arr = new List<int>();
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            arr.Add(rand.Next(-100, 101));
        }
        return arr;
    }

    static int CalculateSumPositiveNumbers(List<int> arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            if (num > 0)
            {
                sum += num;
            }
        }
        return sum;
    }

    static List<int> RemoveElementAtIndex(List<int> arr, int index)
    {
        if (index >= 0 && index < arr.Count)
        {
            arr.RemoveAt(index);
        }
        return arr;
    }

    static void PrintArray(List<int> arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
