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

        int idPDT;
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
            
        }
    }
}
