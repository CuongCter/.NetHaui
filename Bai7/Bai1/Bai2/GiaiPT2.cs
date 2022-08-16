using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class GiaiPT2
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public void Nhap(double x, double y, double z)
        {
            a = x;
            b = y;
            c = z;
        }

        public string Giai()
        {
            if (a == 0) return "khong phai pt2";
            else
            {
                double delta = b * b - 4 * a * c;
                if(delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    return "Phuong trinh co nghiem kep x1 = " + x1 + "x2= " + x2;    
                }
                else if(delta == 0)
                {
                    return "phuong trinh co nghiem kep :{0} " + -b / 2 * a;
                }
                else
                {
                    return "phuong trinh vo nghiem";
                }
            }
        }
    }
}
