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
    public partial class frmLoaiMonAn : Form
    {
        LoaiMonAnRepository _repository = new LoaiMonAnRepository();
        String button;
        LoaiMonAnModel loaiMonAn;

        public frmLoaiMonAn()
        {
            InitializeComponent();
            khoiTao();
            layDSLoaiMonAn();
        }

        public void khoiTao()
        {
            txt_MaLMA.Text = "";
            txt_TenLMA.Text = "";
            txt_HinhAnh.Text = "";
            pb_HinhAnh.LoadAsync("https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Flag_of_None_%28square%29.svg/768px-Flag_of_None_%28square%29.svg.png");
        }

        public async void layDSLoaiMonAn()
        {
            try
            {
                var listLMA = await _repository.layDSLoaiMonAn();
                gcLMA.DataSource = listLMA;
                if (listLMA.Count > 0) setGiaTri(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách loại món ăn: " + e.Message, "Thông báo");
            }
        }

        private void setGiaTri(int num)
        {
            txt_MaLMA.Text = gvLMA.GetRowCellValue(num, "maLMA").ToString();
            txt_TenLMA.Text = gvLMA.GetRowCellValue(num, "tenLMA").ToString();
            txt_HinhAnh.Text = gvLMA.GetRowCellValue(num, "hinhAnh").ToString();
            pb_HinhAnh.LoadAsync(gvLMA.GetRowCellValue(num, "hinhAnh").ToString());
        }

        private void gvLMA_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            setGiaTri(e.RowHandle);
        }

        private async void xoaLoaiMonAn(String maLMA)
        {
            String check = await _repository.xoaLoaiMonAn(maLMA);
            if (check.Equals("false")) MessageBox.Show("Xóa loại món ăn thất bại!", "Thông báo");
            else MessageBox.Show("Xóa loại món ăn thành công!", "Thông báo");
            layDSLoaiMonAn();
        }

        private async void themLoaiMonAn()
        {
            String check = await _repository.themLoaiMonAn(loaiMonAn);
            if(check.Equals("false")) MessageBox.Show("Thêm loại món ăn thất bại!", "Thông báo");
            else MessageBox.Show("Thêm loại món ăn thành công!", "Thông báo");
            layDSLoaiMonAn();
        }

        private async void suaLoaiMonAn()
        {
            String check = await _repository.suaLoaiMonAn(loaiMonAn);
            if (check.Equals("false")) MessageBox.Show("Cập nhật loại món ăn thất bại!", "Thông báo");
            else MessageBox.Show("Cập nhật loại món ăn thành công!", "Thông báo");
            layDSLoaiMonAn();
        }

        private void btn_Xoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maLMA = txt_MaLMA.Text;
            String tenLMA = txt_TenLMA.Text;
            if (MessageBox.Show("Bạn có thật sự muốn xóa loại món ăn " + tenLMA + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaLoaiMonAn(maLMA);
                khoiTao();
            }
        }

        private void btn_Them_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Thêm";
            khoiTao();
            panelControl1.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl2.Enabled = true;
        }

        private void btn_CapNhat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Cập nhật";
            panelControl1.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl2.Enabled = true;
            txt_MaLMA.Enabled = false;
        }

        private void btn_Luu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_MaLMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã loại món ăn không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_MaLMA.Focus();
                return;
            }
            if (txt_TenLMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên loại món ăn không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_TenLMA.Focus();
                return;
            }
            if (txt_HinhAnh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hình ảnh không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_HinhAnh.Focus();
                return;
            }
            loaiMonAn = new LoaiMonAnModel();
            loaiMonAn.maLMA = txt_MaLMA.Text.Trim();
            loaiMonAn.tenLMA = txt_TenLMA.Text.Trim();
            loaiMonAn.hinhAnh = txt_HinhAnh.Text.Trim();
            if (button.Equals("Thêm"))
            {
                themLoaiMonAn();
            }
            else
            {
                suaLoaiMonAn();
                txt_MaLMA.Enabled = true;
            }
            panelControl1.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btn_Thoat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSLoaiMonAn();
        }

        private void btn_PhucHoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLMA.CancelEdit();
            layDSLoaiMonAn();
            panelControl2.Enabled = false;
            panelControl1.Enabled = btn_Them.Enabled = btn_Xoa.Enabled = btn_CapNhat.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }
    }
}
