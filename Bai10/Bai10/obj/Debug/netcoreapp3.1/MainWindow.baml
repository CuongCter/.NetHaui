   M S B A M L   `   `   `  ????@  <Bai10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Bai10Bai10  5   	       Bai10.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Bai10     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? .+?5
   
   ?? $??Mã sản phẩm??6   $
??Left=?6&   $??	52,28,0,0q?6A   $	??Top=?6T   ?? 5   
   $??Tên sản phẩm??6   $
??Left=?6'   $??	52,70,0,0q?6B   $	??Top=?6U   ?? 5   
   $??Loại sản phẩm??6   $
??Left=?6(   $??
58,114,0,0q?6C   $	??Top=?6W   ?? 5   
   $??Đơn giá ??6   $
??Left=?6#   $??
66,153,0,0q?6>   $	??Top=?6R   ?? 5   
   $??Số lượng??6   $
??Left=?6#   $??
65,191,0,0q?6>   $	??Top=?6R   ?? 5   
   -   5        $??txtMaSP??5      $
??Left=?6!   $??
212,36,0,0q?6<    ?? TextWrapping$
 Wrap=?6P   $	??Top=?6d   $	??120??6|   ?? 5   
   -   5         ??Name$ txtTenSP??5      $
??Left=?6$   $??
212,74,0,0q?6?   $
 Wrap=?6S   $	??Top=?6g   $	??250??6   ?? 5   
   -   5        $ 	txtDonGia??5      $
??Left=?6%   $??212,157,0,0q?6@   $
 Wrap=?6U   $	??Top=?6i   $	??120??6?   ?? 5   
   -   5        $ 
txtSoLuong??5      $
??Left=?6&   $??212,195,0,0q?6A   $
 Wrap=?6V   $	??Top=?6j   $	??120??6?    J? RenderTransformOrigin$ 0.483,0.069&?6?   ?? 5   
   -   5        $??cboLoai??5      $
??Left=?6"   $??26??6=   $??212,111,0,0q?6I   $	??Top=?6^   $	??188??6v   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid??5      $
??Left=?6%   $	??162??6@   $??
52,222,0,0q?6M   $	??Top=?6a   $	??595??6y      AutoGenerateColumns$ False??6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sản phẩm??6>      
IsReadOnly$
 True??6S   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   ?? *MaSp+6S     5      $ Tên sản phẩm??6?   $
 True??6U   	 6%   ?? *TenSp+6U     5      $ Mã loại sản phẩm??6@   $
 True??6Z   	 6%   ?? *MaLoai+6Z     5      $ Số lượng??6A   $
 True??6S   	 6%   ?? *	SoLuong+6S     5      $ 
Đơn giá??6@   $
 True??6Q   	 6%   ?? *DonGia+6Q     5      $ Thành tiền??6C   $
 True??6W   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6i   	 6%   ?? *	ThanhTien+6i   5      ?? 5   
   -   5        $??btnThem??5       $??Thêm??6   $
??Left=?6/   $??325,395,0,0q?6J   $	??Top=?6_   $??53??6w   $??28??6?   6?   ?? 5   
   -	   5        $??btnSua??5      $??Sửa??6   $
??Left=?6-   $??400,395,0,0q?6H   $	??Top=?6]   $??53??6u   $??28??6?   6?   ?? 5    
   -
   5        $??btnXoa??5       $
??Xóa??6   $
??Left=?6-   $??475,395,0,0q?6H   $	??Top=?6]   $??53??6u   $??28??6?   6?   ?? 5!   
   -   5        $??btnTim??5!      $
??Tìm??6   $
??Left=?6-   $??542,395,0,0q?6H   $	??Top=?6]   $??53??6u   $??28??6?   ?? 5"   
   -   5        $??
btnThongKe??5"   $   $??Thống kê??6   $
??Left=?66   $??607,395,0,0q?6Q   $	??Top=?6f   $ 2.332,0.733&?6~   $??53??6?   $??28??6?   6?   5$      5%      