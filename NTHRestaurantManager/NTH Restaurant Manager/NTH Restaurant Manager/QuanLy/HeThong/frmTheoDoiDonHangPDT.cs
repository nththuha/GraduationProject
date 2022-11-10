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

        String idPDT;
        int idCTDBT;
        int idCTTD;

        public frmTheoDoiDonHangPDT()
        {
            InitializeComponent();
            layDSPhieuDat();
        }

        private async void layDSPhieuDat()
        {
            try
            {
                var listPD = await _repositoryPD.layDSPhieuDatPhieuDatTruoc();
                gcPD.DataSource = listPD;
                if(listPD.Count > 0)
                {
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
            
        }

        private void gvPD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idPDT = gvPD.GetRowCellValue(e.RowHandle, "idPDT").ToString();
            layDSCTDatBanTruoc();
        }

        private void gvCTDBT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idCTDBT = int.Parse(gvCTDBT.GetRowCellValue(e.RowHandle, "idCTDBT").ToString());
            layDSCTThucDon();
        }
    }
}
