using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Nguoi
    {
        public string hoTen { get; set; }
        public string diaChi { get; set; }
        public int tuoi { get; set; }
        public Nguoi()
        {
            hoTen = "";
            diaChi = "";
            tuoi = 0;
        }
        public Nguoi(string a, string b, int c)
        {
            hoTen = a;
            diaChi = b;
            tuoi = c;
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.Write("{0,-20}{1,-20}{2,-20}", hoTen, diaChi, tuoi);
        }

    }
}
