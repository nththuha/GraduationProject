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
    public partial class frmPhieuDatTruoc : Form
    {
        PhieuDatTruocRepository _repositoryPDT = new PhieuDatTruocRepository();
        CTDatMonTruocRepository _repositoryCTDMT = new CTDatMonTruocRepository();
        TienCocRepository _repositoryTC = new TienCocRepository();
        PhieuDatRepository _repositoryPD = new PhieuDatRepository();

        int num;

        PhieuDatTruocModel pdt;

        int tongCoc = 0;

        public frmPhieuDatTruoc()
        {
            InitializeComponent();
            this.de_Ngay.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.Mask.EditMask = "dd-MM-yyyy";
            khoiTao();
            layDSPhieuDatTheoNgay();
        }

        public async void layDSPhieuDatTheoNgay()
        {
            gcTC.DataSource = null;
            PhongNgay pn = new PhongNgay();
            pn.ngay = de_Ngay.DateTime.ToString("yyyy-MM-dd");
            try
            {
                var listPDT = await _repositoryPDT.layDSPhieuDatTruocTheoNgay(pn);
                for (int i = 0; i < listPDT.Count; i++)
                {
                    listPDT[i].ngayDat = listPDT[i].ngayDat.Substring(8, 2) + "-" + listPDT[i].ngayDat.Substring(5, 2) + "-" + listPDT[i].ngayDat.Substring(0, 4);
                    listPDT[i].ngayTao = listPDT[i].ngayTao.Substring(8, 2) + "-" + listPDT[i].ngayTao.Substring(5, 2) + "-" + listPDT[i].ngayTao.Substring(0, 4);
                }
                gcPDT.DataSource = listPDT;
                if(listPDT.Count > 0)
                {
                    layDSTienCocTheoPDT(listPDT[0].idPDT);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách phiếu đặt trước: " + e.Message, "Thông báo");
            }
        }

        public async void layDSTienCocTheoPDT(int idPDT)
        {
            tongCoc = 0;
            gcTC.DataSource = null;
            try
            {
                var listTC = await _repositoryTC.layDSTienCocTheoPDT(idPDT);
                for (int i = 0; i < listTC.Count; i++)
                {
                    listTC[i].ngay = listTC[i].ngay.Substring(8, 2) + "-" + listTC[i].ngay.Substring(5, 2) + "-" + listTC[i].ngay.Substring(0, 4);
                    tongCoc += listTC[i].triGia;
                }
                gcTC.DataSource = listTC;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách tiền cọc: " + e.Message, "Thông báo");
            }
        }

        private void khoiTao()
        {
            de_Ngay.DateTime = DateTime.Now;
        }

        private void de_Ngay_EditValueChanged(object sender, EventArgs e)
        {
            gcTC.DataSource = null;
            layDSPhieuDatTheoNgay();
        }

        private void btn_CapNhatDatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.pdt = new PhieuDatTruocModel();
            Program.pdt.idPDT = int.Parse(gvPDT.GetRowCellValue(num, "idPDT").ToString());
            Program.pdt.idkh = int.Parse(gvPDT.GetRowCellValue(num, "idkh").ToString());
            Program.pdt.hoTenKH = gvPDT.GetRowCellValue(num, "hoTenKH").ToString();
            Program.pdt.sdt = gvPDT.GetRowCellValue(num, "sdt").ToString();
            Program.pdt.idnv = int.Parse(gvPDT.GetRowCellValue(num, "idnv").ToString());
            String ngayDat = gvPDT.GetRowCellValue(num, "ngayDat").ToString();
            Program.pdt.ngayDat = ngayDat.Substring(6, 4) + "-" + ngayDat.Substring(3, 2) + "-" + ngayDat.Substring(0, 2);
            Program.pdt.gioDat = int.Parse(gvPDT.GetRowCellValue(num, "gioDat").ToString());
            String ngayTao = gvPDT.GetRowCellValue(num, "ngayTao").ToString();
            Program.pdt.ngayTao = ngayTao.Substring(6, 4) + "-" + ngayTao.Substring(3, 2) + "-" + ngayTao.Substring(0, 2);
            Program.frmChinh.btn_DatBanTruoc_ItemClick(sender, e);
            Program.formDatBanTruoc.setUp();
        }

        private void gvPDT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            num = e.RowHandle;
            layDSTienCocTheoPDT(int.Parse(gvPDT.GetRowCellValue(num, "idPDT").ToString()));
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSPhieuDatTheoNgay();
        }

        private void btn_InHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idPDT = int.Parse(gvPDT.GetRowCellValue(num, "idPDT").ToString());
            layPhieuDatCoc(idPDT);
        }

        private async void layPhieuDatCoc(int idPDT)
        {
            PhieuDatCocModel pdc = await _repositoryCTDMT.layDSDatMonTheoPhieuDatTruoc(idPDT);
            if (pdc == null)
            {
                MessageBox.Show("Tạo phiếu đặt cọc thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tạo phiếu đặt cọc thành công!", "Thông báo");
                rpHopDong rp = new rpHopDong();

                rp.lb_HoTenKH.Text = pdc.hoTenKH;
                rp.lb_SDT.Text = pdc.sdt;
                rp.lb_NgayDat.Text = pdc.ngayDat.Substring(8, 2) + "-" + pdc.ngayDat.Substring(5, 2) + "-" + pdc.ngayDat.Substring(0, 4);
                rp.lb_NhanVien.Text = pdc.hoTenNV;
                rp.lb_Tien.Text = String.Format("{0:0,0}", pdc.gia);
                rp.lb_Thue.Text = String.Format("{0:0,0}", (pdc.gia * 0.1));
                rp.lb_TongTien.Text = String.Format("{0:0,0}", pdc.giaSauThue);
                rp.lb_TienChu.Text = pdc.giaChu;

                DataTable dt = new DataTable("listCTDMT");
                dt.Columns.Add("tenma", typeof(String));
                dt.Columns.Add("soLuong", typeof(int));
                dt.Columns.Add("giaTungMon", typeof(String));
                dt.Columns.Add("gia", typeof(String));
                List<CTDatMonTruocModel> listCTDMT = pdc.listCTDMT;
                foreach (CTDatMonTruocModel i in listCTDMT)
                {
                    var giaTungMon = String.Format("{0:0,0}", i.giaTungMon);
                    var gia = String.Format("{0:0,0}", i.gia);
                    dt.Rows.Add(new Object[] { i.tenma, i.soluong, giaTungMon, gia });
                }

                List<TienCocModel> listTC = pdc.listTC;
                int tong = 0;
                if(listTC.Count == 1)
                {
                    tong += listTC[0].triGia;
                    var tien = String.Format("{0:0,0}", listTC[0].triGia);
                    rp.tc_HoTenKH1.Text = listTC[0].hoTenKH;
                    rp.tc_SDT1.Text = listTC[0].sdt;
                    rp.tc_NgayCoc1.Text = listTC[0].ngay.Substring(8, 2) + "-" + listTC[0].ngay.Substring(5, 2) + "-" + listTC[0].ngay.Substring(0, 4);
                    rp.tc_SoTien1.Text = tien;
                }
                else if(listTC.Count == 2)
                {
                    tong += listTC[0].triGia + listTC[1].triGia;
                    var tien = String.Format("{0:0,0}", listTC[0].triGia);
                    rp.tc_HoTenKH1.Text = listTC[0].hoTenKH;
                    rp.tc_SDT1.Text = listTC[0].sdt;
                    rp.tc_NgayCoc1.Text = listTC[0].ngay.Substring(8, 2) + "-" + listTC[0].ngay.Substring(5, 2) + "-" + listTC[0].ngay.Substring(0, 4);
                    rp.tc_SoTien1.Text = tien;
                    tien = String.Format("{0:0,0}", listTC[1].triGia);
                    rp.tc_HoTenKH2.Text = listTC[1].hoTenKH;
                    rp.tc_SDT2.Text = listTC[1].sdt;
                    rp.tc_NgayCoc2.Text = listTC[1].ngay.Substring(8, 2) + "-" + listTC[1].ngay.Substring(5, 2) + "-" + listTC[1].ngay.Substring(0, 4);
                    rp.tc_SoTien2.Text = tien;
                }
                rp.lb_TienCoc.Text = String.Format("{0:0,0}", tong);
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                rp.DataSource = ds;
                ReportPrintTool print = new ReportPrintTool(rp);
                print.ShowPreviewDialog();
            }
        }

        private void btn_CocTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mesTienCoc = new mesTienCoc(gvPDT.GetRowCellValue(num, "hoTenKH").ToString(), gvPDT.GetRowCellValue(num, "sdt").ToString(), int.Parse(gvPDT.GetRowCellValue(num, "giaSauThue").ToString()), int.Parse(gvPDT.GetRowCellValue(num, "idPDT").ToString()), tongCoc);
            Program.mesTienCoc.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btn_Huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idPDT = int.Parse(gvPDT.GetRowCellValue(num, "idPDT").ToString());
            String hoTenKH = gvPDT.GetRowCellValue(num, "hoTenKH").ToString();
            String sdt = gvPDT.GetRowCellValue(num, "sdt").ToString();
            String ngayDat = gvPDT.GetRowCellValue(num, "ngayDat").ToString();
            String ngayTao = gvPDT.GetRowCellValue(num, "ngayTao").ToString();
            int giaSauThue = int.Parse(gvPDT.GetRowCellValue(num, "giaSauThue").ToString());

            Program.mesHuyPhieuDatTruoc = new mesHuyPhieuDatTruoc(hoTenKH, sdt, ngayTao, ngayDat, giaSauThue, tongCoc, idPDT);
            Program.mesHuyPhieuDatTruoc.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btn_ChuyenThanhPhieuDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            String ngay = de_Ngay.DateTime.ToString("yyyy-MM-dd");
            if (now.CompareTo(ngay) != 0)
            {
                MessageBox.Show("Ngày phải bằng ngày hiện tại", "Thông báo");
                de_Ngay.Focus();
                return;
            }
            int gioHT = int.Parse(aDate.ToString("HH"));
            int gioDat = int.Parse(gvPDT.GetRowCellValue(num, "gioDat").ToString());
            if(gioDat > gioHT || gioDat < gioHT)
            {
                MessageBox.Show("Giờ đặt không hợp lý", "Thông báo");
                return;
            }

            pdt = new PhieuDatTruocModel();
            pdt.idPDT = int.Parse(gvPDT.GetRowCellValue(num, "idPDT").ToString());
            pdt.idnv = Program.nhanVienDangDangNhap.idNV;
            themPhieuDatTruocTrenPhieuDatTruoc();
        }

        private async void themPhieuDatTruocTrenPhieuDatTruoc()
        {
            var check = await _repositoryPD.themPhieuDatDuaTrenPhieuDatTruoc(pdt);
            if (check.Equals("false"))
            {
                MessageBox.Show("Chuyển phiếu đặt thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Chuyển phiếu đặt thành công", "Thông báo");
                layDSPhieuDatTheoNgay();
            }
        }
    }
}