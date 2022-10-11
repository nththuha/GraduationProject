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
    public partial class frmPhongBan : Form
    {
        PhongRepository _repositoryP = new PhongRepository();
        BanRepository _repositoryB = new BanRepository();
        String button;

        public frmPhongBan()
        {
            InitializeComponent();
            khoiTaoPhong();
            khoiTaoBan();
            layDSPhong();
            layDSBan();
        }

        public void khoiTaoPhong()
        {
            txt_MaPhong.Text = "";
            txt_TenPhong.Text = "";
        }

        public void khoiTaoBan()
        {
            txt_MaBan.Text = "";
            txt_TenBan.Text = "";
            se_SoGhe.Text = "0";
        }

        public async void layDSPhong()
        {
            try
            {
                var listP = await _repositoryP.layDSPhong();
                gcPhong.DataSource = listP;
                if (listP.Count > 0) setGiaTriPhong(0);
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi load danh sách phòng: " + e.Message, "Thông báo");
            }
        }

        public async void layDSBan()
        {
            try
            {
                var listB = await _repositoryB.layDSBan();
                gcBan.DataSource = listB;
                if (listB.Count > 0) setGiaTriBan(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách bàn: " + e.Message, "Thông báo");
            }
        }

        public void setGiaTriPhong(int num)
        {
            txt_MaPhong.Text = gvPhong.GetRowCellValue(num, "maPhong").ToString();
            txt_TenPhong.Text = gvPhong.GetRowCellValue(num, "tenPhong").ToString();
        }

        public void setGiaTriBan(int num)
        {
            txt_MaBan.Text = gvBan.GetRowCellValue(num, "maBan").ToString();
            txt_TenBan.Text = gvBan.GetRowCellValue(num, "tenBan").ToString();
            se_SoGhe.Text = gvBan.GetRowCellValue(num, "soGhe").ToString();
        }

        private void gvPhong_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            setGiaTriPhong(e.RowHandle);
        }

        private void gvBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            setGiaTriBan(e.RowHandle);
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Thêm";

        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Cập nhật";
        }
    }
}
