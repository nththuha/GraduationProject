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
        int num;

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

        private async void layDSPhieuDatTheoNgay()
        {
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
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách phiếu đặt trước: " + e.Message, "Thông báo");
            }
        }

        private void khoiTao()
        {
            de_Ngay.DateTime = DateTime.Now;
        }

        private void de_Ngay_EditValueChanged(object sender, EventArgs e)
        {
            layDSPhieuDatTheoNgay();
        }

        private void btn_CapNhatDatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.pdt = new PhieuDatTruocModel();
            Program.pdt.idPDT = int.Parse(gvPDT.GetRowCellValue(num, "idPDT").ToString());
            Program.pdt.idkh = int.Parse(gvPDT.GetRowCellValue(num, "idkh").ToString());
            Program.pdt.hoTenKH = gvPDT.GetRowCellValue(num, "hoTenKH").ToString();
            Program.pdt.idnv = int.Parse(gvPDT.GetRowCellValue(num, "idnv").ToString());
            String ngayDat = gvPDT.GetRowCellValue(num, "ngayDat").ToString();
            Program.pdt.ngayDat = ngayDat.Substring(6, 4) + "-" + ngayDat.Substring(3, 2) + "-" + ngayDat.Substring(0, 2);
            String ngayTao = gvPDT.GetRowCellValue(num, "ngayTao").ToString();
            Program.pdt.ngayTao = ngayTao.Substring(6, 4) + "-" + ngayTao.Substring(3, 2) + "-" + ngayTao.Substring(0, 2);

            Program.frmChinh.btn_DatBanTruoc_ItemClick(sender, e);
            Program.formDatBanTruoc.setUp();
        }

        private void gvPDT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            num = e.RowHandle;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSPhieuDatTheoNgay();
        }
    }
}
