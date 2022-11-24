using DevExpress.XtraReports.UI;
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
    public partial class mesKhachHang_THD : Form
    {
        HoaDonRepository _repository = new HoaDonRepository();

        int idPD;
        int tongTien;
        int soHoaDon;

        List<TachHoaDonModel> listTHD;

        public mesKhachHang_THD(int idPD, int tongTien)
        {
            InitializeComponent();
            this.idPD = idPD;
            this.tongTien = tongTien;
            se_Gia1.Visible = se_Gia2.Visible = se_Gia3.Visible = se_Gia4.Visible = false;
            lb_Gia1.Visible = lb_Gia2.Visible = lb_Gia3.Visible = lb_Gia4.Visible = false;
            hienComponent(false);
        }

        private void hienComponent(bool xet) //xét: true -> hiện || xét: false -> ẩn
        {
            lb_HoTenKH.Visible = lb_MaSoThue.Visible = lb_NoiDung.Visible = xet;
            txt_HoTenKH.Visible = txt_MaSoThue.Visible = txt_NoiDung.Visible = xet;
            btn_XacNhan.Visible = xet;

            lb_SoHoaDon.Visible = se_SoHoaDon.Visible = btn_XacNhanSoHD.Visible = !xet;
        }

        private void mesKhachHang_THD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
            Program.formTheoDoiDonHang.khoiTao();
        }

        private void btn_XacNhanSoHD_Click(object sender, EventArgs e)
        {
            lb_SoHoaDon.Focus();
            soHoaDon = Program.doiSpinEditThanhInt(se_SoHoaDon.Text);
            if(soHoaDon <= 1 || soHoaDon > 4)
            {
                MessageBox.Show("Số hóa đơn muốn tách không hợp lý", "Thống báo");
                se_SoHoaDon.Focus();
                return;
            }
            hienComponent(true);
            if(soHoaDon == 2)
            {
                se_Gia1.Visible = se_Gia2.Visible = true;
                lb_Gia1.Visible = lb_Gia2.Visible = true;
            }
            else if(soHoaDon == 3)
            {
                se_Gia1.Visible = se_Gia2.Visible = se_Gia3.Visible = true;
                lb_Gia1.Visible = lb_Gia2.Visible = lb_Gia3.Visible = true;
            }
            else if(soHoaDon == 4)
            {
                se_Gia1.Visible = se_Gia2.Visible = se_Gia3.Visible = se_Gia4.Visible = true;
                lb_Gia1.Visible = lb_Gia2.Visible = lb_Gia3.Visible = lb_Gia4.Visible = true;
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (txt_HoTenKH.Text.Trim().Equals("")){
                MessageBox.Show("Họ tên khách hàng không được bỏ trống!", "Thông báo");
                txt_HoTenKH.Focus();
                return;
            }
            if (txt_MaSoThue.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã số thuế không được bỏ trống!", "Thông báo");
                txt_MaSoThue.Focus();
                return;
            }
            if (txt_NoiDung.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nội dung không được bỏ trống!", "Thông báo");
                txt_NoiDung.Focus();
                return;
            }

            listTHD = new List<TachHoaDonModel>();
            DateTime aDate = DateTime.Now;
            String ngay = aDate.ToString("yyyy-MM-dd");
            String ngayGio = aDate.ToString("yy-MM-dd H m s");
            if (soHoaDon == 2)
            {
                lb_Gia1.Focus();
                int gia1 = Program.doiSpinEditThanhInt(se_Gia1.Text);
                if(gia1 < 0)
                {
                    MessageBox.Show("Giá cho hóa đơn 1 không hợp lý", "Thông báo");
                    se_Gia1.Focus();
                    return;
                }
                int gia2 = Program.doiSpinEditThanhInt(se_Gia2.Text);
                if (gia2 < 0)
                {
                    MessageBox.Show("Giá cho hóa đơn 2 không hợp lý", "Thông báo");
                    se_Gia2.Focus();
                    return;
                }
                if(gia1 + gia2 != tongTien)
                {
                    MessageBox.Show("Tiền của các hóa đơn phải bằng tổng tiền", "Thông báo");
                    return;
                }
                TachHoaDonModel thd1 = ganGiaTriTachHoaDon("HD" + ngayGio + "_1", txt_HoTenKH.Text.Trim(), txt_MaSoThue.Text.Trim(), txt_NoiDung.Text.Trim(), ngay, gia1);
                TachHoaDonModel thd2 = ganGiaTriTachHoaDon("HD" + ngayGio + "_2", txt_HoTenKH.Text.Trim(), txt_MaSoThue.Text.Trim(), txt_NoiDung.Text.Trim(), ngay, gia2);
                listTHD.Add(thd1);
                listTHD.Add(thd2);
            }
            else if(soHoaDon == 3)
            {
                lb_Gia1.Focus();
                int gia1 = Program.doiSpinEditThanhInt(se_Gia1.Text);
                if (gia1 < 0)
                {
                    MessageBox.Show("Giá cho hóa đơn 1 không hợp lý", "Thông báo");
                    se_Gia1.Focus();
                    return;
                }
                int gia2 = Program.doiSpinEditThanhInt(se_Gia2.Text);
                if (gia2 < 0)
                {
                    MessageBox.Show("Giá cho hóa đơn 2 không hợp lý", "Thông báo");
                    se_Gia2.Focus();
                    return;
                }
                int gia3 = Program.doiSpinEditThanhInt(se_Gia3.Text);
                if (gia3 < 0)
                {
                    MessageBox.Show("Giá cho hóa đơn 3 không hợp lý", "Thông báo");
                    se_Gia3.Focus();
                    return;
                }
                if (gia1 + gia2 + gia3 != tongTien)
                {
                    MessageBox.Show("Tiền của các hóa đơn phải hoặc bằng tổng tiền", "Thông báo");
                    return;
                }
                TachHoaDonModel thd1 = ganGiaTriTachHoaDon("HD" + ngayGio + "_1", txt_HoTenKH.Text.Trim(), txt_MaSoThue.Text.Trim(), txt_NoiDung.Text.Trim(), ngay, gia1);
                TachHoaDonModel thd2 = ganGiaTriTachHoaDon("HD" + ngayGio + "_2", txt_HoTenKH.Text.Trim(), txt_MaSoThue.Text.Trim(), txt_NoiDung.Text.Trim(), ngay, gia2);
                TachHoaDonModel thd3 = ganGiaTriTachHoaDon("HD" + ngayGio + "_3", txt_HoTenKH.Text.Trim(), txt_MaSoThue.Text.Trim(), txt_NoiDung.Text.Trim(), ngay, gia3);
                listTHD.Add(thd1);
                listTHD.Add(thd2);
                listTHD.Add(thd3);
            }
            else if(soHoaDon == 4)
            {
                lb_Gia1.Focus();
                int gia1 = Program.doiSpinEditThanhInt(se_Gia1.Text);
                if (gia1 < 0)
                {
                    MessageBox.Show("Giá cho hóa đơn 1 không hợp lý", "Thông báo");
                    se_Gia1.Focus();
                    return;
                }
                int gia2 = Program.doiSpinEditThanhInt(se_Gia2.Text);
                if (gia2 < 0)
                {
                    MessageBox.Show("Giá cho hóa đơn 2 không hợp lý", "Thông báo");
                    se_Gia2.Focus();
                    return;
                }
                int gia3 = Program.doiSpinEditThanhInt(se_Gia3.Text);
                if (gia3 < 0)
                {
                    MessageBox.Show("Giá cho hóa đơn 3 không hợp lý", "Thông báo");
                    se_Gia3.Focus();
                    return;
                }
                int gia4 = Program.doiSpinEditThanhInt(se_Gia4.Text);
                if (gia4 < 0)
                {
                    MessageBox.Show("Giá cho hóa đơn 4 không hợp lý", "Thông báo");
                    se_Gia4.Focus();
                    return;
                }
                if (gia1 + gia2 + gia3 + gia4 != tongTien)
                {
                    MessageBox.Show("Tiền của các hóa đơn phải bằng tổng tiền", "Thông báo");
                    return;
                }
                TachHoaDonModel thd1 = ganGiaTriTachHoaDon("HD" + ngayGio + "_1", txt_HoTenKH.Text.Trim(), txt_MaSoThue.Text.Trim(), txt_NoiDung.Text.Trim(), ngay, gia1);
                TachHoaDonModel thd2 = ganGiaTriTachHoaDon("HD" + ngayGio + "_2", txt_HoTenKH.Text.Trim(), txt_MaSoThue.Text.Trim(), txt_NoiDung.Text.Trim(), ngay, gia2);
                TachHoaDonModel thd3 = ganGiaTriTachHoaDon("HD" + ngayGio + "_3", txt_HoTenKH.Text.Trim(), txt_MaSoThue.Text.Trim(), txt_NoiDung.Text.Trim(), ngay, gia3);
                TachHoaDonModel thd4 = ganGiaTriTachHoaDon("HD" + ngayGio + "_4", txt_HoTenKH.Text.Trim(), txt_MaSoThue.Text.Trim(), txt_NoiDung.Text.Trim(), ngay, gia4);
                listTHD.Add(thd1);
                listTHD.Add(thd2);
                listTHD.Add(thd3);
                listTHD.Add(thd4);
            }
            tachHoaDon();
        }

        private TachHoaDonModel ganGiaTriTachHoaDon(String maHD, String hoTenKH, String maSoThue, String noiDung, String ngay, int soTien)
        {
            TachHoaDonModel thd = new TachHoaDonModel();
            thd.maHD = maHD;
            thd.hoTenKH = hoTenKH;
            thd.maSoThue = maSoThue;
            thd.noiDung = noiDung;
            thd.ngay = ngay;
            thd.soTien = soTien;
            thd.idPD = idPD;
            thd.idNV = Program.nhanVienDangDangNhap.idNV;
            return thd;
        }

        private async void tachHoaDon()
        {
            List<HoaDonTachModel> listHDT = await _repository.tachHoaDon(listTHD);

            if(listHDT.Count < 0)
            {
                MessageBox.Show("Tách hóa đơn thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tách hóa đơn thành công!", "Thông báo");
                foreach(HoaDonTachModel i in listHDT)
                {
                    rpTachHoaDon rp = new rpTachHoaDon();
                    var triGia = String.Format("{0:0,0 VND}", i.gia);
                    var thue = String.Format("{0:0,0 VND}", i.giaSauThue - i.gia);
                    var giaSauThue = String.Format("{0:0,0 VND}", i.giaSauThue);

                    rp.lb_Gia.Text = triGia.ToString();
                    rp.lb_Thue.Text = thue.ToString();
                    rp.lb_GiaSauThue.Text = giaSauThue.ToString();
                    rp.lb_GiaChu.Text = "Tiền chữ: " + i.tienChu;
                    rp.lb_MaHD.Text = i.maHD;
                    rp.lb_Ngay.Text = i.ngay.Substring(8, 2) + "/" + i.ngay.Substring(5, 2) + "/" + i.ngay.Substring(0, 4);
                    rp.lb_MaSoThue.Text = i.maSoThue;
                    rp.lb_HoTenKH.Text = i.hoTenKh;
                    rp.lb_HoTenNV.Text = Program.nhanVienDangDangNhap.hoTen;
                    rp.lb_NoiDung.Text = i.noiDung;
                    rp.lb_Tien.Text = triGia;

                    ReportPrintTool print = new ReportPrintTool(rp);
                    print.ShowPreviewDialog();
                }
                this.Close();
            }
        }
    }
}