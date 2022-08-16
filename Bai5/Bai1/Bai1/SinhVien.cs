using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class SinhVien : Nguoi
    {
        public double dtb { get; set; }
        public SinhVien() : base()
        {
            dtb = 0;
        }
        public SinhVien(string a, string b, int c, double d) : base(a, b, c)
        {
            dtb = dtb;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap dtb");
            dtb = double.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,10}", dtb);
        }
    }
}
