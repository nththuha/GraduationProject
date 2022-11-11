
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
            this.colhoTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gcPDTemp = new DevExpress.XtraGrid.GridControl();
            this.gvPDTemp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidnv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTenNV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenBan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenPhong1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidPDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTenKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPDTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPDTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcPDTemp);
            this.panelControl1.Controls.Add(this.gcPD);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1045, 772);
            this.panelControl1.TabIndex = 0;
            // 
            // gcPD
            // 
            this.gcPD.DataSource = this.bdsPD;
            this.gcPD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcPD.Location = new System.Drawing.Point(2, 2);
            this.gcPD.MainView = this.gvPD;
            this.gcPD.Margin = new System.Windows.Forms.Padding(4);
            this.gcPD.Name = "gcPD";
            this.gcPD.Size = new System.Drawing.Size(1041, 387);
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
            this.coltenPhong,
            this.colhoTenKH});
            this.gvPD.DetailHeight = 437;
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
            this.colhoTenNV.Caption = "NHÂN VIÊN";
            this.colhoTenNV.FieldName = "hoTenNV";
            this.colhoTenNV.MinWidth = 25;
            this.colhoTenNV.Name = "colhoTenNV";
            this.colhoTenNV.Visible = true;
            this.colhoTenNV.VisibleIndex = 4;
            this.colhoTenNV.Width = 94;
            // 
            // coltenBan
            // 
            this.coltenBan.Caption = "TÊN BÀN";
            this.coltenBan.FieldName = "tenBan";
            this.coltenBan.MinWidth = 25;
            this.coltenBan.Name = "coltenBan";
            this.coltenBan.Visible = true;
            this.coltenBan.VisibleIndex = 3;
            this.coltenBan.Width = 94;
            // 
            // coltenPhong
            // 
            this.coltenPhong.Caption = "TÊN PHÒNG";
            this.coltenPhong.FieldName = "tenPhong";
            this.coltenPhong.MinWidth = 25;
            this.coltenPhong.Name = "coltenPhong";
            this.coltenPhong.Visible = true;
            this.coltenPhong.VisibleIndex = 5;
            this.coltenPhong.Width = 94;
            // 
            // colhoTenKH
            // 
            this.colhoTenKH.Caption = "KHÁCH HÀNG";
            this.colhoTenKH.FieldName = "hoTenKH";
            this.colhoTenKH.MinWidth = 25;
            this.colhoTenKH.Name = "colhoTenKH";
            this.colhoTenKH.Visible = true;
            this.colhoTenKH.VisibleIndex = 2;
            this.colhoTenKH.Width = 94;
            // 
            // bdsCTDM
            // 
            this.bdsCTDM.DataSource = typeof(NTH_Restaurant_Manager.Model.CTDatMonModel);
            // 
            // gcCTDM
            // 
            this.gcCTDM.DataSource = this.bdsCTDM;
            this.gcCTDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTDM.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcCTDM.Location = new System.Drawing.Point(1045, 30);
            this.gcCTDM.MainView = this.gvCTDM;
            this.gcCTDM.Margin = new System.Windows.Forms.Padding(4);
            this.gcCTDM.Name = "gcCTDM";
            this.gcCTDM.Size = new System.Drawing.Size(588, 389);
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
            this.gvCTDM.DetailHeight = 437;
            this.gvCTDM.GridControl = this.gcCTDM;
            this.gvCTDM.Name = "gvCTDM";
            this.gvCTDM.OptionsBehavior.Editable = false;
            // 
            // coltenma
            // 
            this.coltenma.Caption = "TÊN MÓN ĂN";
            this.coltenma.FieldName = "tenma";
            this.coltenma.MinWidth = 31;
            this.coltenma.Name = "coltenma";
            this.coltenma.Visible = true;
            this.coltenma.VisibleIndex = 0;
            this.coltenma.Width = 117;
            // 
            // colsoLuong
            // 
            this.colsoLuong.Caption = "SỐ LƯỢNG";
            this.colsoLuong.FieldName = "soLuong";
            this.colsoLuong.MinWidth = 31;
            this.colsoLuong.Name = "colsoLuong";
            this.colsoLuong.Visible = true;
            this.colsoLuong.VisibleIndex = 1;
            this.colsoLuong.Width = 117;
            // 
            // colgia
            // 
            this.colgia.Caption = "GIÁ";
            this.colgia.FieldName = "gia";
            this.colgia.MinWidth = 31;
            this.colgia.Name = "colgia";
            this.colgia.Visible = true;
            this.colgia.VisibleIndex = 2;
            this.colgia.Width = 117;
            // 
            // coltrangThai
            // 
            this.coltrangThai.Caption = "TRẠNG THÁI";
            this.coltrangThai.FieldName = "trangThai";
            this.coltrangThai.MinWidth = 31;
            this.coltrangThai.Name = "coltrangThai";
            this.coltrangThai.Visible = true;
            this.coltrangThai.VisibleIndex = 3;
            this.coltrangThai.Width = 117;
            // 
            // colchuThich
            // 
            this.colchuThich.Caption = "CHÚ THÍCH";
            this.colchuThich.FieldName = "chuThich";
            this.colchuThich.MinWidth = 31;
            this.colchuThich.Name = "colchuThich";
            this.colchuThich.Visible = true;
            this.colchuThich.VisibleIndex = 4;
            this.colchuThich.Width = 117;
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
            this.btn_Reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Reload_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1633, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 802);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1633, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 772);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1633, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 772);
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
            // gcPDTemp
            // 
            this.gcPDTemp.DataSource = this.bdsPD;
            this.gcPDTemp.Location = new System.Drawing.Point(107, 447);
            this.gcPDTemp.MainView = this.gvPDTemp;
            this.gcPDTemp.MenuManager = this.barManager1;
            this.gcPDTemp.Name = "gcPDTemp";
            this.gcPDTemp.Size = new System.Drawing.Size(824, 261);
            this.gcPDTemp.TabIndex = 1;
            this.gcPDTemp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPDTemp});
            // 
            // gvPDTemp
            // 
            this.gvPDTemp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPD1,
            this.colngay1,
            this.colidnv,
            this.colhoTenNV1,
            this.colmaBan,
            this.coltenBan1,
            this.colmaPhong,
            this.coltenPhong1,
            this.colidPDT,
            this.colhoTenKH1});
            this.gvPDTemp.GridControl = this.gcPDTemp;
            this.gvPDTemp.Name = "gvPDTemp";
            // 
            // colidPD1
            // 
            this.colidPD1.Caption = "ID PHIẾU ĐẶT";
            this.colidPD1.FieldName = "idPD";
            this.colidPD1.MinWidth = 25;
            this.colidPD1.Name = "colidPD1";
            this.colidPD1.Visible = true;
            this.colidPD1.VisibleIndex = 0;
            this.colidPD1.Width = 94;
            // 
            // colngay1
            // 
            this.colngay1.Caption = "NGÀY";
            this.colngay1.FieldName = "ngay";
            this.colngay1.MinWidth = 25;
            this.colngay1.Name = "colngay1";
            this.colngay1.Visible = true;
            this.colngay1.VisibleIndex = 1;
            this.colngay1.Width = 94;
            // 
            // colidnv
            // 
            this.colidnv.FieldName = "idnv";
            this.colidnv.MinWidth = 25;
            this.colidnv.Name = "colidnv";
            this.colidnv.Width = 94;
            // 
            // colhoTenNV1
            // 
            this.colhoTenNV1.Caption = "NHÂN VIÊN";
            this.colhoTenNV1.FieldName = "hoTenNV";
            this.colhoTenNV1.MinWidth = 25;
            this.colhoTenNV1.Name = "colhoTenNV1";
            this.colhoTenNV1.Visible = true;
            this.colhoTenNV1.VisibleIndex = 2;
            this.colhoTenNV1.Width = 94;
            // 
            // colmaBan
            // 
            this.colmaBan.FieldName = "maBan";
            this.colmaBan.MinWidth = 25;
            this.colmaBan.Name = "colmaBan";
            this.colmaBan.Width = 94;
            // 
            // coltenBan1
            // 
            this.coltenBan1.Caption = "TÊN BÀN";
            this.coltenBan1.FieldName = "tenBan";
            this.coltenBan1.MinWidth = 25;
            this.coltenBan1.Name = "coltenBan1";
            this.coltenBan1.Visible = true;
            this.coltenBan1.VisibleIndex = 4;
            this.coltenBan1.Width = 94;
            // 
            // colmaPhong
            // 
            this.colmaPhong.FieldName = "maPhong";
            this.colmaPhong.MinWidth = 25;
            this.colmaPhong.Name = "colmaPhong";
            this.colmaPhong.Width = 94;
            // 
            // coltenPhong1
            // 
            this.coltenPhong1.Caption = "TÊN PHÒNG";
            this.coltenPhong1.FieldName = "tenPhong";
            this.coltenPhong1.MinWidth = 25;
            this.coltenPhong1.Name = "coltenPhong1";
            this.coltenPhong1.Visible = true;
            this.coltenPhong1.VisibleIndex = 3;
            this.coltenPhong1.Width = 94;
            // 
            // colidPDT
            // 
            this.colidPDT.FieldName = "idPDT";
            this.colidPDT.MinWidth = 25;
            this.colidPDT.Name = "colidPDT";
            this.colidPDT.Width = 94;
            // 
            // colhoTenKH1
            // 
            this.colhoTenKH1.FieldName = "hoTenKH";
            this.colhoTenKH1.MinWidth = 25;
            this.colhoTenKH1.Name = "colhoTenKH1";
            this.colhoTenKH1.Width = 94;
            // 
            // frmTheoDoiDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 802);
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
            ((System.ComponentModel.ISupportInitialize)(this.gcPDTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPDTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcPD;
        private System.Windows.Forms.BindingSource bdsPD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPD;
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
        private DevExpress.XtraGrid.Columns.GridColumn colidPD;
        private DevExpress.XtraGrid.Columns.GridColumn colngay;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn coltenBan;
        private DevExpress.XtraGrid.Columns.GridColumn coltenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenKH;
        private DevExpress.XtraGrid.GridControl gcPDTemp;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPDTemp;
        private DevExpress.XtraGrid.Columns.GridColumn colidPD1;
        private DevExpress.XtraGrid.Columns.GridColumn colngay1;
        private DevExpress.XtraGrid.Columns.GridColumn colidnv;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenNV1;
        private DevExpress.XtraGrid.Columns.GridColumn colmaBan;
        private DevExpress.XtraGrid.Columns.GridColumn coltenBan1;
        private DevExpress.XtraGrid.Columns.GridColumn colmaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn coltenPhong1;
        private DevExpress.XtraGrid.Columns.GridColumn colidPDT;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenKH1;
    }
}