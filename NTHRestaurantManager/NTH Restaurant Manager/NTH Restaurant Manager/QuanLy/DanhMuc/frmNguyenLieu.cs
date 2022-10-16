using NTH_Restaurant_Manager.Model;
using NTH_Restaurant_Manager.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTH_Restaurant_Manager
{
    public partial class frmNguyenLieu : Form
    {
        NguyenLieuRepository _repository = new NguyenLieuRepository();
        String button;
        int slTon;
        NguyenLieuModel nguyenLieu;

        public frmNguyenLieu()
        {
            InitializeComponent();
            khoiTao();
            layDSNguyenLieu();
        }

        private async void layDSNguyenLieu()
        {
            try
            {
                var listNL = await _repository.layDSNguyenLieu();
                gcNL.DataSource = listNL;
                if (listNL.Count > 0) setGiaTri(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách nguyên liệu: " + e.Message, "Thông báo");
            }
        }

        private void khoiTao()
        {
            txt_MaNL.Text = "";
            txt_TenNL.Text = "";
            txt_DonVi.Text = "";
            se_SLTon.Text = "0";
        }

        private void setGiaTri(int num)
        {
            txt_MaNL.Text = gvNL.GetRowCellValue(num, "maNL").ToString();
            txt_TenNL.Text = gvNL.GetRowCellValue(num, "tenNL").ToString();
            txt_DonVi.Text = gvNL.GetRowCellValue(num, "donVi").ToString();
            se_SLTon.Text = gvNL.GetRowCellValue(num, "slTon").ToString();
            slTon = int.Parse(gvNL.GetRowCellValue(num, "slTon").ToString());
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvNL_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            setGiaTri(e.RowHandle);
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNL.CancelEdit();
            layDSNguyenLieu();
            panelControl2.Enabled = false;
            panelControl1.Enabled = btn_Them.Enabled = btn_Xoa.Enabled = btn_CapNhat.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Thêm";
            khoiTao();
            panelControl1.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl2.Enabled = true;
            se_SLTon.Enabled = false;
        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Cập nhật";
            panelControl1.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl2.Enabled = true;
            txt_MaNL.Enabled = false;
            se_SLTon.Enabled = true;
        }

        private async void themNguyenLieu()
        {
            String check = await _repository.themNguyenLieu(nguyenLieu);
            if (check.Equals("false")) MessageBox.Show("Thêm nguyên liệu thất bại!", "Thông báo");
            else MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo");
            layDSNguyenLieu();
        }

        private async void suaNguyenLieu()
        {
            String check = await _repository.suaNguyenLieu(nguyenLieu);
            if (check.Equals("false")) MessageBox.Show("Cập nhật nguyên liệu thất bại!", "Thông báo");
            else MessageBox.Show("Cập nhật nguyên liệu thành công!", "Thông báo");
            layDSNguyenLieu();
        }

        private async void xoaNguyenLieu(String maNL)
        {
            String check = await _repository.xoaNguyenLieu(maNL);
            if (check.Equals("false")) MessageBox.Show("Xóa nguyên liệu thất bại!", "Thông báo");
            else MessageBox.Show("Xóa nguyên liệu thành công!", "Thông báo");
            layDSNguyenLieu();
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maNL = txt_MaNL.Text;
            String tenNL = txt_TenNL.Text;
            if (MessageBox.Show("Bạn có thật sự muốn xóa nguyên liệu " + tenNL + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaNguyenLieu(maNL);
                khoiTao();
            }
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_MaNL.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã nguyên liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_MaNL.Focus();
                return;
            }
            if (txt_TenNL.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên nguyên liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_TenNL.Focus();
                return;
            }
            if (txt_DonVi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Đơn vị không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_DonVi.Focus();
                return;
            }
            int tam = Program.doiSpinEditThanhInt(se_SLTon.Text.Trim());
            if ((tam < 0 || tam > slTon) && button.Equals("Cập nhật"))
            {
                MessageBox.Show("Số lượng tồn phải lớn hơn 0 và nhỏ hơn số lượng tồn ban đầu", "Thông báo", MessageBoxButtons.OK);
                se_SLTon.Focus();
                return;
            }
            nguyenLieu = new NguyenLieuModel();
            nguyenLieu.maNL = txt_MaNL.Text.Trim();
            nguyenLieu.tenNL = txt_TenNL.Text.Trim();
            nguyenLieu.donVi = txt_DonVi.Text.Trim();
            nguyenLieu.slTon = tam;
            if (button.Equals("Thêm"))
            {
                themNguyenLieu();
                se_SLTon.Enabled = true;
            }
            else
            {
                suaNguyenLieu();
                txt_MaNL.Enabled = true;
            }
            panelControl1.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }
    }
}
