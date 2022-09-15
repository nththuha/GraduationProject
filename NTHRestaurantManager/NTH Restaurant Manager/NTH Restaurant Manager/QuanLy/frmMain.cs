using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NTH_Restaurant_Manager
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btn_DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                Program.formDangNhap = new frmDangNhap();
                Program.formDangNhap.MdiParent = this;
                Program.formDangNhap.Show();
            }
        }

        private void btn_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dangNhap(false);

                Form frm = this.CheckExists(typeof(frmNhanVien));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmTaiKhoan));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmTheoDoiDonHang));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmLoaiMonAn));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmMonAn));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmThayDoiGiaMon));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmPhongBan));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmChiTietPhong));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmThongKeDoanhThuTheoThang));
                if (frm != null) frm.Close();
            }
        }

        public void dangNhap(bool dangNhap) // nếu đăng nhập thì gọi hàm này để cài đặt quyền
        {
            btn_DangNhap.Enabled = !dangNhap;
            btn_DangXuat.Enabled = btn_NhanVien.Enabled = btn_TaiKhoan.Enabled = btn_TheoDoiDonHang.Enabled = dangNhap;
            btn_LoaiMonAn.Enabled = btn_MonAn.Enabled = btn_ThayDoiGiaMon.Enabled = btn_PhongBan.Enabled = btn_ChiTietPhong.Enabled = dangNhap;
            btn_ThongKeDoanhThuTheoThang.Enabled = dangNhap;
        }

        private void btn_NhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                Program.formNhanVien = new frmNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }
        }

        private void btn_TaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTaiKhoan = new frmTaiKhoan();
                Program.formTaiKhoan.MdiParent = this;
                Program.formTaiKhoan.Show();
            }
        }

        private void btn_TheoDoiDonHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTheoDoiDonHang));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTheoDoiDonHang = new frmTheoDoiDonHang();
                Program.formTheoDoiDonHang.MdiParent = this;
                Program.formTheoDoiDonHang.Show();
            }
        }

        private void btn_LoaiMonAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLoaiMonAn));
            if (frm != null) frm.Activate();
            else
            {
                Program.formLoaiMonAn = new frmLoaiMonAn();
                Program.formLoaiMonAn.MdiParent = this;
                Program.formLoaiMonAn.Show();
            }
        }

        private void btn_MonAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonAn));
            if (frm != null) frm.Activate();
            else
            {
                Program.formMonAn = new frmMonAn();
                Program.formMonAn.MdiParent = this;
                Program.formMonAn.Show();
            }
        }

        private void btn_ThayDoiGiaMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmThayDoiGiaMon));
            if (frm != null) frm.Activate();
            else
            {
                Program.formThayDoiGiaMon = new frmThayDoiGiaMon();
                Program.formThayDoiGiaMon.MdiParent = this;
                Program.formThayDoiGiaMon.Show();
            }
        }

        private void btn_PhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhongBan));
            if (frm != null) frm.Activate();
            else
            {
                Program.formPhongBan = new frmPhongBan();
                Program.formPhongBan.MdiParent = this;
                Program.formPhongBan.Show();
            }
        }

        private void btn_ChiTietPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChiTietPhong));
            if (frm != null) frm.Activate();
            else
            {
                Program.formChiTietPhong = new frmChiTietPhong();
                Program.formChiTietPhong.MdiParent = this;
                Program.formChiTietPhong.Show();
            }
        }

        private void btn_ThongKeDoanhThuTheoThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmThongKeDoanhThuTheoThang));
            if (frm != null) frm.Activate();
            else
            {
                Program.formThongKeDoanhThuTheoThang = new frmThongKeDoanhThuTheoThang();
                Program.formThongKeDoanhThuTheoThang.MdiParent = this;
                Program.formThongKeDoanhThuTheoThang.Show();
            }
        }
    }
}
