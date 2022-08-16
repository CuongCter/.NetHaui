using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class CongNhan : Person
    {
        public string tenCT { get; set; }
        public int heSo { get; set; }
        public CongNhan() : base()
        {
            tenCT = "";
            heSo = 0;
        }
        public CongNhan(string a, string b, int c, string d, int e) : base(a, b, c)
        {
            tenCT = d;
            heSo = e;
        }
        public int ThuNhap()
        {
            int sum = heSo * 850000;
            return sum ;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap ten cong ty:");
            tenCT = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            heSo = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", tenCT, heSo,ThuNhap());
        }
    }
}
