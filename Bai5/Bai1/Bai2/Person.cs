using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Person
    {
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public int nam { get; set; }
        public Person()
        {
            hoTen = "";
            gioiTinh = "";
            nam = 0;
        }
        public Person(string a, string b, int c)
        {
            hoTen = a;
            gioiTinh = b;
            nam = c;
        }
        public virtual void  Input()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            gioiTinh = Console.ReadLine();
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.Write("{0,-20}{1,-20}{2,-20}", hoTen,gioiTinh,nam);
        }

    }

}
