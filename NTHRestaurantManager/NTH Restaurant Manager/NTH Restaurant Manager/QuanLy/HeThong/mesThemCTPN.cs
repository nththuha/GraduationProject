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
    public partial class mesThemCTPN : Form
    {
        NguyenLieuRepository _repositoryNL = new NguyenLieuRepository();
        CTPhieuNhapRepository _repositoryCTPN = new CTPhieuNhapRepository();

        int idPN;
        String maNL;

        CTPhieuNhapModel ctPN;

        public mesThemCTPN(int idPN)
        {
            InitializeComponent();
            this.idPN = idPN;
            loadDSNguyenLieu();
        }

        private async void loadDSNguyenLieu()
        {
            try
            {
                var listNL = await _repositoryNL.layDSNguyenLieu();
                gcNL.DataSource = listNL;
                if(listNL.Count > 0)
                {
                    setGiaTri(0);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi load ds nguyên liệu: " + e, "Thông báo");
            }
        }

        private void setGiaTri(int num)
        {
            maNL = gvNL.GetRowCellValue(num, "maNL").ToString();
            txt_TenNL.Text = gvNL.GetRowCellValue(num, "tenNL").ToString();
            txt_DonVi.Text = gvNL.GetRowCellValue(num, "donVi").ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenNL.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên nguyên liệu không được bỏ trống", "Thông báo");
                return;
            }
            if (txt_DonVi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Đơn vị không được bỏ trống", "Thông báo");
                return;
            }
            label1.Focus();
            int soLuong = Program.doiSpinEditThanhInt(se_SoLuong.Text);
            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lý", "Thông báo");
                se_SoLuong.Focus();
                return;
            }
            int gia = Program.doiSpinEditThanhInt(se_Gia.Text);
            if (gia <= 0)
            {
                MessageBox.Show("Giá lượng không hợp lý", "Thông báo");
                se_Gia.Focus();
                return;
            }
            if (Program.formPhieuNhap.kiemTraTrungCTPN(maNL))
            {
                MessageBox.Show("Nguyên liệu này đã tồn tại ở phiếu nhập, bạn có thể hiệu chỉnh thông tin", "Thông báo");
                return;
            }
            ctPN = new CTPhieuNhapModel();
            ctPN.manl = maNL;
            ctPN.soLuong = soLuong;
            ctPN.gia = gia;
            ctPN.idpn = idPN;
            themCTPN();
        }

        private async void themCTPN()
        {
            var check = await _repositoryCTPN.themCTPhieuNhap(ctPN);
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

        private void gvNL_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            setGiaTri(e.RowHandle);
        }

        private void mesThemCTPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }
    }
}
