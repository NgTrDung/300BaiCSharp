using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương n:");
            int n = int.Parse(Console.ReadLine());
            int count = 0, sum = 0;
            for(int i=1;i*i<=n;i++)
            {
                if(n%i==0)
                {
                    count++;
                    sum += i;
                    int j = n / i;
                    if(i!=j)
                    {
                        count++;
                        sum += j;
                    }    
                }    
            }
            Console.WriteLine("Số nguyên dương n có {0} ước số. Tổng các ước số " +
                "là {1}", count, sum);
        }
    }
}
