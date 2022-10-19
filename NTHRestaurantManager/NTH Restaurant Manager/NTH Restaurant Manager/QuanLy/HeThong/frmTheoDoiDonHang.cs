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
    public partial class frmTheoDoiDonHang : Form
    {
        PhieuDatRepository _repositoryPD = new PhieuDatRepository();
        CTDatMonRepository _repositoryCTDM = new CTDatMonRepository();

        int idPD;

        public frmTheoDoiDonHang()
        {
            InitializeComponent();
            layDSPhieuDat();
        }

        private async void layDSPhieuDat()
        {
            try
            {
                var listPD = await _repositoryPD.layDSPhieuDat();
                gcPD.DataSource = listPD;
                if(listPD.Count > 0)
                {
                    idPD = listPD[0].idPD;
                    layDSCTDatMonTheoPhieuDat();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi load danh sách phiếu đặt: " + e.Message, "Thông báo");
            }
        }

        private async void layDSCTDatMonTheoPhieuDat()
        {
            try
            {
                var listCTDM = await _repositoryCTDM.layDSCTDatMonTheoPhieuDat(idPD);
                gcCTDM.DataSource = listCTDM;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách chi tiết đặt món: " + e.Message, "Thông báo");
            }
        }

        private void gvPD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idPD = int.Parse(gvPD.GetRowCellValue(e.RowHandle, "idPD").ToString());
            layDSCTDatMonTheoPhieuDat();
        }
    }
}
