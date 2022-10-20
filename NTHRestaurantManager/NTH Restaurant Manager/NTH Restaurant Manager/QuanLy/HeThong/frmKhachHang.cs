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
    public partial class frmKhachHang : Form
    {
        KhachHangRepository _repository = new KhachHangRepository();
        KhachHangModel khachHang;
        int idKH;
        String button;

        public frmKhachHang()
        {
            InitializeComponent();
            khoiTao();
            layDSKhachHang();
        }

        private void khoiTao()
        {
            txt_HoTen.Text = "";
            txt_CMND.Text = "";
            txt_SDT.Text = "";
        }

        private async void layDSKhachHang()
        {
            try
            {
                var listKH = await _repository.layDSKhachHang();
                gcKH.DataSource = listKH;
                if(listKH.Count > 0)
                {
                    setGiaTri(0);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi load danh sách khách hàng: " + e.Message, "Thông báo");
            }
        }

        private void setGiaTri(int num)
        {
            idKH = int.Parse(gvKH.GetRowCellValue(num, "idKH").ToString());
            txt_HoTen.Text = gvKH.GetRowCellValue(num, "hoTen").ToString();
            txt_CMND.Text = gvKH.GetRowCellValue(num, "cmnd").ToString();
            txt_SDT.Text = gvKH.GetRowCellValue(num, "sdt").ToString();
        }

        private void gvKH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            setGiaTri(e.RowHandle);
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSKhachHang();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKH.CancelEdit();
            layDSKhachHang();
            gcKH.Enabled = false;
            panelControl2.Enabled = btn_Them.Enabled = btn_Xoa.Enabled = btn_CapNhat.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }

        private async void themKhachHang()
        {
            String check = await _repository.themKhachHang(khachHang);
            if (check.Equals("false")) MessageBox.Show("Thêm khách hàng thất bại!", "Thông báo");
            else MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
            layDSKhachHang();
        }

        private async void suaKhachHang()
        {
            String check = await _repository.suaKhachHang(khachHang);
            if (check.Equals("false")) MessageBox.Show("Cập nhật khách hàng thất bại!", "Thông báo");
            else MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo");
            layDSKhachHang();
        }

        private async void xoaKhachHang()
        {
            String check = await _repository.xoaKhachHang(idKH);
            if (check.Equals("false")) MessageBox.Show("Xóa khách hàng thất bại!", "Thông báo");
            else MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
            layDSKhachHang();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Thêm";
            khoiTao();
            gcKH.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl2.Enabled = true;
        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Cập nhật";
            gcKH.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl2.Enabled = true;
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String hoTen = txt_HoTen.Text;
            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng " + hoTen + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaKhachHang();
                khoiTao();
            }
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_HoTen.Text.Trim().Equals(""))
            {
                MessageBox.Show("Họ tên không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_HoTen.Focus();
                return;
            }
            if (txt_CMND.Text.Trim().Equals(""))
            {
                MessageBox.Show("CMND không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_CMND.Focus();
                return;
            }
            if (txt_SDT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_SDT.Focus();
                return;
            }
            khachHang = new KhachHangModel();
            khachHang.hoTen = txt_HoTen.Text.Trim();
            khachHang.cmnd = txt_CMND.Text.Trim();
            khachHang.sdt = txt_SDT.Text.Trim();
            if (button.Equals("Thêm"))
            {
                themKhachHang();
            }
            else
            {
                khachHang.idKH = idKH;
                suaKhachHang();
            }
            gcKH.Enabled = btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }
    }
}
