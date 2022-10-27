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
    public partial class mesCTThucDon : Form
    {
        public mesCTThucDon()
        {
            InitializeComponent();
        }

        private void mesCTThucDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            label2.Focus();
            int tam = Program.doiSpinEditThanhInt(se_SoLuong.Text);
            if(tam < 0)
            {
                MessageBox.Show("Số lượng không hợp lý!", "Thông báo");
                se_SoLuong.Focus();
                return;
            }
            Program.soLuong = tam;
            Program.formThucDon.themCTThucDon();
            this.Close();
        }
    }
}
