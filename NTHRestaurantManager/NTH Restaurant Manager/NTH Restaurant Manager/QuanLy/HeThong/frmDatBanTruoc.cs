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
    public partial class frmDatBanTruoc : Form
    {
        PhieuDatTruocRepository _repositoryPDT = new PhieuDatTruocRepository();
        PhongRepository _repositoryP = new PhongRepository();
        CTBanRepository _repositoryCTB = new CTBanRepository();
        CTDatBanTruocRepository _repositoryCTDBT = new CTDatBanTruocRepository();
        ThucDonRepository _repositoryTD = new ThucDonRepository();
        CTDatMonTruocRepository _repositoryCTDMT = new CTDatMonTruocRepository();

        CTDatBanTruocModel ctdbt;

        String maPhong;
        String maBan;
        String trangThai;
        int idTD;
        int idCTDBT;

        public frmDatBanTruoc()
        {
            InitializeComponent();
            setUp();
            this.de_NgayDat.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayDat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayDat.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayDat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayDat.Properties.Mask.EditMask = "dd-MM-yyyy";
            khoiTao();
        }

        public void setUp()
        {
            if (Program.pdt == null)
            {
                btn_ThemPhieuDat.Enabled = panelControl4.Enabled = true;
                btn_ThemChiTietDatBan.Enabled = btn_XoaChiTietDatBan.Enabled = btn_Load.Enabled = btn_InHopDong.Enabled = false;
            }
            else
            {
                txt_HoTenKH.Text = Program.pdt.hoTenKH;
                String ngayDat = Program.pdt.ngayDat;
                de_NgayDat.Text = ngayDat.Substring(8, 2) + "-" + ngayDat.Substring(5, 2) + "-" + ngayDat.Substring(0, 4); ;
                btn_ThemPhieuDat.Enabled = panelControl4.Enabled = false;
                btn_ThemChiTietDatBan.Enabled = btn_XoaChiTietDatBan.Enabled = btn_Load.Enabled = btn_InHopDong.Enabled = true;
                layDSPhong();
                layDSThucDon();
                layDSCTDatBanTruoc();
            }
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
            Program.pdt = new PhieuDatTruocModel();
            Program.pdt.idkh = Program.khachHang.idKH;
            Program.pdt.idnv = Program.nhanVienDangDangNhap.idNV;
            Program.pdt.ngayDat = ngay;
            Program.pdt.ngayTao = now;

            themPhieuDatTruoc();
            panelControl4.Enabled = btn_ThemPhieuDat.Enabled = false;
            btn_ThemChiTietDatBan.Enabled = btn_XoaChiTietDatBan.Enabled = btn_Load.Enabled = btn_InHopDong.Enabled = true;
        }

        private async void themPhieuDatTruoc()
        {
            Program.pdt = await _repositoryPDT.themPhieuDatTruoc(Program.pdt);
            if (Program.pdt == null) MessageBox.Show("Đặt bàn trước thất bại!", "Thông báo");
            else MessageBox.Show("Lập phiếu đặt trước thành công\nBạn hãy chọn phòng, bàn và thực đơn nhé!", "Thông báo");      
            layDSPhong();
            layDSThucDon();
            layDSCTDatBanTruoc();
        }

        private async void layDSCTDatBanTruoc()
        {
            try
            {
                var listCTDBT = await _repositoryCTDBT.layDSCTDatBanTruocTheoPDT(Program.pdt.idPDT);
                gcCTDBT.DataSource = listCTDBT;
                if (listCTDBT.Count > 0)
                {
                    idCTDBT = listCTDBT[0].idCTDBT;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách bàn: " + e.Message, "Thông báo");
            }
        }

        private async void layDSThucDon()
        {
            try
            {
                var listTD = await _repositoryTD.layDSThucDon();
                for (int i = 0; i < listTD.Count; i++)
                {
                    listTD[i].ngayTao = listTD[i].ngayTao.Substring(8, 2) + "-" + listTD[i].ngayTao.Substring(5, 2) + "-" + listTD[i].ngayTao.Substring(0, 4);
                }
                gcTD.DataSource = listTD;
                if (listTD.Count > 0)
                {
                    idTD = listTD[0].idTD;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách bàn: " + e.Message, "Thông báo");
            }
        }

        private async void layDSBan()
        {
            PhongNgay pn = new PhongNgay();
            pn.maPhong = maPhong;
            pn.ngay = Program.pdt.ngayDat;
            try
            {
                var listB = await _repositoryCTB.layDSBanTheoPhongTheoNgay(pn);
                gcBan.DataSource = listB;
                if (listB.Count > 0)
                {
                    maBan = listB[0].maBan;
                    trangThai = listB[0].trangThai;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách bàn: " + e.Message, "Thông báo");
            }
        }

        private async void layDSPhong()
        {
            try
            {
                var listP = await _repositoryP.layDSPhong();
                gcPhong.DataSource = listP;
                if(listP.Count > 0)
                {
                    maPhong = listP[0].maPhong;         
                    layDSBan();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách phòng: " + e.Message, "Thông báo");
            }
        }

        private void btn_ChonKH_Click(object sender, EventArgs e)
        {
            Program.mesKhachHang = new mesKhachHang();
            Program.mesKhachHang.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.pdt = null;
            this.Close();
        }

        private void gvPhong_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            maPhong = gvPhong.GetRowCellValue(e.RowHandle, "maPhong").ToString();
            layDSBan();
        }

        private void gvBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            maBan = gvBan.GetRowCellValue(e.RowHandle, "maBan").ToString();
            trangThai = gvBan.GetRowCellValue(e.RowHandle, "trangThai").ToString();
        }

        private void gvTD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idTD = int.Parse(gvTD.GetRowCellValue(e.RowHandle, "idTD").ToString());
        }

        private void gvCTDBT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idCTDBT = int.Parse(gvCTDBT.GetRowCellValue(e.RowHandle, "idCTDBT").ToString());
        }

        private void btn_ThemChiTietDatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(trangThai.Equals("Đã đặt"))
            {
                MessageBox.Show("Bàn này đã được đặt rồi! Vui lòng chọn bàn khác!", "Thông báo");
                return;
            }
            ctdbt = new CTDatBanTruocModel();
            ctdbt.idtd = idTD;
            ctdbt.maBan = maBan;
            ctdbt.maPhong = maPhong;
            ctdbt.idpdt = Program.pdt.idPDT;
            themCTDatBanTruoc();
        }

        private void btn_XoaChiTietDatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết đặt bàn trước này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaCTDatBanTruoc();
            }
        }

        private async void themCTDatBanTruoc()
        {
            var check = await _repositoryCTDBT.themCTDatBanTruoc(ctdbt);
            if (check.Equals("false")) MessageBox.Show("Thêm chi tiết đặt bàn trước thất bại", "Thông báo");
            else MessageBox.Show("Thêm chi tiết đặt bàn trước thành công", "Thông báo");
            layDSCTDatBanTruoc();
            layDSBan();
        }

        private async void xoaCTDatBanTruoc()
        {
            var check = await _repositoryCTDBT.xoaCTDatBanTruoc(idCTDBT);
            if (check.Equals("false")) MessageBox.Show("Xóa chi tiết đặt bàn trước thất bại", "Thông báo");
            else MessageBox.Show("Xóa chi tiết đặt bàn trước thành công", "Thông báo");
            layDSCTDatBanTruoc();
            layDSBan();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSPhong();
            layDSThucDon();
            layDSCTDatBanTruoc();
        }

        private void btn_Load_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<PhongModel> listP = new List<PhongModel>();
            List<BanModel> listB = new List<BanModel>();
            List<ThucDonModel> listTD = new List<ThucDonModel>();
            List<CTDatBanTruocModel> listCTDBT = new List<CTDatBanTruocModel>();
            khoiTao();
            gcPhong.DataSource = listP;
            gcBan.DataSource = listB;
            gcTD.DataSource = listTD;
            gcCTDBT.DataSource = listCTDBT;

            Program.pdt = null;
            Program.khachHang = null;

            panelControl4.Enabled = btn_ThemPhieuDat.Enabled = true;
            btn_ThemChiTietDatBan.Enabled = btn_XoaChiTietDatBan.Enabled = btn_Load.Enabled = btn_InHopDong.Enabled = false;
        }

        private void btn_InHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSCTDatMonTruoc();
        }

        private async void layDSCTDatMonTruoc()
        {
            /*var listCTDMT = await _repositoryCTDMT.layDSDatMonTheoPhieuDatTruoc(Program.pdt.idPDT);
            if(listCTDMT == null)
            {
                MessageBox.Show("Tạo hợp đồng thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tạo hợp đồng thành công!", "Thông báo");
                rpHopDong rp = new rpHopDong();

                DataSet ds = new DataSet();

                rp.lb_HoTenKH.Text = Program.pdt.hoTenKH;
                rp.lb_SDTKH.Text = Program.pdt.sdt;
                rp.lb_NgayDat.Text = Program.pdt.ngayDat.Substring(8, 2) + "-" + Program.pdt.ngayDat.Substring(5, 2) + "-" + Program.pdt.ngayDat.Substring(0, 4);
                rp.lb_NhanVienLap.Text = Program.nhanVienDangDangNhap.hoTen;

                DataTable dt = new DataTable();
                dt.TableName = "CTDatMonTruoc";
                dt.Columns.Add("tenma", typeof(String));
                dt.Columns.Add("soLuong", typeof(int));
                dt.Columns.Add("giaTungMon", typeof(String));
                dt.Columns.Add("gia", typeof(String));
                ds.Tables.Add(dt);

                foreach (CTDatMonTruocModel i in listCTDMT)
                {
                    var giaTungMon = String.Format("{0:0,0}", i.giaTungMon);
                    var gia = String.Format("{0:0,0}", i.gia);
                    ds.Tables["CTDatMonTruoc"].Rows.Add(new Object[] { i.tenma, i.soluong, giaTungMon, gia });
                }

                rp.DataSource = ds;
                ReportPrintTool print = new ReportPrintTool(rp);
                print.ShowPreviewDialog();
            }*/
        }
    }
}
