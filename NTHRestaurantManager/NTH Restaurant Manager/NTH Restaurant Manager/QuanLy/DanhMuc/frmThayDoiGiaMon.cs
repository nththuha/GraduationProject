using NTH_Restaurant_Manager.Model;
using NTH_Restaurant_Manager.Repository;
using System;
using System.Windows.Forms;

namespace NTH_Restaurant_Manager
{
    public partial class frmThayDoiGiaMon : Form
    {
        MonAnRepository _repositoryMA = new MonAnRepository();
        ThayDoiGiaMonRepository _repositoryTDGM = new ThayDoiGiaMonRepository();
        ThayDoiGiaMonModel thayDoiGiaMon;
        String maMA;
        int numMA;
        int numTDGM;

        public frmThayDoiGiaMon()
        {
            InitializeComponent();
            this.de_Ngay.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.Mask.EditMask = "dd-MM-yyyy";
            khoiTao();
            layDSLoaiMonAn();
        }

        private async void layDSLoaiMonAn()
        {
            try
            {
                var listMA = await _repositoryMA.layDSMonAn();
                gcMA.DataSource = listMA;
                if (listMA.Count > 0)
                {
                    maMA = listMA[0].maMA;
                    numMA = 0;
                    layDSThayDoiGiaMonTheoMonAn();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách món ăn: " + e.Message, "Thông báo");
            }
        }
        
        private async void layDSThayDoiGiaMonTheoMonAn()
        {
            try
            {
                var listTDGM = await _repositoryTDGM.layDSThayDoiGiaMonTheoMonAn(maMA);
                for(int i = 0; i < listTDGM.Count; i++)
                {
                    listTDGM[i].ngay = listTDGM[i].ngay.Substring(8, 2) + "-" + listTDGM[i].ngay.Substring(5, 2) + "-" + listTDGM[i].ngay.Substring(0, 4);
                }
                gcTDGM.DataSource = listTDGM;
                if (listTDGM.Count > 0)
                {
                    numTDGM = 0;
                    setGiaTri();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách thay đổi giá món: " + e.Message, "Thông báo");
            }
        }

        private void khoiTao()
        {
            txt_MaMA.Text = "";
            txt_TenMA.Text = txt_MaMA.Text = "";
            se_Gia.Text = "0";
            de_Ngay.DateTime = DateTime.Now;
        }

        private void setGiaTri()
        {
            txt_MaMA.Text = gvMA.GetRowCellValue(numMA, "maMA").ToString();
            txt_TenMA.Text = gvMA.GetRowCellValue(numMA, "tenMA").ToString();
            se_Gia.Text = gvTDGM.GetRowCellValue(numTDGM, "gia").ToString();
            de_Ngay.DateTime = DateTime.ParseExact(gvTDGM.GetRowCellValue(numTDGM, "ngay").ToString(), "dd-MM-yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);

        }

        private void gvMA_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numMA = e.RowHandle;
            maMA = gvMA.GetRowCellValue(numMA, "maMA").ToString();
            layDSThayDoiGiaMonTheoMonAn();
        }

        private void gvTDGM_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numTDGM = e.RowHandle;
            setGiaTri();
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSLoaiMonAn();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_MaMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã món ăn không được để trống!", "Thông báo");
                txt_MaMA.Focus();
                return;
            }
            if (txt_TenMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên món ăn không được để trống!", "Thông báo");
                txt_TenMA.Focus();
                return;
            }
            de_Ngay.Focus();
            int tam = Program.doiSpinEditThanhInt(se_Gia.Text.Trim()); 
            if (tam <= 0)
            {
                MessageBox.Show("Giá phải lớn hơn 0!", "Thông báo");
                se_Gia.Focus();
                return;
            }
            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            String ngay = de_Ngay.DateTime.ToString("yyyy-MM-dd");
            if (now.CompareTo(ngay) > 0)
            {
                MessageBox.Show("Ngày phải lớn hơn hoặc bằng ngày hiện tại", "Thông báo");
                return;
            }
            thayDoiGiaMon = new ThayDoiGiaMonModel();
            thayDoiGiaMon.mama = txt_MaMA.Text.Trim();
            thayDoiGiaMon.idnv = Program.nhanVienDangDangNhap.idNV;
            thayDoiGiaMon.gia = tam;
            thayDoiGiaMon.ngay = ngay;
            themThayDoiGiaMon();
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            String ngay = gvTDGM.GetRowCellValue(numTDGM, "ngay").ToString();
            ngay = ngay.Substring(6, 4) + "-" + ngay.Substring(3, 2) + "-" + ngay.Substring(0, 2);
            if (now.CompareTo(ngay) > 0)
            {
                MessageBox.Show("Không được phép xóa giá món!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa giá món này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int idGM = int.Parse(gvTDGM.GetRowCellValue(numTDGM, "idGM").ToString());
                xoaThayDoiGiaMon(idGM);
            }
        }

        private async void xoaThayDoiGiaMon(int idTDGM)
        {
            String check = await _repositoryTDGM.xoaThayDoiGiaMon(idTDGM);
            if (check.Equals("false")) MessageBox.Show("Xóa giá món thất bại!", "Thông báo");
            else MessageBox.Show("Xóa giá món thành công!", "Thông báo");
            layDSThayDoiGiaMonTheoMonAn();
        }

        private async void themThayDoiGiaMon()
        {
            String check = await _repositoryTDGM.themThayDoiGiaMon(thayDoiGiaMon);
            if (check.Equals("false")) MessageBox.Show("Thêm giá món thất bại!", "Thông báo");
            else MessageBox.Show("Thêm giá món thành công!", "Thông báo");
            layDSThayDoiGiaMonTheoMonAn();
        }
    }
}
