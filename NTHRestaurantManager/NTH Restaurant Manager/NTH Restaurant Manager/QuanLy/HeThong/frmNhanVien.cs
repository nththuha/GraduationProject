using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using NTH_Restaurant_Manager.Model;
using NTH_Restaurant_Manager.Repository;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace NTH_Restaurant_Manager
{
    public partial class frmNhanVien : Form
    {
        NhanVienRepository _repositoryNV = new NhanVienRepository();
        TaiKhoanRepository _repositoryTK = new TaiKhoanRepository();
        BoPhanRepository _repositoryBP = new BoPhanRepository();

        List<BoPhanModel> listBP = new List<BoPhanModel>();
        NVTKModel nVTK;
        NhanVienModel nhanVien;

        String button;

        int num;

        public frmNhanVien()
        {
            InitializeComponent();
            layDSBoPhan();
            layDSNVTK();
            khoiTao();
        }

        private void khoiTao()
        {
            txt_HoTen.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
            txt_Email.Text = "";
            txt_MaTK.Text = "";
            txt_MatKhau.Text = "";
        }

        private async void layDSBoPhan()
        {
            try
            {
                listBP = await _repositoryBP.layDSBoPhan();
                foreach (BoPhanModel i in listBP)
                {
                    if (i.tenBP.Equals("ADMIN")) i.tenBP = "Admin";
                    else if (i.tenBP.Equals("PHUCVU")) i.tenBP = "Phục vụ";
                    else if (i.tenBP.Equals("BOPHANBEP")) i.tenBP = "Bộ phận bếp";
                    else if (i.tenBP.Equals("BOPHANPHACHE")) i.tenBP = "Bộ phận phục vụ";
                }
                cbb_TenBP.DataSource = listBP;
                cbb_TenBP.DisplayMember = "tenBP";
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách bộ phận: " + e.Message, "Thông báo");
            }
        }

        private async void layDSNVTK()
        {
            try
            {
                var listNVTK = await _repositoryNV.layDSNhanVien();
                foreach(NVTKModel i in listNVTK){
                    if (i.tenBP.Equals("ADMIN")) i.tenBP = "Admin";
                    else if (i.tenBP.Equals("PHUCVU")) i.tenBP = "Phục vụ";
                    else if (i.tenBP.Equals("BOPHANBEP")) i.tenBP = "Bộ phận bếp";
                    else if (i.tenBP.Equals("BOPHANPHACHE")) i.tenBP = "Bộ phận phục vụ";
                }
                gcNVTK.DataSource = listNVTK;
                if(listNVTK.Count > 0)
                {
                    num = 0;
                    setGiaTri();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách nhân viên tài khoản " + e.Message, "Thông báo");
            }
        }

        private void setGiaTri()
        {
            txt_HoTen.Text = gvNVTK.GetRowCellValue(num, "hoTen").ToString();
            txt_SDT.Text = gvNVTK.GetRowCellValue(num, "sdt").ToString();
            txt_DiaChi.Text = gvNVTK.GetRowCellValue(num, "diaChi").ToString();
            txt_Email.Text = gvNVTK.GetRowCellValue(num, "email").ToString();
            txt_MaTK.Text = gvNVTK.GetRowCellValue(num, "maTK").ToString();
            String temp = gvNVTK.GetRowCellValue(num, "maBP").ToString();
            for (int i = 0; i < listBP.Count; i++)
            {
                if (listBP[i].maBP.Equals(temp))
                {
                    cbb_TenBP.SelectedIndex = i;
                    break;
                }
            }
        }

        private void gvNVTK_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            num = e.RowHandle;
            setGiaTri();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Thêm";
            khoiTao();
            txt_MaTK.Enabled = txt_MatKhau.Enabled = true;
            gcNVTK.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl2.Enabled = true;
        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Cập nhật";
            txt_MaTK.Enabled = txt_MatKhau.Enabled = false;
            gcNVTK.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl2.Enabled = true;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSBoPhan();
            layDSNVTK();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNVTK.CancelEdit();
            layDSBoPhan();
            layDSNVTK();
            panelControl2.Enabled = false;

            gcNVTK.Enabled = btn_Them.Enabled = btn_Xoa.Enabled = btn_CapNhat.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }

        private async void themNhanVienTaiKhoan()
        {
            MessageModel mes = await _repositoryTK.dangKy(nVTK);
            if (mes.message.Equals("Đăng ký thất bại!")) MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
            else MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
            layDSNVTK();
        }

        private async void suaNhanVien()
        {
            var check = await _repositoryNV.suaNhanVien(nhanVien);
            if (check.Equals("false")) MessageBox.Show("Cập nhật nhân viên thất bại!", "Thông báo");
            else MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo");
            layDSNVTK();
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_HoTen.Text.Trim().Equals(""))
            {
                MessageBox.Show("Họ tên không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_HoTen.Focus();
                return;
            }
            if (txt_SDT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_SDT.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_DiaChi.Focus();
                return;
            }
            if (txt_Email.Text.Trim().Equals(""))
            {
                MessageBox.Show("Email không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_Email.Focus();
                return;
            }
            if (button.Equals("Thêm"))
            {
                if (txt_MaTK.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK);
                    txt_MaTK.Focus();
                    return;
                }
                if (txt_MatKhau.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK);
                    txt_MatKhau.Focus();
                    return;
                }
                nVTK = new NVTKModel();
                nVTK.hoTen = txt_HoTen.Text.Trim();
                nVTK.sdt = txt_SDT.Text.Trim();
                nVTK.diaChi = txt_DiaChi.Text.Trim();
                nVTK.email = txt_Email.Text.Trim();
                nVTK.maTK = txt_MaTK.Text.Trim();
                nVTK.matKhau = txt_MatKhau.Text.Trim();
                nVTK.maBP = ((BoPhanModel)cbb_TenBP.SelectedItem).maBP;
                themNhanVienTaiKhoan();
            }
            else
            {
                nhanVien = new NhanVienModel();
                nhanVien.idNV = int.Parse(gvNVTK.GetRowCellValue(num, "idnv").ToString());
                nhanVien.hoTen = txt_HoTen.Text.Trim();
                nhanVien.sdt = txt_SDT.Text.Trim();
                nhanVien.diaChi = txt_DiaChi.Text.Trim();
                nhanVien.email = txt_Email.Text.Trim();
                nhanVien.maBP = ((BoPhanModel)cbb_TenBP.SelectedItem).maBP;
                suaNhanVien();
                txt_MaTK.Enabled = txt_MatKhau.Enabled = true;
            }
            gcNVTK.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }
    }
}
