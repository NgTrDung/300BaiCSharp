using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương n:");
            int n=int.Parse(Console.ReadLine());
            int i = 2;
            while (n>1)
            {
                while(n%i==1)
                {
                    i++;
                }
                n /= i;
                if(n>1)
                {
                    Console.Write("{0}*", i);
                }
                else
                {
                    Console.WriteLine(i);
                }    
            }    
        }
    }
}
