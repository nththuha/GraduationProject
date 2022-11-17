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
        PhieuMuaNguyenLieuRepository _repositoryPM = new PhieuMuaNguyenLieuRepository();
        PhieuNhapNguyenLieuRepository _repositoryPN = new PhieuNhapNguyenLieuRepository();
        CTPhieuMuaRepository _repositoryCTPM = new CTPhieuMuaRepository();

        PhieuMuaNguyenLieuModel pmnl;

        int idPM;

        public frmPhieuMua()
        {
            InitializeComponent();
            this.de_Ngay.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.Mask.EditMask = "dd-MM-yyyy";
            de_Ngay.DateTime = DateTime.Now;

            layDSPhieuMuaNguyenLieu();
        }

        private async void layDSPhieuMuaNguyenLieu()
        {
            try
            {
                var listPM = await _repositoryPM.layDSPhieuMuaNguyenLieu();
                for (int i = 0; i < listPM.Count; i++)
                {
                    listPM[i].ngay = listPM[i].ngay.Substring(8, 2) + "-" + listPM[i].ngay.Substring(5, 2) + "-" + listPM[i].ngay.Substring(0, 4);
                }
                gcPM.DataSource = listPM;
                if(listPM.Count > 0)
                {
                    idPM = listPM[0].idPM;
                    layDSCTPhieuMuaTheoPhieuMua();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy ds phiếu mua nguyên liệu: " + e.Message, "Thông báo");
            }
        }

        private async void layDSCTPhieuMuaTheoPhieuMua()
        {
            try
            {
                var listCTPM = await _repositoryCTPM.layDSCTPhieuMuaTheoPhieuMua(idPM);
                gcCTPM.DataSource = listCTPM;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy ds chi tiết phiếu mua nguyên liệu: " + e.Message, "Thông báo");
            }
        }

        private async void lapPhieuMuaNguyenLieuTheoNgay()
        {
            List<CTPhieuMuaModel> listCTPM = await _repositoryPM.layDSNguyenLieuCanMua(pmnl);
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
                layDSPhieuMuaNguyenLieu();
            }
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pmnl = new PhieuMuaNguyenLieuModel();
            String ngay = de_Ngay.DateTime.ToString("yyyy-MM-dd");
            pmnl.ngay = ngay;
            pmnl.idnv = Program.nhanVienDangDangNhap.idNV;
            lapPhieuMuaNguyenLieuTheoNgay();
        }

        private void gvPM_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idPM = int.Parse(gvPM.GetRowCellValue(e.RowHandle, "idPM").ToString());
            layDSCTPhieuMuaTheoPhieuMua();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSPhieuMuaNguyenLieu();
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Chuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chuyenPhieuMuaThanhPhieuNhap(sender, e);
        }

        private async void chuyenPhieuMuaThanhPhieuNhap(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var check = await _repositoryPN.chuyenPhieuMuaThanhPhieuNhap(idPM);
            if (check.Equals("false"))
            {
                MessageBox.Show("Chuyển thất bại!", "Thông báo");
                return;
            }
            Program.frmChinh.btn_PhieuNhap_ItemClick(sender, e);
            Program.formPhieuNhap.khoiTao(int.Parse(check));
        }
    }
}
