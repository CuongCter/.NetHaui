using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CongNhan> dscn = new List<CongNhan>();
            int n;
            Console.Write("Nhap so cong nhan : ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                CongNhan a = new CongNhan();
                Console.WriteLine("Nhap cong nhan thu: {0}", i + 1);
                a.Input();
                dscn.Add(a);
            }
            Console.WriteLine("==Danh sach cong nhan===");

            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", "Hoten", "gioi tinh", "namsinh", "tenCt", "heSo", "Thu nhap");
            foreach(CongNhan item in dscn)
            {
                item.Output();
            }
            int max = 0;
            foreach(CongNhan item in dscn)
            {
                if (item.heSo > max) max = item.heSo;
            }
            Console.WriteLine("Cong nhan co he so luong cao nhat la: ");
            foreach (CongNhan item in dscn)
            {
                if(item.heSo==max) 
                item.Output();
            }
            Console.ReadLine();
           

        }
    }
}
