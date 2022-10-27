using DevExpress.Skins;
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
        public static frmPhieuMua formPhieuMua;
        public static frmPhieuNhap formPhieuNhap;
        public static frmTheoDoiDonHang formTheoDoiDonHang;
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

        public static mesPhongBan mesPhongBan;
        public static mesCTThucDon mesCTThucDon;
        public static mesKhachHang mesKhachHang;

        public static String luaChonPB; //Phòng hay Bàn
        public static String actionPB; //Thêm, Cập nhật, Xóa

        public static int soLuong; //Số lượng đặt cho chi tiết thực đơn

        public static KhachHangModel khachHang;

        public static String URL = "https://nth-restaurant-api.herokuapp.com/api/";

        public static int doiSpinEditThanhInt(String a)
        {
            String temp = a;
            if (temp.EndsWith(".")) temp = temp.Substring(0, temp.Length - 1); ;
            return int.Parse(temp);
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
