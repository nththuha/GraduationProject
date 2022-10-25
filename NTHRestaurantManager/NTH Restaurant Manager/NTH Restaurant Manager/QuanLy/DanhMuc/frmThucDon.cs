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
    public partial class frmThucDon : Form
    {
        ThucDonRepository _repositoryTD = new ThucDonRepository();
        CTThucDonRepository _repositoryCTTD = new CTThucDonRepository();
        MonAnRepository _repositoryMA = new MonAnRepository();
        int idTD;
        String maMA;
        int idCTTD;

        ThucDonModel thucDon;
        CTThucDonModel cTThucDon;

        String tenMA;
        int gia;

        public frmThucDon()
        {
            InitializeComponent();
            layDSMonAn();
            layDSThucDon();
            khoiTao();
        }

        private void khoiTao()
        {
            txt_TenTD.Text = "";
            cbb_LoaiTD.SelectedIndex = 0;
        }

        private async void layDSThucDon()
        {
            try
            {
                var listTD = await _repositoryTD.layDSThucDon();
                for (int i = 0; i < listTD.Count; i++)
                {
                    listTD[i].ngayTao = listTD[i].ngayTao.Substring(8, 2) + "-" + listTD[i].ngayTao.Substring(5, 2) + "-" + listTD[i].ngayTao.Substring(0, 4);
                }
                gcTD.DataSource = listTD;
                if(listTD.Count > 0)
                {
                    idTD = listTD[0].idTD;
                    layDSCTThucDon();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách thực đơn: " + e.Message, "Thông báo");
            }
        }

        private async void layDSCTThucDon()
        {
            try
            {
                var listCTTD = await _repositoryCTTD.layDSCTThucDonTheoThucDon(idTD);
                gcCTTD.DataSource = listCTTD;
                if(listCTTD.Count > 0)
                {
                    idCTTD = listCTTD[0].idCTTD;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách chi tiết thực đơn: " + e.Message, "Thông báo");
            }
        }

        private async void layDSMonAn()
        {
            try
            {
                var listMA = await _repositoryMA.layDSMonAn();
                gcMA.DataSource = listMA;
                if(listMA.Count > 0)
                {
                    maMA = listMA[0].maMA;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách món ăn: " + e.Message, "Thông báo");
            }
        }

        private void gvTD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idTD = int.Parse(gvTD.GetRowCellValue(e.RowHandle, "idTD").ToString());
            layDSCTThucDon();
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSMonAn();
            layDSThucDon();
        }

        private void btn_ThemTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khoiTao();
            panelControl3.Enabled = true;
            gcTD.Enabled = gcCTTD.Enabled = gcMA.Enabled = btn_ThemTD.Enabled = btn_ThemCTTD.Enabled = btn_XoaTD.Enabled = btn_XoaCTTD.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = false;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = true;
        }

        private async void themThucDon()
        {
            var check = await _repositoryTD.themThucDon(thucDon);
            if (check.Equals("false")) MessageBox.Show("Thêm thực đơn thất bại!", "Thông báo");
            else MessageBox.Show("Thêm thực đơn thành công!", "Thông báo");
            layDSThucDon();
        }

        private async void xoaThucDon()
        {
            var check = await _repositoryTD.xoaThucDon(idTD);
            if (check.Equals("false")) MessageBox.Show("Xóa thực đơn thất bại!", "Thông báo");
            else MessageBox.Show("Xóa thực đơn thành công!", "Thông báo");
            layDSThucDon();
        }

        public async void themCTThucDon()
        {
            cTThucDon = new CTThucDonModel();
            cTThucDon.gia = gia;
            cTThucDon.mama = maMA;
            cTThucDon.soLuong = Program.soLuong;
            cTThucDon.idtd = idTD;
            var check = await _repositoryCTTD.themCTThucDon(cTThucDon);
            if (check.Equals("false")) MessageBox.Show("Thêm chi tiết thực đơn thất bại!", "Thông báo");
            else MessageBox.Show("Thêm chi tiết thực đơn thành công!", "Thông báo");
            layDSCTThucDon();
        }

        private async void xoaCTThucDon()
        {
            var check = await _repositoryCTTD.xoaCTThucDon(idCTTD);
            if (check.Equals("false")) MessageBox.Show("Xóa chi tiết thực đơn thất bại!", "Thông báo");
            else MessageBox.Show("Xóa chi tiết thực đơn thành công!", "Thông báo");
            layDSCTThucDon();
        }

        private void gvMA_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            maMA = gvMA.GetRowCellValue(e.RowHandle, "maMA").ToString();
            gia = int.Parse(gvMA.GetRowCellValue(e.RowHandle, "gia").ToString());
        }

        private void gvCTTD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idCTTD = int.Parse(gvCTTD.GetRowCellValue(e.RowHandle, "idCTTD").ToString());
            tenMA = gvCTTD.GetRowCellValue(e.RowHandle, "tenma").ToString();
        }

        private void btn_XoaTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa thực đơn " + idTD + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaThucDon();
                khoiTao();
            }
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTD.CancelEdit();
            bdsCTTD.CancelEdit();
            bdsMA.CancelEdit();
            layDSMonAn();
            layDSThucDon();
            panelControl3.Enabled = false;
            gcTD.Enabled = gcCTTD.Enabled = gcMA.Enabled = btn_ThemTD.Enabled = btn_ThemCTTD.Enabled = btn_XoaTD.Enabled = btn_XoaCTTD.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }

        private void btn_XoaCTTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa món " + tenMA + " ra khỏi thực đơn?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaCTThucDon();
                khoiTao();
            }
        }

        private void btn_ThemCTTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mesCTThucDon = new mesCTThucDon();
            Program.mesCTThucDon.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            thucDon = new ThucDonModel();
            thucDon.tenTD = txt_TenTD.Text.Trim();
            thucDon.loaitd = cbb_LoaiTD.Text;
            thucDon.gia = 0;
            thucDon.ngayTao = now;
            themThucDon();
            panelControl3.Enabled = false;
            gcTD.Enabled = gcCTTD.Enabled = gcMA.Enabled = btn_ThemTD.Enabled = btn_ThemCTTD.Enabled = btn_XoaTD.Enabled = btn_XoaCTTD.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }
    }
}
