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

        CTDatBanTruocModel ctdbt;

        String maPhong;
        String maBan;
        int idTD;
        int idCTDBT;

        public frmDatBanTruoc()
        {
            InitializeComponent();
            if(Program.pdt == null)
            {

            }
            else
            {
                layDSPhong();
                layDSThucDon();
                layDSCTDatBanTruoc();
            }
            this.de_NgayDat.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayDat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayDat.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayDat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayDat.Properties.Mask.EditMask = "dd-MM-yyyy";
            khoiTao();
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
        }

        private async void themPhieuDatTruoc()
        {
            Program.pdt = await _repositoryPDT.themPhieuDatTruoc(Program.pdt);
            if (Program.pdt == null) MessageBox.Show("Đặt bàn trước thất bại!", "Thông báo");
            else MessageBox.Show("Đặt bàn trước thành công\nBạn hãy chọn phòng, bàn và thực đơn nhé!", "Thông báo");
            panelControl4.Enabled = btn_ThemPhieuDat.Enabled = false;
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
        }

        private void gvTD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idTD = int.Parse(gvTD.GetRowCellValue(e.RowHandle, "idTD").ToString());
        }

        private void gvCTDBT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idCTDBT = int.Parse(gvCTDBT.GetRowCellValue(e.RowHandle, "idCTDBT").ToString());
        }
    }
}
