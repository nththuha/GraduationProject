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
    public partial class frmTheoDoiDonHang : Form
    {
        PhieuDatRepository _repositoryPD = new PhieuDatRepository();
        CTDatMonRepository _repositoryCTDM = new CTDatMonRepository();

        List<PhieuDatModel> listPD = new List<PhieuDatModel>();
        List<CTDatMonModel> listCTDM = new List<CTDatMonModel>();

        int idPD;
        int numPD;
        int numPDTemp;

        public frmTheoDoiDonHang()
        {
            InitializeComponent();
            layDSPhieuDat();
        }

        private async void layDSPhieuDat()
        {
            try
            {
                var listPD = await _repositoryPD.layDSPhieuDat();
                for(int i = 0; i < listPD.Count; i++)
                {
                    listPD[i].ngay = listPD[i].ngay.Substring(8, 2) + "-" + listPD[i].ngay.Substring(5, 2) + "-" + listPD[i].ngay.Substring(0, 4);
                }
                gcPD.DataSource = listPD;
                if(listPD.Count > 0)
                {
                    idPD = listPD[0].idPD;
                    layDSCTDatMonTheoPhieuDat();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi load danh sách phiếu đặt: " + e.Message, "Thông báo");
            }
        }

        private async void layDSCTDatMonTheoPhieuDat()
        {
            try
            {
                listCTDM = new List<CTDatMonModel>();
                listCTDM = await _repositoryCTDM.layDSCTDatMonTheoPhieuDat(idPD);
                gcCTDM.DataSource = listCTDM;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách chi tiết đặt món: " + e.Message, "Thông báo");
            }
        }

        private void gvPD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numPD = e.RowHandle;
            idPD = int.Parse(gvPD.GetRowCellValue(e.RowHandle, "idPD").ToString());
            layDSCTDatMonTheoPhieuDat();
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSPhieuDat();
        }

        private Boolean kiemTraCTDMDaPV()
        {
            foreach(CTDatMonModel i in listCTDM)
            {
                if(!i.trangThai.Equals("Đã phục vụ"))
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemTraCTDMDaPV())
            {
                MessageBox.Show("Món ăn vẫn chưa được phục vụ hết cho khách", "Thông báo");
                return;
            }

            int idPD = int.Parse(gvPD.GetRowCellValue(numPD, "idPD").ToString());
            String ngay = gvPD.GetRowCellValue(numPD, "ngay").ToString();
            String tenPhong = gvPD.GetRowCellValue(numPD, "tenPhong").ToString();
            String tenBan = gvPD.GetRowCellValue(numPD, "tenBan").ToString();

            PhieuDatModel pd = new PhieuDatModel();
            pd.idPD = idPD;
            pd.ngay = ngay;
            pd.tenPhong = tenPhong;
            pd.tenBan = tenBan;

            foreach (PhieuDatModel i in listPD)
            {
                if (i.idPD == idPD)
                {
                    MessageBox.Show("Phiếu đặt không được trùng!", "Thông báo");
                    return;
                }
            }
            listPD.Add(pd);

            List<PhieuDatModel> list = new List<PhieuDatModel>();
            foreach(PhieuDatModel i in listPD)
            {
                list.Add(i);
            }
            gcPDTemp.DataSource = list;
        }

        private void gvPDTemp_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numPDTemp = e.RowHandle;
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listPD.RemoveAt(numPDTemp);

            List<PhieuDatModel> list = new List<PhieuDatModel>();
            foreach (PhieuDatModel i in listPD)
            {
                list.Add(i);
            }
            gcPDTemp.DataSource = list;
        }

        private void btn_XuatHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(listPD.Count < 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu đặt để lập hóa đơn", "Thông báo");
                return;
            }
            DateTime aDate = DateTime.Now;
            String ngay = aDate.ToString("yyyy-MM-dd");
            String ngayGio = aDate.ToString("yy-MM-dd H m s");
            Program.hoaDon = new HoaDonModel();
            Program.hoaDon.maHD = "HD" + ngayGio;
            Program.hoaDon.ngay = ngay;
            Program.hoaDon.phieudatList = listPD;
            Program.hoaDon.idnv = Program.nhanVienDangDangNhap.idNV;

            Program.mesKhachHang_HD = new mesKhachHang_HD();
            Program.mesKhachHang_HD.Show();
            Program.frmChinh.Enabled = false;
        }
    }
}
