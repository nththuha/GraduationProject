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
    public partial class frmDangNhap : Form
    {
        TaiKhoanModel taiKhoan;
        TaiKhoanRepository _repositoryTK = new TaiKhoanRepository();
        NhanVienRepository _repositoryNV = new NhanVienRepository();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã tài khoản không được để trống!", "Thông báo");
                return;
            }
            if (txt_MatKhau.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo");
                return;
            }
            taiKhoan = new TaiKhoanModel();
            taiKhoan.maTK = txt_TenDangNhap.Text.Trim();
            taiKhoan.matKhau = txt_MatKhau.Text.Trim();
            dangNhap();
        }

        public async void dangNhap()
        {
            TokenModel token = await _repositoryTK.dangNhap(taiKhoan);
            if(token == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo");
            }
            else
            {
                if (token.roles == "ADMIN")
                {
                    Program.token = token.token;
                    Program.nhanVienDangDangNhap = await _repositoryNV.layThongTinNhanVien(token.maTK);
                    Program.frmChinh.tssl_MaNV.Text = "Mã nhân viên: " + Program.nhanVienDangDangNhap.idNV;
                    Program.frmChinh.tssl_HoTen.Text = "Họ tên: " + Program.nhanVienDangDangNhap.hoTen;
                    Program.frmChinh.tssl_BoPhan.Text = "Bộ phận " + Program.nhanVienDangDangNhap.tenBP;
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    Program.frmChinh.dangNhap(true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn không phải Admin nên không thể đăng nhập!", "Thông báo");
                }
            }
        }
    }
}
