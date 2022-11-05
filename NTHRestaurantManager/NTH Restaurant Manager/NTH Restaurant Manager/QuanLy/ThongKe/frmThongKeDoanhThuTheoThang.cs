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
    public partial class frmThongKeDoanhThuTheoThang : Form
    {
        ThongKeRepository _repository = new ThongKeRepository();

        public frmThongKeDoanhThuTheoThang()
        {
            InitializeComponent();
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

            String ngayBD = de_NgayBD.DateTime.ToString("yyyy-MM-dd");
            String ngayKT = de_NgayKT.DateTime.ToString("yyyy-MM-dd");
            ThongKeModel thongKe = new ThongKeModel();
            thongKe.ngayBD = ngayBD;
            thongKe.ngayKT = ngayKT;
            thongKeDoanhThu(thongKe);
        }

        private async void thongKeDoanhThu(ThongKeModel thongKe)
        {
            List<ThongKeModel> list = await _repository.thongKeDoanhThuTheoThang(thongKe);
            if(list == null)
            {
                MessageBox.Show("Lập phiếu thống kế thất bại!", "Thông báo");
            }
            else
            {
                rpThongKeDoanhThuTheoThang rp = new rpThongKeDoanhThuTheoThang();

                DataSet ds = new DataSet();

                rp.lb_NgayBD.Text = "Ngày bắt đầu: " + thongKe.ngayBD.Substring(8, 2) + "-" + thongKe.ngayBD.Substring(5, 2) + "-" + thongKe.ngayBD.Substring(0, 4);
                rp.lb_NgayKT.Text = "Ngày kết thúc: " + thongKe.ngayKT.Substring(8, 2) + "-" + thongKe.ngayKT.Substring(5, 2) + "-" + thongKe.ngayKT.Substring(0, 4);
                rp.lb_NhanVien.Text = "Nhập viên lập phiếu: " + Program.nhanVienDangDangNhap.hoTen;

                DateTime aDate = DateTime.Now;
                String y = aDate.ToString("yyyy");
                String m = aDate.ToString("MM");
                String d = aDate.ToString("dd");
                rp.lb_TPHCM.Text = "TPHCM, ngày " + d + " tháng " + m + " năm " + y;

                DataTable dt = new DataTable();
                dt.TableName = "ThongKe";
                dt.Columns.Add("thang", typeof(String));
                dt.Columns.Add("doanhThu", typeof(String));
                ds.Tables.Add(dt);

                int tong = 0;

                foreach (ThongKeModel i in list)
                {
                    tong += i.doanhThu;
                    var doanhThu = (i.doanhThu == 0) ? "0 VND" : String.Format("{0:0,0 VND}", i.doanhThu);
                    var thang = i.thang + "/" + i.nam;
                    ds.Tables["ThongKe"].Rows.Add(new Object[] { thang, doanhThu });
                }
                var t = String.Format("{0:0,0 VND}", tong);
                rp.lb_Tong.Text = "Tổng cộng: " + t;

                rp.DataSource = ds;

                ReportPrintTool print = new ReportPrintTool(rp);
                print.ShowPreviewDialog();
            }
        }
    }
}