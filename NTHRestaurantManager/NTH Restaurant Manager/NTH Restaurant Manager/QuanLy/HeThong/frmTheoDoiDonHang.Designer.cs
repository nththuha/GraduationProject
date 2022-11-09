
namespace NTH_Restaurant_Manager
{
    partial class frmTheoDoiDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheoDoiDonHang));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcPD = new DevExpress.XtraGrid.GridControl();
            this.bdsPD = new System.Windows.Forms.BindingSource(this.components);
            this.gvPD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTDM = new System.Windows.Forms.BindingSource(this.components);
            this.gcCTDM = new DevExpress.XtraGrid.GridControl();
            this.gvCTDM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltenma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XuatHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_CapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcPD);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(976, 711);
            this.panelControl1.TabIndex = 0;
            // 
            // gcPD
            // 
            this.gcPD.DataSource = this.bdsPD;
            this.gcPD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPD.Location = new System.Drawing.Point(2, 2);
            this.gcPD.MainView = this.gvPD;
            this.gcPD.Name = "gcPD";
            this.gcPD.Size = new System.Drawing.Size(972, 403);
            this.gcPD.TabIndex = 0;
            this.gcPD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPD});
            // 
            // bdsPD
            // 
            this.bdsPD.DataSource = typeof(NTH_Restaurant_Manager.Model.PhieuDatModel);
            // 
            // gvPD
            // 
            this.gvPD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPD,
            this.colngay,
            this.colhoTenNV,
            this.coltenBan,
            this.coltenPhong});
            this.gvPD.GridControl = this.gcPD;
            this.gvPD.Name = "gvPD";
            this.gvPD.OptionsBehavior.Editable = false;
            this.gvPD.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPD_RowClick);
            // 
            // colidPD
            // 
            this.colidPD.Caption = "ID PHIẾU ĐẶT";
            this.colidPD.FieldName = "idPD";
            this.colidPD.MinWidth = 25;
            this.colidPD.Name = "colidPD";
            this.colidPD.Visible = true;
            this.colidPD.VisibleIndex = 0;
            this.colidPD.Width = 94;
            // 
            // colngay
            // 
            this.colngay.Caption = "NGÀY";
            this.colngay.FieldName = "ngay";
            this.colngay.MinWidth = 25;
            this.colngay.Name = "colngay";
            this.colngay.Visible = true;
            this.colngay.VisibleIndex = 1;
            this.colngay.Width = 94;
            // 
            // colhoTenNV
            // 
            this.colhoTenNV.Caption = "NHÂN VIÊN LẬP PHẾU";
            this.colhoTenNV.FieldName = "hoTenNV";
            this.colhoTenNV.MinWidth = 25;
            this.colhoTenNV.Name = "colhoTenNV";
            this.colhoTenNV.Visible = true;
            this.colhoTenNV.VisibleIndex = 2;
            this.colhoTenNV.Width = 94;
            // 
            // coltenBan
            // 
            this.coltenBan.Caption = "TÊN BÀN";
            this.coltenBan.FieldName = "tenBan";
            this.coltenBan.MinWidth = 25;
            this.coltenBan.Name = "coltenBan";
            this.coltenBan.Visible = true;
            this.coltenBan.VisibleIndex = 4;
            this.coltenBan.Width = 94;
            // 
            // coltenPhong
            // 
            this.coltenPhong.Caption = "TÊN PHÒNG";
            this.coltenPhong.FieldName = "tenPhong";
            this.coltenPhong.MinWidth = 25;
            this.coltenPhong.Name = "coltenPhong";
            this.coltenPhong.Visible = true;
            this.coltenPhong.VisibleIndex = 3;
            this.coltenPhong.Width = 94;
            // 
            // bdsCTDM
            // 
            this.bdsCTDM.DataSource = typeof(NTH_Restaurant_Manager.Model.CTDatMonModel);
            // 
            // gcCTDM
            // 
            this.gcCTDM.DataSource = this.bdsCTDM;
            this.gcCTDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTDM.Location = new System.Drawing.Point(976, 30);
            this.gcCTDM.MainView = this.gvCTDM;
            this.gcCTDM.Name = "gcCTDM";
            this.gcCTDM.Size = new System.Drawing.Size(444, 405);
            this.gcCTDM.TabIndex = 1;
            this.gcCTDM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDM});
            // 
            // gvCTDM
            // 
            this.gvCTDM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltenma,
            this.colsoLuong,
            this.colgia,
            this.coltrangThai,
            this.colchuThich});
            this.gvCTDM.GridControl = this.gcCTDM;
            this.gvCTDM.Name = "gvCTDM";
            this.gvCTDM.OptionsBehavior.Editable = false;
            // 
            // coltenma
            // 
            this.coltenma.Caption = "TÊN MÓN ĂN";
            this.coltenma.FieldName = "tenma";
            this.coltenma.MinWidth = 25;
            this.coltenma.Name = "coltenma";
            this.coltenma.Visible = true;
            this.coltenma.VisibleIndex = 0;
            this.coltenma.Width = 94;
            // 
            // colsoLuong
            // 
            this.colsoLuong.Caption = "SỐ LƯỢNG";
            this.colsoLuong.FieldName = "soLuong";
            this.colsoLuong.MinWidth = 25;
            this.colsoLuong.Name = "colsoLuong";
            this.colsoLuong.Visible = true;
            this.colsoLuong.VisibleIndex = 1;
            this.colsoLuong.Width = 94;
            // 
            // colgia
            // 
            this.colgia.Caption = "GIÁ";
            this.colgia.FieldName = "gia";
            this.colgia.MinWidth = 25;
            this.colgia.Name = "colgia";
            this.colgia.Visible = true;
            this.colgia.VisibleIndex = 2;
            this.colgia.Width = 94;
            // 
            // coltrangThai
            // 
            this.coltrangThai.Caption = "TRẠNG THÁI";
            this.coltrangThai.FieldName = "trangThai";
            this.coltrangThai.MinWidth = 25;
            this.coltrangThai.Name = "coltrangThai";
            this.coltrangThai.Visible = true;
            this.coltrangThai.VisibleIndex = 3;
            this.coltrangThai.Width = 94;
            // 
            // colchuThich
            // 
            this.colchuThich.Caption = "CHÚ THÍCH";
            this.colchuThich.FieldName = "chuThich";
            this.colchuThich.MinWidth = 25;
            this.colchuThich.Name = "colchuThich";
            this.colchuThich.Visible = true;
            this.colchuThich.VisibleIndex = 4;
            this.colchuThich.Width = 94;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Them,
            this.btn_CapNhat,
            this.btn_Luu,
            this.btn_Xoa,
            this.btn_Reload,
            this.btn_Thoat,
            this.btn_PhucHoi,
            this.btn_XuatHoaDon});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(143, 170);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_XuatHoaDon),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Thoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_Them
            // 
            this.btn_Them.Caption = "Thêm";
            this.btn_Them.Id = 0;
            this.btn_Them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Them.ImageOptions.SvgImage")));
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.Id = 3;
            this.btn_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xoa.ImageOptions.SvgImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_XuatHoaDon
            // 
            this.btn_XuatHoaDon.Caption = "Xuất hóa đơn";
            this.btn_XuatHoaDon.Id = 7;
            this.btn_XuatHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatHoaDon.ImageOptions.Image")));
            this.btn_XuatHoaDon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_XuatHoaDon.ImageOptions.LargeImage")));
            this.btn_XuatHoaDon.Name = "btn_XuatHoaDon";
            this.btn_XuatHoaDon.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Reload
            // 
            this.btn_Reload.Caption = "Reload";
            this.btn_Reload.Id = 4;
            this.btn_Reload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Reload.ImageOptions.SvgImage")));
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 5;
            this.btn_Thoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Thoat.ImageOptions.SvgImage")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1420, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 741);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1420, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 711);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1420, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 711);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Caption = "Cập nhật";
            this.btn_CapNhat.Id = 1;
            this.btn_CapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_CapNhat.ImageOptions.SvgImage")));
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Caption = "Lưu";
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Id = 2;
            this.btn_Luu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Luu.ImageOptions.SvgImage")));
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Caption = "Phục Hồi";
            this.btn_PhucHoi.Id = 6;
            this.btn_PhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_PhucHoi.ImageOptions.SvgImage")));
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // frmTheoDoiDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 741);
            this.Controls.Add(this.gcCTDM);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTheoDoiDonHang";
            this.Text = "THEO DÕI ĐƠN HÀNG - KHÁCH VÃNG LAI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcPD;
        private System.Windows.Forms.BindingSource bdsPD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPD;
        private DevExpress.XtraGrid.Columns.GridColumn colidPD;
        private DevExpress.XtraGrid.Columns.GridColumn colngay;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn coltenBan;
        private DevExpress.XtraGrid.Columns.GridColumn coltenPhong;
        private System.Windows.Forms.BindingSource bdsCTDM;
        private DevExpress.XtraGrid.GridControl gcCTDM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDM;
        private DevExpress.XtraGrid.Columns.GridColumn coltenma;
        private DevExpress.XtraGrid.Columns.GridColumn colsoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colgia;
        private DevExpress.XtraGrid.Columns.GridColumn coltrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colchuThich;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_CapNhat;
        private DevExpress.XtraBars.BarButtonItem btn_Luu;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_XuatHoaDon;
    }
}