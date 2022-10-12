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
    public partial class frmChiTietPhong : Form
    {
        PhongRepository _repositoryP = new PhongRepository();
        BanRepository _repositoryB = new BanRepository();
        CTBanRepository _repositoryCTB = new CTBanRepository();

        String maPhong;
        String maBan;

        public frmChiTietPhong()
        {
            InitializeComponent();
            layDSPhong();
            layDSBan();
        }

        private async void layDSPhong()
        {
            try
            {
                var listP = await _repositoryP.layDSPhong();
                gcPhong.DataSource = listP;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách phòng: " + e.Message, "Thông báo");
            }
        }

        private async void layDSBan()
        {
            try
            {
                var listB = await _repositoryB.layDSBan();
                gcBan.DataSource = listB;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách bàn: " + e.Message, "Thông báo");
            }
        }

        private void gvPhong_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            maPhong = gvPhong.GetRowCellValue(e.RowHandle, "maPhong").ToString();
        }

        private void gvBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            maBan = gvBan.GetRowCellValue(e.RowHandle, "maBan").ToString();
        }

        private void gvCTBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }
    }
}
