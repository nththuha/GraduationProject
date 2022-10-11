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
    public partial class mesPhongBan : Form
    {
        public mesPhongBan()
        {
            InitializeComponent();
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            Program.luaChonPB = "Phòng";
            xetHanhDong();
        }

        private void btn_Ban_Click(object sender, EventArgs e)
        {
            Program.luaChonPB = "Bàn";
            xetHanhDong();
        }

        private void xetHanhDong()
        {
            if (Program.actionPB.Equals("Thêm")) Program.formPhongBan.themPhongBan();
            else if (Program.actionPB.Equals("Cập nhật")) Program.formPhongBan.chinhSuaPhongBan();
            else Program.formPhongBan.xoaPhongBan();
            this.Close();
        }

        private void mesPhongBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }
    }
}
