   M S B A M L   `   `   `  ????@  <Bai10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Bai10Bai10  5   	       Bai10.Window2   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Bai10     5   	   -   5          ? Title$  Window2??5   	   $	??450??6   $	??800??6&   .??5	      ? .+?5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgvThongKe??5
      $??Center=?6'      AlternatingRowBackground
 ??ح?$	??162??5      $??Center=?6   $	??596??6*      AutoGenerateColumns$ False??66      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sản phẩm??6>      
IsReadOnly$
 True??6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *MaSp+6S     5      $ Tên sản phẩm??6?   $
 True??6U    6%   ?? *TenSp+6U     5      $ Tên loại sản phẩm??6A   $
 True??6\    6%   ?? *	TenLoai+6\     5      $ Số lượng??6A   $
 True??6S    6%   ?? *	SoLuong+6S     5      $ 
Đơn giá??6@   $
 True??6Q    6%   ?? *DonGia+6Q     5      $ Thành tiền??6C   $
 True??6W      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6i    6%   ?? *	ThanhTien+6i   5      5      5      