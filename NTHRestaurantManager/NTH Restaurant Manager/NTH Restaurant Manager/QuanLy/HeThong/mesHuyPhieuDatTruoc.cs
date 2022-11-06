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
    public partial class mesHuyPhieuDatTruoc : Form
    {
        HuyPhieuDatTruocRepository _repository = new HuyPhieuDatTruocRepository();
        HuyPhieuDatTruocModel hpdt = new HuyPhieuDatTruocModel();

        int idPDT;
        String hoTenKH;
        String sdt;
        String ngayDat;
        String ngayTao;
        int giaSauThue;
        int coc;

        public mesHuyPhieuDatTruoc(String hoTenKH, String sdt, String ngayTao, String ngayDat, int giaSauThue, int coc, int idPDT)
        {
            InitializeComponent();
            this.de_NgayDat.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayDat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayDat.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayDat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayDat.Properties.Mask.EditMask = "dd-MM-yyyy";

            this.de_NgayTao.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayTao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayTao.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayTao.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayTao.Properties.Mask.EditMask = "dd-MM-yyyy";

            this.hoTenKH = hoTenKH;
            this.sdt = sdt;
            this.ngayDat = ngayDat;
            this.ngayTao = ngayTao;
            this.giaSauThue = giaSauThue;
            this.coc = coc;
            this.idPDT = idPDT;
            khoiTao();
        }

        private void khoiTao()
        {
            txt_HoTenKH.Text = hoTenKH;
            txt_SDT.Text = sdt;
            de_NgayDat.DateTime = DateTime.ParseExact(ngayDat, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            de_NgayTao.DateTime = DateTime.ParseExact(ngayTao, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            se_TongTien.Text = giaSauThue.ToString();
            se_TongCoc.Text = coc.ToString();
        }

        private void mesHuyPhieuDatTruoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            label1.Focus();
            int tien = Program.doiSpinEditThanhInt(se_SoTienHoan.Text);
            if(tien < 0 || tien > coc)
            {
                MessageBox.Show("Số tiền hoàn lại không hợp lệ!", "Thông báo");
                return;
            }
            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            hpdt = new HuyPhieuDatTruocModel();
            hpdt.idnv = Program.nhanVienDangDangNhap.idNV;
            hpdt.soTien = tien;
            hpdt.idpdt = idPDT;
            hpdt.ngay = now;
            themHuyPhieuDatTruoc();
        }

        private async void themHuyPhieuDatTruoc()
        {
            var check = await _repository.themHuyPhieuDatTruoc(hpdt);
            if (check.Equals("false")) MessageBox.Show("Hủy phiếu đặt trước thất bại!", "Thông báo");
            else
            {
                MessageBox.Show("Hủy phiếu đặt trước thành công!", "Thông báo");
                Program.formPhieuDatTruoc.layDSPhieuDatTheoNgay();
                this.Close();
            }
        }

        private void cb_SoTienHoan_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_SoTienHoan.Checked)
            {
                se_SoTienHoan.Text = coc.ToString();
                se_SoTienHoan.Enabled = false;
            }
            else
            {
                se_SoTienHoan.Enabled = true;
            }
        }
    }
}
