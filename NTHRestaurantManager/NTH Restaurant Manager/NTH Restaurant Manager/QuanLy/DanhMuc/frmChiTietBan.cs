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
    public partial class frmChiTietPhong : Form
    {
        PhongRepository _repositoryP = new PhongRepository();
        BanRepository _repositoryB = new BanRepository();
        CTBanRepository _repositoryCTB = new CTBanRepository();

        String maPhong;
        String maBan;
        int soGhe;
        int idCTB;

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
                if(listP.Count > 0)
                {
                    maPhong = listP[0].maPhong;
                    layDSChiTietBanTheoPhong();
                }
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
                if(listB.Count > 0)
                {
                    maBan = listB[0].maBan;
                    soGhe = listB[0].soGhe;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách bàn: " + e.Message, "Thông báo");
            }
        }

        private async void layDSChiTietBanTheoPhong()
        {
            try
            {
                var listCTB = await _repositoryCTB.layDSCTBanTheoPhong(maPhong);
                gcCTBan.DataSource = listCTB;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load chi tiết bàn: " + e.Message, "Thông báo");
            }
        }

        private void gvPhong_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            maPhong = gvPhong.GetRowCellValue(e.RowHandle, "maPhong").ToString();
            layDSChiTietBanTheoPhong();
        }

        private void gvBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            maBan = gvBan.GetRowCellValue(e.RowHandle, "maBan").ToString();
        }

        private void gvCTBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idCTB = int.Parse(gvCTBan.GetRowCellValue(e.RowHandle, "idCTB").ToString());
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSPhong();
            layDSBan();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (maPhong.Equals(""))
            {
                MessageBox.Show("Bạn cần chọn phòng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (maBan.Equals(""))
            {
                MessageBox.Show("Bạn cần chọn bàn", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            themChiTietBan();
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa " + maPhong + " và " + maBan + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaChiTietBan();
            }
        }

        private async void themChiTietBan()
        {
            CTBanModel ctBan = new CTBanModel();
            ctBan.maban = maBan;
            ctBan.maphong = maPhong;
            ctBan.soGhe = soGhe;
            String check = await _repositoryCTB.themCTBan(ctBan);
            if (check.Equals("false")) MessageBox.Show("Thêm chi tiết bàn thất bại!", "Thông báo");
            else MessageBox.Show("Thêm chi tiết bàn thành công!", "Thông báo");
            layDSChiTietBanTheoPhong();
        }

        private async void xoaChiTietBan()
        {
            String check = await _repositoryCTB.xoaCTBan(idCTB);
            if (check.Equals("false")) MessageBox.Show("Xóa chi tiết bàn thất bại!", "Thông báo");
            else MessageBox.Show("Xóa chi tiết bàn thành công!", "Thông báo");
            layDSChiTietBanTheoPhong();
        }
    }
}
