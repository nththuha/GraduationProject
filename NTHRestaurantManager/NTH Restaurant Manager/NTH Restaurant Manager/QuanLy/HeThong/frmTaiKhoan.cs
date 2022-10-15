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
    public partial class frmTaiKhoan : Form
    {
        TaiKhoanRepository _repository = new TaiKhoanRepository();
        int num;
        TaiKhoanModel taiKhoan;

        public frmTaiKhoan()
        {
            InitializeComponent();
            layDSTaiKhoan();
        }

        private async void layDSTaiKhoan()
        {
            try
            {
                var listTK = await _repository.layDSTaiKhoan();
                gcTK.DataSource = listTK;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách tài khoản " + e.Message, "Thông báo");
            }
        }

        private void gvTK_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            num = e.RowHandle;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSTaiKhoan();
        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            taiKhoan = new TaiKhoanModel();
            taiKhoan.maTK = gvTK.GetRowCellValue(num, "maTK").ToString();
            String matKhau = laySoNgauNhien();
            taiKhoan.matKhau = matKhau;
            taiKhoan.idnv = int.Parse(gvTK.GetRowCellValue(num, "idnv").ToString());
            suaTaiKhoan(matKhau);
        }

        private async void suaTaiKhoan(String matKhau)
        {
            String check = await _repository.suaTaiKhoan(taiKhoan);
            if (check.Equals("false")) MessageBox.Show("Có lỗi trong quá trình xử lý!", "Thông báo");
            else MessageBox.Show("Reset mật khẩu thành công!\nMã tài khoản: " + gvTK.GetRowCellValue(num, "maTK").ToString() + "\nMật khẩu mới: " + matKhau, "Thông báo");
        }

        private String laySoNgauNhien()
        {
            String so = "";
            Random rd = new Random();
            so = rd.Next(100000, 999999).ToString();
            return so;
        }
    }
}
