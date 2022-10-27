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
    public partial class mesKhachHang : Form
    {
        KhachHangRepository _repository = new KhachHangRepository();
        int num;

        public mesKhachHang()
        {
            InitializeComponent();
            layDSKhachHang();
        }

        private async void layDSKhachHang()
        {
            try
            {
                var listKH = await _repository.layDSKhachHang();
                gcKH.DataSource = listKH;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách khách hàng: " + e.Message, "Thông báo");
            }
        }

        private void gvKH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            num = e.RowHandle;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            Program.khachHang = new Model.KhachHangModel();
            Program.khachHang.idKH = int.Parse(gvKH.GetRowCellValue(num, "idKH").ToString());
            Program.khachHang.hoTen = gvKH.GetRowCellValue(num, "hoTen").ToString();
            Program.khachHang.sdt = gvKH.GetRowCellValue(num, "sdt").ToString();
            Program.khachHang.cmnd = gvKH.GetRowCellValue(num, "cmnd").ToString();
            Program.formDatBanTruoc.txt_HoTenKH.Text = Program.khachHang.hoTen;
            this.Close();
        }

        private void mesKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }
    }
}
