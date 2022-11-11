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
    public partial class mesKhachHang_HD : Form
    {
        HoaDonRepository _repositoryHD = new HoaDonRepository();

        public mesKhachHang_HD()
        {
            InitializeComponent();
        }

        private void mesKhachHang_HD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!txt_HoTenKH.Text.Trim().Equals(""))
            {
                Program.hoaDon.hotenkh = txt_HoTenKH.Text.Trim();
            }
            if (!txt_MaSoThue.Text.Trim().Equals(""))
            {
                Program.hoaDon.masothue = txt_MaSoThue.Text.Trim();
            }
            lapHoaDon();
        }

        private async void lapHoaDon()
        {
            HoaDonPDModel hd = await _repositoryHD.themHoaDon(Program.hoaDon);
            if(hd == null)
            {
                MessageBox.Show("Lập hóa đơn thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lập hóa đơn thành công!", "Thông báo");
            }
        }
    }
}
