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
    public partial class frmPhieuNhap : Form
    {
        NguyenLieuRepository _repositoryNL = new NguyenLieuRepository();
        CTPhieuNhapRepository _repositoryCTPN = new CTPhieuNhapRepository();
        PhieuNhapNguyenLieuRepository _repositoryPN = new PhieuNhapNguyenLieuRepository();

        PhieuNhapNguyenLieuModel phieuNhap;

        int idPN;
        int idCTPN;

        String maNL, tenNL, donVi;

        public frmPhieuNhap()
        {
            InitializeComponent();
        } 

        public void khoiTao(int idPN)
        {
            this.idPN = idPN;
            layDSCTPhieuNhap();
        }

        public async void layDSCTPhieuNhap()
        {
            try
            {
                var listCTPN = await _repositoryCTPN.layDSCTPhieuNhapTheoPhieuNhap(idPN);
                gcCTPN.DataSource = listCTPN;
                if (listCTPN.Count > 0)
                {
                    idCTPN = listCTPN[0].idCTPN;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy ds chi tiết phiếu nhập: " + e.Message, "Thông báo");
            }
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_XoaChiTietPhieuMua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết phiếu nhập này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaCTPhieuNhap();
            }
        }

        private async void xoaCTPhieuNhap()
        {
            var check = await _repositoryCTPN.xoaCTPhieuNhap(idCTPN);
            if (check.Equals("false"))
            {
                MessageBox.Show("Xóa chi tiết phiếu nhập thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa chi tiết phiếu nhập thành công!", "Thông báo");
            }
            layDSCTPhieuNhap();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mesCTPN = new mesCTPN(maNL, tenNL, donVi, phieuNhap.idPN);
            Program.mesCTPN.Show();
            Program.frmChinh.Enabled = false;
        }

        private void gvCTPN_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idCTPN = int.Parse(gvCTPN.GetRowCellValue(e.RowHandle, "idCTPN").ToString());
            maNL = gvCTPN.GetRowCellValue(e.RowHandle, "manl").ToString();
            tenNL = gvCTPN.GetRowCellValue(e.RowHandle, "tennl").ToString();
        }

        private void btn_Load_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSCTPhieuNhap();
        }

        private void btn_ThemChiTietPhieuMua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mesCTPN = new mesCTPN(maNL, tenNL, donVi, phieuNhap.idPN);
            Program.mesCTPN.Show();
            Program.frmChinh.Enabled = false;
        }
    }
}
