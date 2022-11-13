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
    public partial class frmTheoDoiDonHangPDT : Form
    {
        PhieuDatRepository _repositoryPD = new PhieuDatRepository();
        CTDatBanTruocRepository _repositoryCTDBT = new CTDatBanTruocRepository();
        CTThucDonRepository _repositoryCTTD = new CTThucDonRepository();

        int idPD;
        String idPDT;
        int idCTDBT;
        int idCTTD;

        public frmTheoDoiDonHangPDT()
        {
            InitializeComponent();
            layDSPhieuDat();
        }

        public async void layDSPhieuDat()
        {
            gcCTDBT.DataSource = null;
            gcCTDBT.DataSource = null;
            try
            {
                var listPD = await _repositoryPD.layDSPhieuDatPhieuDatTruoc();
                gcPD.DataSource = listPD;
                if(listPD.Count > 0)
                {
                    idPD = listPD[0].idPD;
                    idPDT = listPD[0].idPDT;
                    layDSCTDatBanTruoc();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy ds phiếu đặt: " + e.Message, "Thông báo");
            }
        }

        private async void layDSCTDatBanTruoc()
        {
            try
            {
                var listCTDBT = await _repositoryCTDBT.layDSCTDatBanTruocTheoPDT(int.Parse(idPDT));
                gcCTDBT.DataSource = listCTDBT;
                if(listCTDBT.Count > 0)
                {
                    idCTDBT = listCTDBT[0].idCTDBT;
                    layDSCTThucDon();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy ds chi tiết đặt bàn trước: " + e.Message, "Thông báo");
            }
        }

        private async void layDSCTThucDon()
        {
            try
            {
                var listCTTD = await _repositoryCTTD.layDSCTThucDonTheoCTDatBanTruoc(idCTDBT);
                gcCTTD.DataSource = listCTTD;
                if (listCTTD.Count > 0)
                {
                    idCTTD = listCTTD[0].idCTTD;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy ds chi tiết thực đơn: " + e.Message, "Thông báo");
            }
        }

        private void gvPD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idPD = int.Parse(gvPD.GetRowCellValue(e.RowHandle, "idPD").ToString());
            idPDT = gvPD.GetRowCellValue(e.RowHandle, "idPDT").ToString();
            layDSCTDatBanTruoc();
        }

        private void gvCTDBT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idCTDBT = int.Parse(gvCTDBT.GetRowCellValue(e.RowHandle, "idCTDBT").ToString());
            layDSCTThucDon();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSPhieuDat();
        }

        private void btn_XuatHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime aDate = DateTime.Now;
            String ngay = aDate.ToString("yyyy-MM-dd");
            String ngayGio = aDate.ToString("yy-MM-dd H m s");
            Program.hoaDon = new HoaDonModel();
            Program.hoaDon.maHD = "HD" + ngayGio;
            Program.hoaDon.ngay = ngay;
            List<PhieuDatModel> listPD = new List<PhieuDatModel>();
            PhieuDatModel pd = new PhieuDatModel(); pd.idPD = idPD;
            listPD.Add(pd);
            Program.hoaDon.phieudatList = listPD;
            Program.hoaDon.idnv = Program.nhanVienDangDangNhap.idNV;

            Program.mesKhachHang_HD_PDT = new mesKhacHang_HD_PDT();
            Program.mesKhachHang_HD_PDT.Show();
            Program.frmChinh.Enabled = false;
        }
    }
}
