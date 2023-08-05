using System;

class Program
{
    static void Main()
    {
        // Yêu cầu a: Tạo mảng ngẫu nhiên và xuất mảng
        int n = 10; // Số phần tử của mảng
        int[] arr = GenerateRandomArray(n, -100, 100);
        Console.WriteLine("Mang ngau nhien:");
        PrintArray(arr);

        // Yêu cầu b: Tìm giá trị nhỏ nhất và lớn nhất của mảng
        int minValue = FindMinValue(arr);
        int maxValue = FindMaxValue(arr);
        Console.WriteLine("\nGia tri nho nhat cua mang: " + minValue);
        Console.WriteLine("Gia tri lon nhat cua mang: " + maxValue);

        // Yêu cầu c: Xóa các phần tử trùng với giá trị lớn nhất, trừ phần tử đầu tiên
        RemoveDuplicates(arr, maxValue);
        Console.WriteLine("\nMang sau khi xoa cac phan tu trung voi gia tri lon nhat, tru phan tu dau tien:");
        PrintArray(arr);
    }

    // Hàm tạo mảng ngẫu nhiên
    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(minValue, maxValue + 1);
        }
        return arr;
    }

    // Hàm xuất mảng
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Hàm tìm giá trị nhỏ nhất của mảng
    static int FindMinValue(int[] arr)
    {
        int minValue = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }
        }
        return minValue;
    }

    // Hàm tìm giá trị lớn nhất của mảng
    static int FindMaxValue(int[] arr)
    {
        int maxValue = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
            }
        }
        return maxValue;
    }

    // Hàm xóa các phần tử trùng với giá trị lớn nhất, trừ phần tử đầu tiên
    static void RemoveDuplicates(int[] arr, int maxValue)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == maxValue && count > 0)
            {
                // Nếu giá trị trùng với giá trị lớn nhất và không phải là phần tử đầu tiên, xóa nó
                for (int j = i; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);
                i--; // Giảm i để xét lại vị trí hiện tại sau khi xóa
            }
            else if (arr[i] == maxValue)
            {
                count++;
            }
        }
    }
}
