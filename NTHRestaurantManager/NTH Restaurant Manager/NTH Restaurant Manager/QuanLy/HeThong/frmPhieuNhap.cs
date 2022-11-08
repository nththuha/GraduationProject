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

        String maNL;
        String tenNL;
        String donVi;

        int idCTPN;

        public frmPhieuNhap()
        {
            InitializeComponent();
            this.de_Ngay.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.Mask.EditMask = "dd-MM-yyyy";
            khoiTao();
            layDSNguyenLieu();
        }

        private async void layDSNguyenLieu()
        {
            try
            {
                var listNL = await _repositoryNL.layDSNguyenLieu();
                gcNL.DataSource = listNL;
                if(listNL.Count > 0)
                {
                    maNL = listNL[0].maNL;
                    tenNL = listNL[0].tenNL;
                    donVi = listNL[0].donVi;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy ds nguyên liệu: " + e.Message, "Thông báo");
            }
        }

        private void khoiTao()
        {
            de_Ngay.DateTime = DateTime.Now;
        }

        public async void layDSCTPhieuNhap()
        {
            try
            {
                var listCTPN = await _repositoryCTPN.layDSCTPhieuNhapTheoPhieuNhap(phieuNhap.idPN);
                gcCTPN.DataSource = listCTPN;
                if(listCTPN.Count > 0)
                {
                    idCTPN = listCTPN[0].idCTPN;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy ds chi tiết phiếu nhập: " + e.Message, "Thông báo");
            }
        }

        private void gvNL_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            maNL = gvNL.GetRowCellValue(e.RowHandle, "maNL").ToString();
            tenNL = gvNL.GetRowCellValue(e.RowHandle, "tenNL").ToString();
            donVi = gvNL.GetRowCellValue(e.RowHandle, "donVi").ToString();
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_ThemPhieuMua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            String ngay = de_Ngay.DateTime.ToString("yyyy-MM-dd");
            if (now.CompareTo(ngay) > 0)
            {
                MessageBox.Show("Ngày phải lớn hơn ngày hiện tại", "Thông báo");
                return;
            }

            phieuNhap = new PhieuNhapNguyenLieuModel();
            phieuNhap.idnv = Program.nhanVienDangDangNhap.idNV;
            phieuNhap.ngay = ngay;

            themPhieuNhapNguyenLieu();
        }

        private async void themPhieuNhapNguyenLieu()
        {
            phieuNhap = await _repositoryPN.themPhieuNhapNguyenLieu(phieuNhap);
            if(phieuNhap == null)
            {
                MessageBox.Show("Tạo phiếu nhập thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tạo phiếu nhập thành công!", "Thông báo");
                panelControl2.Enabled = btn_ThemPhieuMua.Enabled = false;
                btn_ThemChiTietPhieuMua.Enabled = btn_XoaChiTietPhieuMua.Enabled = btn_Load.Enabled = true;
            }
        }

        private void gvCTPN_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idCTPN = int.Parse(gvCTPN.GetRowCellValue(e.RowHandle, "idCTPN").ToString());
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
                layDSCTPhieuNhap();
            }
        }

        private void btn_Load_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khoiTao();
            layDSNguyenLieu();
            phieuNhap = null;

            List<CTPhieuMuaModel> listCTPN = new List<CTPhieuMuaModel>();
            gcCTPN.DataSource = listCTPN;

            panelControl2.Enabled = btn_ThemPhieuMua.Enabled = true;
            btn_ThemChiTietPhieuMua.Enabled = btn_XoaChiTietPhieuMua.Enabled = btn_Load.Enabled = false;
        }

        private void btn_ThemChiTietPhieuMua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mesCTPN = new mesCTPN(maNL, tenNL, donVi, phieuNhap.idPN);
            Program.mesCTPN.Show();
            Program.frmChinh.Enabled = false;
        }
    }
}
