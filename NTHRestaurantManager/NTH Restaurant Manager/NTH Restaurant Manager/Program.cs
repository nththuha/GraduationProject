﻿using DevExpress.Skins;
using DevExpress.UserSkins;
using NTH_Restaurant_Manager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NTH_Restaurant_Manager
{
    static class Program
    {
        public static NhanVienModel nhanVienDangDangNhap = new NhanVienModel();
        public static String token;

        public static frmMain frmChinh;
        public static frmDangNhap formDangNhap;
        public static frmNhanVien formNhanVien;
        public static frmTaiKhoan formTaiKhoan;
        public static frmKhachHang formKhachHang;
        public static frmDatBanTruoc formDatBanTruoc;
        public static frmPhieuDatTruoc formPhieuDatTruoc;
        public static frmPhieuMua formPhieuMua;
        public static frmPhieuNhap formPhieuNhap;
        public static frmTheoDoiDonHang formTheoDoiDonHang;
        public static frmTheoDoiDonHangPDT formTheoDoiDonHangPDT;
        public static frmMonAn formMonAn;
        public static frmLoaiMonAn formLoaiMonAn;
        public static frmThayDoiGiaMon formThayDoiGiaMon;
        public static frmNguyenLieu formNguyenLieu;
        public static frmThucDon formThucDon;
        public static frmChitietMonAn formChiTietMonAn;
        public static frmPhongBan formPhongBan;
        public static frmChiTietPhong formChiTietPhong;
        public static frmThongKeDoanhThuTheoThang formThongKeDoanhThuTheoThang;
        public static frmThongKeLoiNhuanTheoThang formThongKeLoiNhuanTheoThang;
        public static frmThongKeTienDiCho formThongKeTienDiCho;

        public static mesPhongBan mesPhongBan;
        public static mesCTThucDon mesCTThucDon;
        public static mesKhachHang mesKhachHang;
        public static mesTienCoc mesTienCoc;
        public static mesHuyPhieuDatTruoc mesHuyPhieuDatTruoc;
        public static mesCTPN mesCTPN;
        public static mesThemCTPN mesThemCTPN;
        public static mesKhachHang_HD mesKhachHang_HD;
        public static mesKhacHang_HD_PDT mesKhachHang_HD_PDT;
        public static mesKhachHang_THD mesKhachHang_THD;

        public static String luaChonPB; //Phòng hay Bàn
        public static String actionPB; //Thêm, Cập nhật, Xóa

        public static int soLuong; //Số lượng đặt cho chi tiết thực đơn

        public static KhachHangModel khachHang;

        public static PhieuDatTruocModel pdt;

        public static HoaDonModel hoaDon;

        //public static String URL = "https://nth-restaurant-api.herokuapp.com/api/";
        public static String URL = "http://localhost:8080/api/";

        public static int doiSpinEditThanhInt(String a)
        {
            String temp = a;
            if (temp.EndsWith(".")) temp = temp.Substring(0, temp.Length - 1);
            String[] tam = temp.Split(',');
            String st = "";
            for (int i = 0; i < tam.Length; i++)
            {
                st += tam[i];
            }
            return int.Parse(st);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
