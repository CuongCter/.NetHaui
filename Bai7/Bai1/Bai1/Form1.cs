using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        List<NhanVien> dsnv = new List<NhanVien>();
        int row;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            string ma = txtMaNV.Text;
            string hoTen = txtHoTen.Text;
            double luongNgay = double.Parse(txtTienLuong.Text);
            int soNL = int.Parse(txtSoNgay.Text);
            nv.Nhap(ma, hoTen, luongNgay, soNL);
            dsnv.Add(nv);
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(var pt in dsnv)
            {
                row = listView1.Items.Count;
                listView1.Items.Add(pt.maNV);
                listView1.Items[row].SubItems.Add(pt.hoTen);
                listView1.Items[row].SubItems.Add(pt.tien.ToString());
                listView1.Items[row].SubItems.Add(pt.soNgay.ToString());
                listView1.Items[row].SubItems.Add(pt.TinhTien().ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(row);
            dsnv.RemoveAt(row);
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            row = e.ItemIndex;
            txtMaNV.Text = listView1.Items[row].SubItems[0].Text;
            txtHoTen.Text = listView1.Items[row].SubItems[1].Text;
            txtTienLuong.Text = listView1.Items[row].SubItems[2].Text;
            txtSoNgay.Text = listView1.Items[row].SubItems[3].Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
