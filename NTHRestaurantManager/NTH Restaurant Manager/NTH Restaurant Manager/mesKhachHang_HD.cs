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
    public partial class mesKhachHang_HD : Form
    {
        HoaDonRepository _repositoryHD = new HoaDonRepository();

        public mesKhachHang_HD()
        {
            InitializeComponent();
        }

        private void mesKhachHang_HD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
            Program.formTheoDoiDonHang.khoiTao();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            /*Program.hoaDon = new HoaDonModel();
            Program.hoaDon.maHD = "HD12-11-2022 12 12 12";
            Program.hoaDon.idnv = 1;
            Program.hoaDon.ngay = "2022-11-12";
            List<PhieuDatModel> listPD = new List<PhieuDatModel>();
            PhieuDatModel pd = new PhieuDatModel();
            pd.idPD = 38;
            listPD.Add(pd);
            pd = new PhieuDatModel();
            pd.idPD = 39;
            listPD.Add(pd);
            Program.hoaDon.phieudatList = listPD;*/

            /*List<PhieuDatModel> listPD = new List<PhieuDatModel>();
            foreach(PhieuDatModel i in Program.listPD)
            {
                listPD.Add(i);
            }
            Program.hoaDon.phieudatList = listPD;*/

            MessageBox.Show("Mã hóa đơn: " + Program.hoaDon.maHD + "\n" +
                            "ngay: " + Program.hoaDon.ngay + "\n" +
                            "idnv: " + Program.hoaDon.idnv + "\n" +
                            "phieudatlist: " + Program.hoaDon.phieudatList.Count + "\n" +
                            "1: " + Program.hoaDon.phieudatList[0].idPD + "\n" +
                            "2: " + Program.hoaDon.phieudatList[1].idPD + "\n");

            if (!txt_HoTenKH.Text.Trim().Equals(""))
            {
                Program.hoaDon.hotenkh = txt_HoTenKH.Text.Trim();
            }
            if (!txt_MaSoThue.Text.Trim().Equals(""))
            {
                Program.hoaDon.masothue = txt_MaSoThue.Text.Trim();
            }
            lapHoaDon();
        }

        private async void lapHoaDon()
        {
            HoaDonPDModel hd = await _repositoryHD.themHoaDon(Program.hoaDon);

            if (hd.maHD == null)
            {
                MessageBox.Show("Lập hóa đơn thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lập hóa đơn thành công!", "Thông báo");

                rpHoaDonPD rp = new rpHoaDonPD();

                DataSet ds = new DataSet();

                var triGia = String.Format("{0:0,0 VND}", hd.trigia);
                var thue = String.Format("{0:0,0 VND}", hd.giaSauThue - hd.trigia);
                var giaSauThue = String.Format("{0:0,0 VND}", hd.giaSauThue);

                rp.lb_Gia.Text = triGia.ToString();
                rp.lb_Thue.Text = thue.ToString();
                rp.lb_GiaSauThue.Text = giaSauThue.ToString();
                rp.lb_GiaChu.Text = "Tiền chữ: " + hd.giaChu;
                rp.lb_MaHD.Text = hd.maHD;
                rp.lb_Ngay.Text = hd.ngay.Substring(8, 2) + "/" + hd.ngay.Substring(5, 2) + "/" + hd.ngay.Substring(0, 4);
                rp.lb_MaSoThue.Text = hd.masothue;
                rp.lb_HoTenKH.Text = hd.hotenkh;
                rp.lb_HoTenNV.Text = Program.nhanVienDangDangNhap.hoTen;

                DataTable dt = new DataTable();
                dt.TableName = "ctDatMonList";
                dt.Columns.Add("tenma", typeof(String));
                dt.Columns.Add("soLuong", typeof(int));
                dt.Columns.Add("giaTungMon", typeof(String));
                dt.Columns.Add("gia", typeof(String));
                ds.Tables.Add(dt);

                List<CTDatMonModel> ct = hd.ctDatMonList;
                foreach (CTDatMonModel i in ct)
                {
                    var giaTungMon = String.Format("{0:0,0}", i.giaTungMon);
                    var gia = String.Format("{0:0,0}", i.gia);
                    ds.Tables["ctDatMonList"].Rows.Add(new Object[] { i.tenma, i.soLuong, giaTungMon, gia });
                }

                rp.DataSource = ds;

                this.Close();
                ReportPrintTool print = new ReportPrintTool(rp);
                print.ShowPreviewDialog();
            }
        }
    }
}
