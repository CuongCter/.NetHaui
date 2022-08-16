using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bai10.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Bai10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        QLBanHangContext db = new QLBanHangContext();

        private void HienThi()
        {
            var p = from x in db.SanPhams
                    orderby x.DonGia
                    select new
                    {
                        x.MaSp,
                        x.TenSp,
                        x.MaLoai,
                        x.SoLuong,
                        x.DonGia,
                        ThanhTien = x.DonGia * x.SoLuong
                    };
            dataGrid.ItemsSource = p.ToList();
            
        }
        private void HienThiCb()
        {
            var p = from x in db.LoaiSanPhams select x;
            //var p = db.LoaiSanPhams.Select(X => X);
            cboLoai.ItemsSource = p.ToList();
            cboLoai.DisplayMemberPath = "TenLoai";
            cboLoai.SelectedValuePath = "MaLoai";
            cboLoai.SelectedIndex = 0;
        
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThi();
            HienThiCb();
            
        }
        
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMaSP));
            if(query != null)
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại", "Thong bao");
                HienThi();
            }
            else
            {
                SanPham spMoi = new SanPham();
                spMoi.MaSp = txtMaSP.Text;
                spMoi.TenSp = txtTenSP.Text;
                spMoi.DonGia = double.Parse(txtDonGia.Text);
                spMoi.SoLuong = int.Parse(txtSoLuong.Text);
                LoaiSanPham itemSelected = (LoaiSanPham)cboLoai.SelectedItem;
                spMoi.MaLoai = itemSelected.MaLoai;
                db.SanPhams.Add(spMoi);
                db.SaveChanges(); // lưu các thay đổi vào CSDL
                MessageBox.Show("Thêm thành công","Thông báo");
                HienThi();
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            //Xác định 1 sản phẩm cần sửa theo mã
            var spSua = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMaSP.Text));
            if (spSua != null)
            {
                spSua.TenSp = txtTenSP.Text;
                LoaiSanPham a = (LoaiSanPham)cboLoai.SelectedItem;
                spSua.MaLoai = a.MaLoai;
                spSua.DonGia = double.Parse(txtDonGia.Text);
                spSua.SoLuong = int.Parse(txtSoLuong.Text);
                db.SaveChanges();
                MessageBox.Show("Sửa thành công! ", "Thông báo");
                HienThi();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
            }
        }
        //chọn dòng trong dataGrid
        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if(dataGrid.SelectedItem != null)
            {
                try
                {
                    Type t = dataGrid.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMaSP.Text = p[0].GetValue(dataGrid.SelectedValue).ToString();
                    txtTenSP.Text = p[1].GetValue(dataGrid.SelectedValue).ToString();
                    cboLoai.SelectedValue = p[2].GetValue(dataGrid.SelectedValue).ToString();
                    txtSoLuong.Text = p[3].GetValue(dataGrid.SelectedValue).ToString();
                    txtDonGia.Text = p[4].GetValue(dataGrid.SelectedValue).ToString();        
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn hàng" + ex.Message, "Thông báo");
                }
            }
            
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            //Xác định 1 sản phẩm cần xóa theo mã
            var spXoa = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMaSP.Text));
            if(spXoa != null)
            {
                MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muón xóa ?", "Thông báo", MessageBoxButton.YesNo);
                if(rs == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(spXoa);
                    db.SaveChanges();
                    HienThi();
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm này để xóa", "Thông báo");
                }
            }
        }

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
        } 
    }
}
