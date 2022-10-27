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
    }
}
