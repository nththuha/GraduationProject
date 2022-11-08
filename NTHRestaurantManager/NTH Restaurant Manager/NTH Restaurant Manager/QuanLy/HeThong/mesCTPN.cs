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
    public partial class mesCTPN : Form
    {
        String maNL;
        int idPN;

        CTPhieuNhapRepository _repository = new CTPhieuNhapRepository();
        CTPhieuNhapModel ctPhieuNhap;

        public mesCTPN(String maNL, String tenNL, String donVi, int idPN)
        {
            InitializeComponent();
            this.maNL = maNL;
            this.idPN = idPN;

            txt_TenNL.Text = tenNL;
            txt_DonVi.Text = donVi;
        }

        private async void themCTPhieuNhap()
        {
            var check = await _repository.themCTPhieuNhap(ctPhieuNhap);
            if (check.Equals("false"))
            {
                MessageBox.Show("Thêm chi tiết phiếu nhập thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm chi tiết phiếu nhập thành công!", "Thông báo");
                Program.formPhieuNhap.layDSCTPhieuNhap();
                this.Close();
            }
        }

        private void mesCTPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            label1.Focus();
            int soLuong = Program.doiSpinEditThanhInt(se_SoLuong.Text);
            if(soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lý", "Thông báo");
                se_SoLuong.Focus();
                return;
            }
            int gia = Program.doiSpinEditThanhInt(se_Gia.Text);
            if (gia < 0)
            {
                MessageBox.Show("Giá không hợp lý", "Thông báo");
                se_SoLuong.Focus();
                return;
            }
            ctPhieuNhap = new CTPhieuNhapModel();
            ctPhieuNhap.idpn = idPN;
            ctPhieuNhap.manl = maNL;
            ctPhieuNhap.soLuong = soLuong;
            ctPhieuNhap.gia = gia;

            themCTPhieuNhap();
        }
    }
}
