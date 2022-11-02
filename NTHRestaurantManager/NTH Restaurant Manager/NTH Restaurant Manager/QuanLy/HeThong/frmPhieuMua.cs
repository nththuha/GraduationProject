using DevExpress.XtraReports.UI;
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
    public partial class frmPhieuMua : Form
    {
        PhieuMuaNguyenLieuRepository _repository = new PhieuMuaNguyenLieuRepository();
        PhieuMuaNguyenLieuModel pmnl;

        public frmPhieuMua()
        {
            InitializeComponent();
            this.de_Ngay.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.Mask.EditMask = "dd-MM-yyyy";
            de_Ngay.DateTime = DateTime.Now;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            pmnl = new PhieuMuaNguyenLieuModel();
            String ngay = de_Ngay.DateTime.ToString("yyyy-MM-dd");
            pmnl.ngay = ngay;
            pmnl.idnv = Program.nhanVienDangDangNhap.idNV;
            lapPhieuMuaNguyenLieuTheoNgay();
        }

        private async void lapPhieuMuaNguyenLieuTheoNgay()
        {
            List<CTPhieuMuaModel> listCTPM = await _repository.layDSBanTheoPhongTheoNgay(pmnl);
            if (listCTPM == null)
            {
                MessageBox.Show("Lập phiếu đi chợ thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lập phiếu đi chợ thành công!", "Thông báo");
                rpPhieuMuaNguyenLieu rp = new rpPhieuMuaNguyenLieu();

                rp.lb_Ngay.Text = pmnl.ngay.Substring(8, 2) + "-" + pmnl.ngay.Substring(5, 2) + "-" + pmnl.ngay.Substring(0, 4);
                rp.lb_NhanVien.Text = Program.nhanVienDangDangNhap.hoTen;

                DataTable dt = new DataTable("listCTPM");
                dt.Columns.Add("tennl", typeof(String));
                dt.Columns.Add("soLuong", typeof(String));
                dt.Columns.Add("donVi", typeof(String));
                foreach(CTPhieuMuaModel i in listCTPM)
                {
                    String sl = String.Format("{0:0,0}", i.soLuong);
                    dt.Rows.Add(new Object[] { i.tennl, sl, i.donVi});
                }

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                rp.DataSource = ds;
                ReportPrintTool print = new ReportPrintTool(rp);
                print.ShowPreviewDialog();
            }
        }
    }
}
