using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NTH_Restaurant_Manager
{
    static class Program
    {
        public static frmMain frmChinh;
        public static frmDangNhap formDangNhap;
        public static frmNhanVien formNhanVien;
        public static frmTaiKhoan formTaiKhoan;
        public static frmTheoDoiDonHang formTheoDoiDonHang;
        public static frmMonAn formMonAn;
        public static frmLoaiMonAn formLoaiMonAn;
        public static frmThayDoiGiaMon formThayDoiGiaMon;
        public static frmPhongBan formPhongBan;
        public static frmChiTietPhong formChiTietPhong;
        public static frmThongKeDoanhThuTheoThang formThongKeDoanhThuTheoThang;

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
