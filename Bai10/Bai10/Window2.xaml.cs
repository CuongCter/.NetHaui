using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Bai10.Models;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Linq;
namespace Bai10
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            QLBanHangContext db = new QLBanHangContext();
            var query = from p in db.SanPhams
                        join k in db.LoaiSanPhams
                        on p.MaLoai equals k.MaLoai
                        where p.MaLoai == "02"
                        select new
                        {
                            p.MaSp,
                            p.TenSp,
                            k.TenLoai,
                            p.DonGia,
                            p.SoLuong,
                            ThanhTien = p.DonGia * p.SoLuong
                        };
            dgvThongKe.ItemsSource = query.ToList();
        }
    }
}
