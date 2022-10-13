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
    public partial class frmMonAn : Form
    {
        MonAnRepository _repositoryMA = new MonAnRepository();
        LoaiMonAnRepository _repositoryLMA = new LoaiMonAnRepository();
        String button;
        MonAnModel monAn;

        List<LoaiMonAnModel> listLMA = new List<LoaiMonAnModel>();

        public frmMonAn()
        {
            InitializeComponent();
            khoiTao();
            layDSMonAn();
            layDSLoaiMonAn();
        }

        private async void layDSLoaiMonAn()
        {
            try
            {
                listLMA = await _repositoryLMA.layDSLoaiMonAn();
                cbb_TenLMA.DataSource = listLMA;
                cbb_TenLMA.DisplayMember = "tenLMA";
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách loại món ăn: " + e.Message, "Thông báo");
            }
        }

        private async void layDSMonAn()
        {
            try
            {
                var listMA = await _repositoryMA.layDSMonAn();
                gcMA.DataSource = listMA;
                if (listMA.Count > 0) setGiaTri(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách món ăn: " + e.Message, "Thông báo");
            }
        }

        private void khoiTao()
        {
            txt_MaMA.Text = "";
            txt_TenMA.Text = "";
            txt_ChuThich.Text = "";
            txt_HinhAnh.Text = "";
            se_Gia.Text = "0";
            pb_HinhAnh.LoadAsync("https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Flag_of_None_%28square%29.svg/768px-Flag_of_None_%28square%29.svg.png");
        }

        private void setGiaTri(int num)
        {
            txt_MaMA.Text = gvMA.GetRowCellValue(num, "maMA").ToString();
            txt_TenMA.Text = gvMA.GetRowCellValue(num, "tenMA").ToString();
            if(gvMA.GetRowCellValue(num, "chuThich") != null) txt_ChuThich.Text = gvMA.GetRowCellValue(num, "chuThich").ToString();
            txt_HinhAnh.Text = gvMA.GetRowCellValue(num, "hinhAnh").ToString();
            se_Gia.Text = gvMA.GetRowCellValue(num, "gia").ToString();
            pb_HinhAnh.LoadAsync(gvMA.GetRowCellValue(num, "hinhAnh").ToString());
            if(gvMA.GetRowCellValue(num, "trangThai").ToString().Equals("Còn món")){
                cbb_TrangThai.SelectedIndex = 0;
            }
            else
            {
                cbb_TrangThai.SelectedIndex = 1;
            }
            String temp = gvMA.GetRowCellValue(num, "malma").ToString();
            for (int i = 0; i < listLMA.Count; i++)
            {
                if (listLMA[i].maLMA.Equals(temp))
                {
                    cbb_TenLMA.SelectedIndex = i;
                    break;
                }
            }
        }

        private void gvMA_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            setGiaTri(e.RowHandle);
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSLoaiMonAn();
            layDSMonAn();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMA.CancelEdit();
            layDSMonAn();
            layDSLoaiMonAn();
            panelControl2.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_CapNhat.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Thêm";
            khoiTao();
            btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl2.Enabled = true;
        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Cập nhật";
            btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl2.Enabled = true;
            txt_MaMA.Enabled = false;
        }

        private async void themMonAn()
        {
            String check = await _repositoryMA.themMonAn(monAn);
            if (check.Equals("false")) MessageBox.Show("Thêm món ăn thất bại!", "Thông báo");
            else MessageBox.Show("Thêm món ăn thành công!", "Thông báo");
            layDSMonAn();
        }

        private async void suaMonAn()
        {
            String check = await _repositoryMA.suaMonAn(monAn);
            if (check.Equals("false")) MessageBox.Show("Cập nhật món ăn thất bại!", "Thông báo");
            else MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo");
            layDSMonAn();
        }

        private async void xoaMonAn(String maMA)
        {
            String check = await _repositoryMA.xoaMonAn(maMA);
            if (check.Equals("false")) MessageBox.Show("Xóa món ăn thất bại!", "Thông báo");
            else MessageBox.Show("Xóa món ăn thành công!", "Thông báo");
            layDSMonAn();
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maMA = txt_MaMA.Text;
            String tenMA = txt_TenMA.Text;
            if (MessageBox.Show("Bạn có thật sự muốn xóa món ăn " + tenMA + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaMonAn(maMA);
                khoiTao();
            }
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_MaMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã món ăn không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_MaMA.Focus();
                return;
            }
            if (txt_TenMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên món ăn không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_TenMA.Focus();
                return;
            }
            if (txt_HinhAnh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hình ảnh không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_HinhAnh.Focus();
                return;
            }
            int tam = Program.doiSpinEditThanhInt(se_Gia.Text.Trim());
            if (tam < 0)
            {
                MessageBox.Show("Giá phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
                se_Gia.Focus();
                return;
            }
            monAn = new MonAnModel();
            monAn.maMA = txt_MaMA.Text.Trim();
            monAn.tenMA = txt_TenMA.Text.Trim();
            if (!txt_ChuThich.Text.Trim().Equals("")) monAn.chuThich = txt_ChuThich.Text.Trim();
            else monAn.chuThich = null;
            monAn.trangThai = cbb_TrangThai.Text;
            monAn.hinhAnh = txt_HinhAnh.Text.Trim();
            monAn.gia = tam;
            monAn.malma = ((LoaiMonAnModel)cbb_TenLMA.SelectedItem).maLMA;
            monAn.idNV = Program.nhanVienDangDangNhap.idNV;
            if (button.Equals("Thêm"))
            {
                themMonAn();
            }
            else
            {
                suaMonAn();
                txt_MaMA.Enabled = true;
            }
            btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }
    }
}
