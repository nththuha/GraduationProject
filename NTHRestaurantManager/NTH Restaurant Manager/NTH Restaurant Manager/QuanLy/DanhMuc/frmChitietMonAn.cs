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
    public partial class frmChitietMonAn : Form
    {
        MonAnRepository _repositoryMA = new MonAnRepository();
        NguyenLieuRepository _repositoryNL = new NguyenLieuRepository();
        CTMonAnRepository _repositoryCTMA = new CTMonAnRepository();

        String maMA;
        String maNL;
        int idCTMA;

        CTMonAnModel ctMonAn;

        public frmChitietMonAn()
        {
            InitializeComponent();
            layDSMonAn();
            layDSNguyenLieu();
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
                    layDSChiTietMonAnTheoMonAn();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi load danh sách món ăn: " + e.Message, "Thông báo");
            }
        }

        private async void layDSNguyenLieu()
        {
            try
            {
                var listNL = await _repositoryNL.layDSNguyenLieu();
                gcNL.DataSource = listNL;
                if (listNL.Count > 0)
                {
                    maNL = listNL[0].maNL;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách nguyên liệu: " + e.Message, "Thông báo");
            }
        }

        private async void layDSChiTietMonAnTheoMonAn()
        {
            try
            {
                var listCTMA = await _repositoryCTMA.layDSCTMonAnTheoMonAn(maMA);
                gcCTMA.DataSource = listCTMA;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách chi tiết món ăn: " + e.Message, "Thông báo");
            }
        }

        private void gvMA_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            maMA = gvMA.GetRowCellValue(e.RowHandle, "maMA").ToString();
            layDSChiTietMonAnTheoMonAn();
        }

        private void gvNL_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            maNL = gvNL.GetRowCellValue(e.RowHandle, "maNL").ToString();
        }

        private void gvCTMA_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idCTMA = int.Parse(gvCTMA.GetRowCellValue(e.RowHandle, "idCTMA").ToString());
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSMonAn();
            layDSNguyenLieu();
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết món ăn này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaCTMonAn();
            }
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvCTMA.Focus();
            int tam = Program.doiSpinEditThanhInt(se_SoLuong.Text.Trim());
            if (tam <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo");
                se_SoLuong.Focus();
                return;
            }
            ctMonAn = new CTMonAnModel();
            ctMonAn.mama = maMA;
            ctMonAn.manl = maNL;
            ctMonAn.soLuong = tam;
            themCTMonAn();
        }

        private async void themCTMonAn()
        {
            String check = await _repositoryCTMA.themCTMonAn(ctMonAn);
            if (check.Equals("false")) MessageBox.Show("Thêm chi tiết món ăn thất bại!", "Thông báo");
            else MessageBox.Show("Thêm chi tiết món ăn thành công!", "Thông báo");
            layDSChiTietMonAnTheoMonAn();
        }

        private async void xoaCTMonAn()
        {
            String check = await _repositoryCTMA.xoaCTMonAn(idCTMA);
            if (check.Equals("false")) MessageBox.Show("Xóa chi tiết món ăn thất bại!", "Thông báo");
            else MessageBox.Show("Xóa chi tiết món ăn thành công!", "Thông báo");
            layDSChiTietMonAnTheoMonAn();
        }
    }
}
