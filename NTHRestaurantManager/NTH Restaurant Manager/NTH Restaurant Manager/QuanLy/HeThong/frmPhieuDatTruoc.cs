﻿using DevExpress.XtraReports.UI;
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
    public partial class frmPhieuDatTruoc : Form
    {
        PhieuDatTruocRepository _repositoryPDT = new PhieuDatTruocRepository();
        CTDatMonTruocRepository _repositoryCTDMT = new CTDatMonTruocRepository();
        int num;

        public frmPhieuDatTruoc()
        {
            InitializeComponent();
            this.de_Ngay.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.de_Ngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_Ngay.Properties.Mask.EditMask = "dd-MM-yyyy";
            khoiTao();
            layDSPhieuDatTheoNgay();
        }

        private async void layDSPhieuDatTheoNgay()
        {
            PhongNgay pn = new PhongNgay();
            pn.ngay = de_Ngay.DateTime.ToString("yyyy-MM-dd");
            try
            {
                var listPDT = await _repositoryPDT.layDSPhieuDatTruocTheoNgay(pn);
                for (int i = 0; i < listPDT.Count; i++)
                {
                    listPDT[i].ngayDat = listPDT[i].ngayDat.Substring(8, 2) + "-" + listPDT[i].ngayDat.Substring(5, 2) + "-" + listPDT[i].ngayDat.Substring(0, 4);
                    listPDT[i].ngayTao = listPDT[i].ngayTao.Substring(8, 2) + "-" + listPDT[i].ngayTao.Substring(5, 2) + "-" + listPDT[i].ngayTao.Substring(0, 4);
                }
                gcPDT.DataSource = listPDT;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi lấy danh sách phiếu đặt trước: " + e.Message, "Thông báo");
            }
        }

        private void khoiTao()
        {
            de_Ngay.DateTime = DateTime.Now;
        }

        private void de_Ngay_EditValueChanged(object sender, EventArgs e)
        {
            layDSPhieuDatTheoNgay();
        }

        private void btn_CapNhatDatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.pdt = new PhieuDatTruocModel();
            Program.pdt.idPDT = int.Parse(gvPDT.GetRowCellValue(num, "idPDT").ToString());
            Program.pdt.idkh = int.Parse(gvPDT.GetRowCellValue(num, "idkh").ToString());
            Program.pdt.hoTenKH = gvPDT.GetRowCellValue(num, "hoTenKH").ToString();
            Program.pdt.sdt = gvPDT.GetRowCellValue(num, "sdt").ToString();
            Program.pdt.idnv = int.Parse(gvPDT.GetRowCellValue(num, "idnv").ToString());
            String ngayDat = gvPDT.GetRowCellValue(num, "ngayDat").ToString();
            Program.pdt.ngayDat = ngayDat.Substring(6, 4) + "-" + ngayDat.Substring(3, 2) + "-" + ngayDat.Substring(0, 2);
            String ngayTao = gvPDT.GetRowCellValue(num, "ngayTao").ToString();
            Program.pdt.ngayTao = ngayTao.Substring(6, 4) + "-" + ngayTao.Substring(3, 2) + "-" + ngayTao.Substring(0, 2);
            Program.frmChinh.btn_DatBanTruoc_ItemClick(sender, e);
            Program.formDatBanTruoc.setUp();
        }

        private void gvPDT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            num = e.RowHandle;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSPhieuDatTheoNgay();
        }

        private void btn_InHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idPDT = int.Parse(gvPDT.GetRowCellValue(num, "idPDT").ToString());
            layPhieuDatCoc(idPDT);
        }

        private async void layPhieuDatCoc(int idPDT)
        {
            PhieuDatCocModel pdc = await _repositoryCTDMT.layDSDatMonTheoPhieuDatTruoc(idPDT);
            if (pdc == null)
            {
                MessageBox.Show("Tạo phiếu đặt cọc thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tạo phiếu đặt cọc thành công!", "Thông báo");
                rpHopDong rp = new rpHopDong();

                rp.lb_HoTenKH.Text = pdc.hoTenKH;
                rp.lb_SDT.Text = pdc.sdt;
                rp.lb_NgayDat.Text = pdc.ngayDat.Substring(8, 2) + "-" + pdc.ngayDat.Substring(5, 2) + "-" + pdc.ngayDat.Substring(0, 4);
                rp.lb_NhanVien.Text = pdc.hoTenNV;
                rp.lb_Tien.Text = String.Format("{0:0,0}", pdc.gia);
                rp.lb_Thue.Text = String.Format("{0:0,0}", (pdc.gia * 0.1));
                rp.lb_TongTien.Text = String.Format("{0:0,0}", pdc.giaSauThue);

                DataTable dt = new DataTable("listCTDMT");
                dt.Columns.Add("tenma", typeof(String));
                dt.Columns.Add("soLuong", typeof(int));
                dt.Columns.Add("giaTungMon", typeof(String));
                dt.Columns.Add("gia", typeof(String));
                List<CTDatMonTruocModel> listCTDMT = pdc.listCTDMT;
                foreach (CTDatMonTruocModel i in listCTDMT)
                {
                    var giaTungMon = String.Format("{0:0,0}", i.giaTungMon);
                    var gia = String.Format("{0:0,0}", i.gia);
                    dt.Rows.Add(new Object[] { i.tenma, i.soluong, giaTungMon, gia });
                }

                List<TienCocModel> listTC = pdc.listTC;
                int tong = 0;
                if(listTC.Count == 1)
                {
                    tong += listTC[0].triGia;
                    var tien = String.Format("{0:0,0}", listTC[0].triGia);
                    rp.tc_HoTenKH1.Text = listTC[0].hoTenKH;
                    rp.tc_SDT1.Text = listTC[0].sdt;
                    rp.tc_NgayCoc1.Text = listTC[0].ngay.Substring(8, 2) + "-" + listTC[0].ngay.Substring(5, 2) + "-" + listTC[0].ngay.Substring(0, 4);
                    rp.tc_SoTien1.Text = tien;
                }
                else if(listTC.Count == 2)
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
                rp.lb_TienCoc.Text = String.Format("{0:0,0}", tong);
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                rp.DataSource = ds;
                ReportPrintTool print = new ReportPrintTool(rp);
                print.ShowPreviewDialog();
            }
        }
    }
}
