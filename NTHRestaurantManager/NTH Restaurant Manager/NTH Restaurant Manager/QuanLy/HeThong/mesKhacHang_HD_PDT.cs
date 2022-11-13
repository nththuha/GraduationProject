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
    public partial class mesKhacHang_HD_PDT : Form
    {
        HoaDonRepository _repositoryHD = new HoaDonRepository();
        public mesKhacHang_HD_PDT()
        {
            InitializeComponent();
        }

        private void mesKhacHang_HD_PDT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
            Program.formTheoDoiDonHangPDT.layDSPhieuDat();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
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
            HoaDonPDTModel hd = await _repositoryHD.themHoaDonPDT(Program.hoaDon);

            if (hd.maHD == null)
            {
                MessageBox.Show("Lập hóa đơn thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lập hóa đơn thành công!", "Thông báo");

                rpHoaDonPDT rp = new rpHoaDonPDT();

                DataSet ds = new DataSet();

                var triGia = String.Format("{0:0,0 VND}", hd.trigia);
                var thue = String.Format("{0:0,0 VND}", hd.giaSauThue - hd.trigia);
                var giaSauThue = String.Format("{0:0,0 VND}", hd.giaSauThue);
                var tongCoc = String.Format("{0:0,0 VND}", hd.tongCoc);
                var soTienConLai = String.Format("{0:0,0 VND}", hd.giaConLai);

                rp.lb_Gia.Text = triGia.ToString();
                rp.lb_Thue.Text = thue.ToString();
                rp.lb_GiaSauThue.Text = giaSauThue.ToString();
                rp.lb_GiaChu.Text = "Tiền chữ: " + hd.giaChu;
                rp.lb_MaHD.Text = hd.maHD;
                rp.lb_Ngay.Text = hd.ngay.Substring(8, 2) + "/" + hd.ngay.Substring(5, 2) + "/" + hd.ngay.Substring(0, 4);
                rp.lb_MaSoThue.Text = hd.masothue;
                rp.lb_HoTenKH.Text = hd.hotenkh;
                rp.lb_HoTenNV.Text = Program.nhanVienDangDangNhap.hoTen;
                rp.lb_TongCoc.Text = tongCoc;
                rp.lb_SoTienConLai.Text = soTienConLai;

                DataTable dt = new DataTable();
                dt.TableName = "ctDatMonTruocList";
                dt.Columns.Add("tenma", typeof(String));
                dt.Columns.Add("soluong", typeof(int));
                dt.Columns.Add("giaTungMon", typeof(String));
                dt.Columns.Add("gia", typeof(String));
                ds.Tables.Add(dt);

                List<CTDatMonTruocModel> ct = hd.ctDatMonTruocList;
                foreach (CTDatMonTruocModel i in ct)
                {
                    var giaTungMon = String.Format("{0:0,0}", i.giaTungMon);
                    var gia = String.Format("{0:0,0}", i.gia);
                    ds.Tables["ctDatMonTruocList"].Rows.Add(new Object[] { i.tenma, i.soluong, giaTungMon, gia });
                }

                rp.DataSource = ds;

                List<TienCocModel> listTC = hd.tienCocList;
                int tong = 0;
                if (listTC.Count == 1)
                {
                    tong += listTC[0].triGia;
                    var tien = String.Format("{0:0,0}", listTC[0].triGia);
                    rp.tc_HoTenKH1.Text = listTC[0].hoTenKH;
                    rp.tc_SDT1.Text = listTC[0].sdt;
                    rp.tc_NgayCoc1.Text = listTC[0].ngay.Substring(8, 2) + "-" + listTC[0].ngay.Substring(5, 2) + "-" + listTC[0].ngay.Substring(0, 4);
                    rp.tc_SoTien1.Text = tien;
                }
                else if (listTC.Count == 2)
                {
                    tong += listTC[0].triGia + listTC[1].triGia;
                    var tien = String.Format("{0:0,0}", listTC[0].triGia);
                    rp.tc_HoTenKH1.Text = listTC[0].hoTenKH;
                    rp.tc_SDT1.Text = listTC[0].sdt;
                    rp.tc_NgayCoc1.Text = listTC[0].ngay.Substring(8, 2) + "-" + listTC[0].ngay.Substring(5, 2) + "-" + listTC[0].ngay.Substring(0, 4);
                    rp.tc_SoTien1.Text = tien;
                    tien = String.Format("{0:0,0}", listTC[1].triGia);
                    rp.tc_HoTenKH2.Text = listTC[1].hoTenKH;
                    rp.tc_SDT2.Text = listTC[1].sdt;
                    rp.tc_NgayCoc2.Text = listTC[1].ngay.Substring(8, 2) + "-" + listTC[1].ngay.Substring(5, 2) + "-" + listTC[1].ngay.Substring(0, 4);
                    rp.tc_SoTien2.Text = tien;
                }

                this.Close();
                ReportPrintTool print = new ReportPrintTool(rp);
                print.ShowPreviewDialog();
            }
        }
    }
}
