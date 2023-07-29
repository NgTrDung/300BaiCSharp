using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập điểm chuẩn:");
            double diemChuan = double.Parse(Console.ReadLine());
            double diemThi1 = 0, diemThi2 = 0, diemThi3 = 0;
            int doiTuong = 0;
            string khuVuc = null;
            NhapDiem3MonThi(ref diemThi1, ref diemThi2, ref diemThi3);
            NhapKhuVuc(ref khuVuc);
            NhapDoiTuong(ref doiTuong);
            KetQua(diemChuan, diemThi1, diemThi2, diemThi3, khuVuc, doiTuong);
        }

        public static void KetQua(double diemChuan, double diemThi1, double diemThi2, double diemThi3, string khuVuc, int doiTuong)
        {
            double sum = 0;
            sum += diemThi1 + diemThi2 + diemThi3;
            switch(khuVuc)
            {
                case "A":
                    sum += 2;
                    break;
                case "B":
                    sum += 1;
                    break;
                case "C":
                    sum += 0.5;
                    break;
                default:
                    sum += 0;
                    break;
            }
            switch(doiTuong)
            {
                case 1:
                    sum += 2.5;
                    break;
                case 2:
                    sum += 1.5;
                    break;
                case 3:
                    sum += 1;
                    break;
                default:
                    sum += 0;
                    break;
            }
            if (sum >= diemChuan && diemThi1 != 0 && diemThi2 != 0 && diemThi3 != 0)
            {
                Console.WriteLine("\nĐậu! [{0}]đ",sum);
            }    
            else
            {
                Console.WriteLine("\nRớt! [{0}]đ",sum);
            }    
        }

        public static void NhapDoiTuong(ref int doiTuong)
        {
            Console.WriteLine("Nhập đối tượng (1, 2, 3, 0):");
            doiTuong = int.Parse(Console.ReadLine());
        }

        public static void NhapKhuVuc(ref string khuVuc)
        {
            Console.WriteLine("Nhập khu vực (A, B, C, X):");
            khuVuc = Console.ReadLine();
        }

        public static void NhapDiem3MonThi(ref double diemThi1, ref double diemThi2, ref double diemThi3)
        {
            Console.WriteLine("Nhập điểm 3 môn thi:");
            string inputDiem = Console.ReadLine();
            string[] convertDiem = inputDiem.Split(' ');
            diemThi1 = double.Parse(convertDiem[0]);
            diemThi2 = double.Parse(convertDiem[1]);
            diemThi3 = double.Parse(convertDiem[2]);
        }
    }
}
