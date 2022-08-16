using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            int n;
            Console.WriteLine("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("======Danh sach sinh vien ======");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien thu: {0}", i + 1);
                SinhVien sv = new SinhVien();
                sv.Input();
                dssv.Add(sv);
            }
            Console.WriteLine("=Sinh vien vua nhap=");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-40}", "Ho ten", "diaChi", " tuoi", "DTB");
            foreach (SinhVien item in dssv)
            {
                item.Output();
                
            }
            Console.ReadLine();
        }
    }
}
