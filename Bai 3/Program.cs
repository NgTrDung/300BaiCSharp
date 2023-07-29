using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DuongTron dt = new DuongTron();
            DuongTron.NhapDuongTron(ref dt);
            Diem i = new Diem();
            Diem.NhapToaDoDiem(ref i);

            if (DuongTron.NgoaiTrenTrong(dt, i) == 0)
            {
                Console.WriteLine("Điểm nằm ngoài đường tròn");
            }
            else if (DuongTron.NgoaiTrenTrong(dt, i) == 1)
            {
                Console.WriteLine("Điểm nằm trên đường tròn");
            }    
            else
            {
                Console.WriteLine("Điểm nằm trong đường tròn");
            }    
        }
    }
}
