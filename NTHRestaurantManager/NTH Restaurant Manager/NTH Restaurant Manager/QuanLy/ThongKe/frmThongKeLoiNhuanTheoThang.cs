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
    public partial class frmThongKeLoiNhuanTheoThang : Form
    {
        public frmThongKeLoiNhuanTheoThang()
        {
            InitializeComponent();
            this.de_NgayBD.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayBD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayBD.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayBD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayBD.Properties.Mask.EditMask = "dd-MM-yyyy";

            this.de_NgayKT.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayKT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayKT.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_NgayKT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayKT.Properties.Mask.EditMask = "dd-MM-yyyy";

            de_NgayBD.DateTime = DateTime.Now;
            de_NgayKT.DateTime = DateTime.Now;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (de_NgayBD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ngày bắt đầu không được để trống!", "Thông báo");
                return;
            }
            if (de_NgayKT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ngày bắt đầu không được để trống!", "Thông báo");
                return;
            }
        }
    }
}
