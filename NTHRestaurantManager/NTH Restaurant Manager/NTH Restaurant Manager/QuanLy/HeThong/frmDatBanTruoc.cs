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
    public partial class frmDatBanTruoc : Form
    {
        public frmDatBanTruoc()
        {
            InitializeComponent();
            this.de_NgayDat.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayDat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayDat.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayDat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayDat.Properties.Mask.EditMask = "dd-MM-yyyy";
            khoiTao();
        }

        private void khoiTao()
        {
            txt_HoTenKH.Text = "";
            de_NgayDat.DateTime = DateTime.Now;
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_HoTenKH.Text.Trim().Equals(""))
            {
                MessageBox.Show("Khách hàng không được để trống!", "Thông báo");
                txt_HoTenKH.Focus();
                return;
            }
            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            String ngay = de_NgayDat.DateTime.ToString("yyyy-MM-dd");
            if (now.CompareTo(ngay) >= 0)
            {
                MessageBox.Show("Ngày đặt phải lớn hơn ngày hiện tại", "Thông báo");
                return;
            }
            themPhieuDatTruoc();
        }

        private async void themPhieuDatTruoc()
        {
            
        }

        private void btn_ChonKH_Click(object sender, EventArgs e)
        {
            Program.mesKhachHang = new mesKhachHang();
            Program.mesKhachHang.Show();
            Program.frmChinh.Enabled = false;
        }
    }
}
