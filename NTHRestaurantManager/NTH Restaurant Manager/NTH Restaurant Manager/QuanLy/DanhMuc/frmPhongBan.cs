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
    public partial class frmPhongBan : Form
    {
        PhongRepository _repositoryP = new PhongRepository();
        BanRepository _repositoryB = new BanRepository();

        PhongModel phong;
        BanModel ban;

        public frmPhongBan()
        {
            InitializeComponent();
            khoiTaoPhong();
            khoiTaoBan();
            layDSPhong();
            layDSBan();
        }

        public void khoiTaoPhong()
        {
            txt_MaPhong.Text = "";
            txt_TenPhong.Text = "";
        }

        public void khoiTaoBan()
        {
            txt_MaBan.Text = "";
            txt_TenBan.Text = "";
            se_SoGhe.Text = "0";
        }

        public async void layDSPhong()
        {
            try
            {
                var listP = await _repositoryP.layDSPhong();
                gcPhong.DataSource = listP;
                if (listP.Count > 0) setGiaTriPhong(0);
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi load danh sách phòng: " + e.Message, "Thông báo");
            }
        }

        public async void layDSBan()
        {
            try
            {
                var listB = await _repositoryB.layDSBan();
                gcBan.DataSource = listB;
                if (listB.Count > 0) setGiaTriBan(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load danh sách bàn: " + e.Message, "Thông báo");
            }
        }

        public void setGiaTriPhong(int num)
        {
            txt_MaPhong.Text = gvPhong.GetRowCellValue(num, "maPhong").ToString();
            txt_TenPhong.Text = gvPhong.GetRowCellValue(num, "tenPhong").ToString();
        }

        public void setGiaTriBan(int num)
        {
            txt_MaBan.Text = gvBan.GetRowCellValue(num, "maBan").ToString();
            txt_TenBan.Text = gvBan.GetRowCellValue(num, "tenBan").ToString();
            se_SoGhe.Text = gvBan.GetRowCellValue(num, "soGhe").ToString();
        }

        private void gvPhong_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            setGiaTriPhong(e.RowHandle);
        }

        private void gvBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            setGiaTriBan(e.RowHandle);
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.actionPB = "Thêm";
            Program.mesPhongBan = new mesPhongBan();
            Program.mesPhongBan.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.actionPB = "Cập nhật";
            Program.mesPhongBan = new mesPhongBan();
            Program.mesPhongBan.lb_TieuDe.Text = "Bạn muốn cập nhật Phòng hay Bàn?";
            Program.mesPhongBan.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.actionPB = "Xóa";
            Program.mesPhongBan = new mesPhongBan();
            Program.mesPhongBan.lb_TieuDe.Text = "Bạn muốn xóa Phòng hay Bàn?";
            Program.mesPhongBan.Show();
            Program.frmChinh.Enabled = false;
        }

        public async void themPhong()
        {
            String check = await _repositoryP.themPhong(phong);
            if (check.Equals("false")) MessageBox.Show("Thêm phòng thất bại!", "Thông báo");
            else MessageBox.Show("Thêm phòng thành công!", "Thông báo");
            layDSPhong();
        }

        public async void themBan()
        {
            String check = await _repositoryB.themBan(ban);
            if (check.Equals("false")) MessageBox.Show("Thêm bàn thất bại!", "Thông báo");
            else MessageBox.Show("Thêm bàn thành công!", "Thông báo");
            layDSBan();
        }

        public async void capNhatPhong()
        {
            String check = await _repositoryP.suaPhong(phong);
            if (check.Equals("false")) MessageBox.Show("Cập nhật phòng thất bại!", "Thông báo");
            else MessageBox.Show("Cập nhật phòng thành công!", "Thông báo");
            layDSPhong();
        }

        public async void capNhatBan()
        {
            String check = await _repositoryB.suaBan(ban);
            if (check.Equals("false")) MessageBox.Show("Cập nhật bàn thất bại!", "Thông báo");
            else MessageBox.Show("Cập nhật bàn thành công!", "Thông báo");
            layDSBan();
        }

        public async void xoaPhong(String maPhong)
        {
            String check = await _repositoryP.xoaPhong(maPhong);
            if (check.Equals("false")) MessageBox.Show("Xóa phòng thất bại!", "Thông báo");
            else MessageBox.Show("Xóa phòng thành công!", "Thông báo");
            layDSPhong();
        }

        public async void xoaBan(String maBan)
        {
            String check = await _repositoryB.xoaBan(maBan);
            if (check.Equals("false")) MessageBox.Show("Xóa bàn thất bại!", "Thông báo");
            else MessageBox.Show("Xóa bàn thành công!", "Thông báo");
            layDSBan();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSPhong();
            layDSBan();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBan.CancelEdit();
            bdsPhong.CancelEdit();
            layDSPhong();
            layDSBan();
            gcPhong.Enabled = gcBan.Enabled = true;
            panelPhong.Enabled = panelBan.Enabled = false;
            btn_Them.Enabled = btn_Xoa.Enabled = btn_CapNhat.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }

        public void themPhongBan()
        {
            if (Program.luaChonPB.Equals("Phòng"))
            {
                khoiTaoPhong();
                gcPhong.Enabled = gcBan.Enabled = panelBan.Enabled = false;
                panelPhong.Enabled = true;
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            }
            else if (Program.luaChonPB.Equals("Bàn"))
            {
                khoiTaoBan();
                gcBan.Enabled = gcPhong.Enabled = panelPhong.Enabled = false;
                panelBan.Enabled = true;
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            }
        }

        public void chinhSuaPhongBan()
        {
            if (Program.luaChonPB.Equals("Phòng"))
            {
                gcPhong.Enabled = gcBan.Enabled = panelBan.Enabled = false;
                panelPhong.Enabled = true;
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
                txt_MaPhong.Enabled = false;
            }
            else if (Program.luaChonPB.Equals("Bàn"))
            {
                gcBan.Enabled = gcPhong.Enabled = panelPhong.Enabled = false;
                panelBan.Enabled = true;
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
                txt_MaBan.Enabled = false;
            }
        }

        public void xoaPhongBan()
        {
            if (Program.luaChonPB.Equals("Phòng"))
            {
                String maPhong = txt_MaPhong.Text.Trim();
                String tenPhong = txt_TenPhong.Text.Trim();
                if (MessageBox.Show("Bạn có thật sự muốn xóa " + tenPhong + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    xoaPhong(maPhong);
                    khoiTaoPhong();
                }
            }
            else if (Program.luaChonPB.Equals("Bàn"))
            {
                String maBan = txt_MaBan.Text.Trim();
                String tenBan = txt_TenBan.Text.Trim();
                if (MessageBox.Show("Bạn có thật sự muốn xóa " + tenBan + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    xoaBan(maBan);
                    khoiTaoBan();
                }
            }
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.luaChonPB.Equals("Phòng"))
            {
                if (txt_MaPhong.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã phòng không được để trống", "Thông báo", MessageBoxButtons.OK);
                    txt_MaPhong.Focus();
                    return;
                }
                if (txt_TenPhong.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên phòng không được để trống", "Thông báo", MessageBoxButtons.OK);
                    txt_TenPhong.Focus();
                    return;
                }
                phong = new PhongModel();
                phong.maPhong = txt_MaPhong.Text.Trim();
                phong.tenPhong = txt_TenPhong.Text.Trim();
                if (Program.actionPB.Equals("Thêm"))
                {
                    themPhong();
                }
                else
                {
                    capNhatPhong();
                    txt_MaPhong.Enabled = true;
                }
            }
            else
            {
                if (txt_MaBan.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã bàn không được để trống", "Thông báo", MessageBoxButtons.OK);
                    txt_MaBan.Focus();
                    return;
                }
                if (txt_TenBan.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên bàn không được để trống", "Thông báo", MessageBoxButtons.OK);
                    txt_TenBan.Focus();
                    return;
                }
                int tam = Program.doiSpinEditThanhInt(se_SoGhe.Text.Trim());
                if (tam < 0)
                {
                    MessageBox.Show("Số ghế phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
                    se_SoGhe.Focus();
                    return;
                }
                ban = new BanModel();
                ban.maBan = txt_MaBan.Text.Trim();
                ban.tenBan = txt_TenBan.Text.Trim();
                ban.soGhe = tam;
                if (Program.actionPB.Equals("Thêm"))
                {
                    themBan();
                }
                else
                {
                    capNhatBan();
                    txt_MaBan.Enabled = true;
                }
            }
            btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
            gcPhong.Enabled = gcBan.Enabled = true;
            panelPhong.Enabled = panelBan.Enabled = false;
        }
    }
}
