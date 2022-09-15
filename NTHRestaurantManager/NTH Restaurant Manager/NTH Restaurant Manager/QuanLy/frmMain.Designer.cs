
namespace NTH_Restaurant_Manager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LoaiMonAn = new DevExpress.XtraBars.BarButtonItem();
            this.btn_MonAn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChiTietPhong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThongKeDoanhThuTheoThang = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TheoDoiDonHang = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThayDoiGiaMon = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.sttl_MaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_BoPhan = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_DangNhap,
            this.btn_DangXuat,
            this.btn_LoaiMonAn,
            this.btn_MonAn,
            this.barButtonItem5,
            this.btn_ChiTietPhong,
            this.barButtonItem7,
            this.btn_NhanVien,
            this.btn_TaiKhoan,
            this.btn_ThongKeDoanhThuTheoThang,
            this.btn_TheoDoiDonHang,
            this.btn_ThayDoiGiaMon,
            this.btn_PhongBan,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1448, 193);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Caption = "Đăng nhập";
            this.btn_DangNhap.Id = 1;
            this.btn_DangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.Image")));
            this.btn_DangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.LargeImage")));
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangNhap_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất";
            this.btn_DangXuat.Enabled = false;
            this.btn_DangXuat.Id = 2;
            this.btn_DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.Image")));
            this.btn_DangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.LargeImage")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btn_LoaiMonAn
            // 
            this.btn_LoaiMonAn.Caption = "Loại món ăn";
            this.btn_LoaiMonAn.Enabled = false;
            this.btn_LoaiMonAn.Id = 3;
            this.btn_LoaiMonAn.ImageOptions.Image = global::NTH_Restaurant_Manager.Properties.Resources.loaimonan;
            this.btn_LoaiMonAn.Name = "btn_LoaiMonAn";
            this.btn_LoaiMonAn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_LoaiMonAn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LoaiMonAn_ItemClick);
            // 
            // btn_MonAn
            // 
            this.btn_MonAn.Caption = "Món ăn";
            this.btn_MonAn.Enabled = false;
            this.btn_MonAn.Id = 4;
            this.btn_MonAn.ImageOptions.Image = global::NTH_Restaurant_Manager.Properties.Resources.monan;
            this.btn_MonAn.Name = "btn_MonAn";
            this.btn_MonAn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_MonAn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MonAn_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Phòng + Bàn";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btn_ChiTietPhong
            // 
            this.btn_ChiTietPhong.Caption = "Chi tiết phòng";
            this.btn_ChiTietPhong.Enabled = false;
            this.btn_ChiTietPhong.Id = 6;
            this.btn_ChiTietPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChiTietPhong.ImageOptions.Image")));
            this.btn_ChiTietPhong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ChiTietPhong.ImageOptions.LargeImage")));
            this.btn_ChiTietPhong.Name = "btn_ChiTietPhong";
            this.btn_ChiTietPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ChiTietPhong_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Caption = "Nhân viên";
            this.btn_NhanVien.Id = 8;
            this.btn_NhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.ImageOptions.Image")));
            this.btn_NhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.ImageOptions.LargeImage")));
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhanVien_ItemClick);
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.Caption = "Tài khoản";
            this.btn_TaiKhoan.Enabled = false;
            this.btn_TaiKhoan.Id = 9;
            this.btn_TaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiKhoan.ImageOptions.Image")));
            this.btn_TaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TaiKhoan.ImageOptions.LargeImage")));
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TaiKhoan_ItemClick);
            // 
            // btn_ThongKeDoanhThuTheoThang
            // 
            this.btn_ThongKeDoanhThuTheoThang.Caption = "Thống kê doanh thu theo tháng";
            this.btn_ThongKeDoanhThuTheoThang.Enabled = false;
            this.btn_ThongKeDoanhThuTheoThang.Id = 10;
            this.btn_ThongKeDoanhThuTheoThang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKeDoanhThuTheoThang.ImageOptions.Image")));
            this.btn_ThongKeDoanhThuTheoThang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ThongKeDoanhThuTheoThang.ImageOptions.LargeImage")));
            this.btn_ThongKeDoanhThuTheoThang.Name = "btn_ThongKeDoanhThuTheoThang";
            this.btn_ThongKeDoanhThuTheoThang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThongKeDoanhThuTheoThang_ItemClick);
            // 
            // btn_TheoDoiDonHang
            // 
            this.btn_TheoDoiDonHang.Caption = "Theo dõi đơn hàng";
            this.btn_TheoDoiDonHang.Enabled = false;
            this.btn_TheoDoiDonHang.Id = 11;
            this.btn_TheoDoiDonHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TheoDoiDonHang.ImageOptions.Image")));
            this.btn_TheoDoiDonHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TheoDoiDonHang.ImageOptions.LargeImage")));
            this.btn_TheoDoiDonHang.Name = "btn_TheoDoiDonHang";
            this.btn_TheoDoiDonHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TheoDoiDonHang_ItemClick);
            // 
            // btn_ThayDoiGiaMon
            // 
            this.btn_ThayDoiGiaMon.Caption = "Thay đổi giá món ăn";
            this.btn_ThayDoiGiaMon.Enabled = false;
            this.btn_ThayDoiGiaMon.Id = 12;
            this.btn_ThayDoiGiaMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThayDoiGiaMon.ImageOptions.Image")));
            this.btn_ThayDoiGiaMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ThayDoiGiaMon.ImageOptions.LargeImage")));
            this.btn_ThayDoiGiaMon.Name = "btn_ThayDoiGiaMon";
            this.btn_ThayDoiGiaMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThayDoiGiaMon_ItemClick);
            // 
            // btn_PhongBan
            // 
            this.btn_PhongBan.Caption = "Phòng + Bàn";
            this.btn_PhongBan.Enabled = false;
            this.btn_PhongBan.Id = 13;
            this.btn_PhongBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhongBan.ImageOptions.Image")));
            this.btn_PhongBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_PhongBan.ImageOptions.LargeImage")));
            this.btn_PhongBan.Name = "btn_PhongBan";
            this.btn_PhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PhongBan_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_NhanVien);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_TaiKhoan);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_TheoDoiDonHang);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "DANH MỤC";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_LoaiMonAn);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_MonAn);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_ThayDoiGiaMon);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_PhongBan);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_ChiTietPhong);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "THỐNG KÊ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_ThongKeDoanhThuTheoThang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttl_MaNV,
            this.tssl_HoTen,
            this.tssl_BoPhan});
            this.statusStrip.Location = new System.Drawing.Point(0, 738);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1448, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // sttl_MaNV
            // 
            this.sttl_MaNV.Name = "sttl_MaNV";
            this.sttl_MaNV.Size = new System.Drawing.Size(0, 16);
            // 
            // tssl_HoTen
            // 
            this.tssl_HoTen.Name = "tssl_HoTen";
            this.tssl_HoTen.Size = new System.Drawing.Size(0, 16);
            // 
            // tssl_BoPhan
            // 
            this.tssl_BoPhan.Name = "tssl_BoPhan";
            this.tssl_BoPhan.Size = new System.Drawing.Size(0, 16);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Temp";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 760);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "NTH RESTAURANT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public DevExpress.XtraBars.BarButtonItem btn_DangNhap;
        public DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        public DevExpress.XtraBars.BarButtonItem btn_LoaiMonAn;
        public DevExpress.XtraBars.BarButtonItem btn_MonAn;
        public DevExpress.XtraBars.BarButtonItem btn_ChiTietPhong;
        public DevExpress.XtraBars.BarButtonItem btn_NhanVien;
        public DevExpress.XtraBars.BarButtonItem btn_TaiKhoan;
        public DevExpress.XtraBars.BarButtonItem btn_ThongKeDoanhThuTheoThang;
        public DevExpress.XtraBars.BarButtonItem btn_TheoDoiDonHang;
        public DevExpress.XtraBars.BarButtonItem btn_ThayDoiGiaMon;
        public DevExpress.XtraBars.BarButtonItem btn_PhongBan;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel sttl_MaNV;
        public System.Windows.Forms.ToolStripStatusLabel tssl_HoTen;
        public System.Windows.Forms.ToolStripStatusLabel tssl_BoPhan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}

