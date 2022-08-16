using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class NhanVien
    {
        public string maNV { get; set; }
        public string hoTen { get; set; }
        public double tien { get; set; }
        public int soNgay { get; set; }
        public void Nhap(string a, string b, double c, int d)
        {
            maNV = a;
            hoTen = b;
            tien = c;
            soNgay = d;
        }
        public double TinhTien()
        {
            double sum = 0;
            if (soNgay < 24)
            {
                sum = soNgay * tien;
            }
            else
            {
                sum = (24 + (soNgay - 24) * 2) * tien;
            }
            return sum;
        }
    }
}
