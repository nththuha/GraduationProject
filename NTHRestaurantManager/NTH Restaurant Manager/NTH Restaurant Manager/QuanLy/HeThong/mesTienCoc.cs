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
    public partial class mesTienCoc : Form
    {
        TienCocRepository _repository = new TienCocRepository();
        TienCocModel tienCoc;

        int giaSauThue;
        int idPDT;

        public mesTienCoc(String hoTenKH, String sdt, int giaSauThue, int idPDT)
        {
            InitializeComponent();
            txt_HoTenKH.Text = hoTenKH;
            txt_SDT.Text = sdt;
            this.giaSauThue = giaSauThue;
            this.idPDT = idPDT;
        }

        private void mesTienCoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (txt_HoTenKH.Text.Trim().Equals(""))
            {
                MessageBox.Show("Họ tên khách hàng không được để trống!", "Thông báo");
                txt_HoTenKH.Focus();
                return;
            }
            if (txt_SDT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số điện thoại khách hàng không được để trống!", "Thông báo");
                txt_SDT.Focus();
                return;
            }
            txt_SDT.Focus();
            int soTien = Program.doiSpinEditThanhInt(se_SoTien.Text);
            if(soTien < 0 || soTien > giaSauThue)
            {
                MessageBox.Show("Số tiền không hợp lý!", "Thông báo");
                se_SoTien.Focus();
                return;
            }
            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            tienCoc = new TienCocModel();
            tienCoc.idnv = Program.nhanVienDangDangNhap.idNV;
            tienCoc.hoTenKH = txt_HoTenKH.Text.Trim();
            tienCoc.sdt = txt_SDT.Text.Trim();
            tienCoc.idpdt = idPDT;
            tienCoc.triGia = soTien;
            tienCoc.ngay = now;
            themTienCoc();
        }

        private async void themTienCoc()
        {
            var check = await _repository.themTienCoc(tienCoc);
            if (check.Equals("false"))
            {
                MessageBox.Show("Thêm tiền cọc thất bại!", "Thông báo");
            }
            else if (check.Equals("money"))
            {
                MessageBox.Show("Số tiền cọc lớn hơn số tiền của phiếu đặt trước!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm tiền cọc thành công!", "Thông báo");
                Program.formPhieuDatTruoc.layDSTienCocTheoPDT(idPDT);
                this.Close();
            }
        }
    }
}
