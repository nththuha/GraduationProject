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
    public partial class mesHuyPhieuDatTruoc : Form
    {
        public mesHuyPhieuDatTruoc()
        {
            InitializeComponent();
        }

        private void mesHuyPhieuDatTruoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }
    }
}
