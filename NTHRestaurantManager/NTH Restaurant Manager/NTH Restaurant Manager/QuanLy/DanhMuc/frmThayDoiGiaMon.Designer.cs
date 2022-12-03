
namespace NTH_Restaurant_Manager
{
    partial class frmThayDoiGiaMon
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
            System.Windows.Forms.Label maMALabel;
            System.Windows.Forms.Label tenMALabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label ngayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThayDoiGiaMon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_CapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.gcMA = new DevExpress.XtraGrid.GridControl();
            this.gvMA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltenMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTDGM = new DevExpress.XtraGrid.GridControl();
            this.gvTDGM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colgia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.de_Ngay = new DevExpress.XtraEditors.DateEdit();
            this.se_Gia = new DevExpress.XtraEditors.SpinEdit();
            this.bdsTDGM = new System.Windows.Forms.BindingSource(this.components);
            this.txt_TenMA = new DevExpress.XtraEditors.TextEdit();
            this.bdsMA = new System.Windows.Forms.BindingSource(this.components);
            this.txt_MaMA = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            maMALabel = new System.Windows.Forms.Label();
            tenMALabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            ngayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTDGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTDGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTDGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaMA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maMALabel
            // 
            maMALabel.AutoSize = true;
            maMALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMALabel.Location = new System.Drawing.Point(22, 77);
            maMALabel.Name = "maMALabel";
            maMALabel.Size = new System.Drawing.Size(121, 27);
            maMALabel.TabIndex = 12;
            maMALabel.Text = "Mã món ăn";
            // 
            // tenMALabel
            // 
            tenMALabel.AutoSize = true;
            tenMALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenMALabel.Location = new System.Drawing.Point(22, 138);
            tenMALabel.Name = "tenMALabel";
            tenMALabel.Size = new System.Drawing.Size(126, 27);
            tenMALabel.TabIndex = 13;
            tenMALabel.Text = "Tên món ăn";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaLabel.Location = new System.Drawing.Point(22, 247);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(46, 27);
            giaLabel.TabIndex = 14;
            giaLabel.Text = "Giá";
            // 
            // ngayLabel
            // 
            ngayLabel.AutoSize = true;
            ngayLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayLabel.Location = new System.Drawing.Point(22, 190);
            ngayLabel.Name = "ngayLabel";
            ngayLabel.Size = new System.Drawing.Size(63, 27);
            ngayLabel.TabIndex = 15;
            ngayLabel.Text = "Ngày";
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
            this.btn_PhucHoi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Xoa),
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
            this.btn_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Them_ItemClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.Id = 3;
            this.btn_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xoa.ImageOptions.SvgImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1776, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 750);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1776, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 720);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1776, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 720);
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
            // gcMA
            // 
            this.gcMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMA.Location = new System.Drawing.Point(2, 2);
            this.gcMA.MainView = this.gvMA;
            this.gcMA.MenuManager = this.barManager1;
            this.gcMA.Name = "gcMA";
            this.gcMA.Size = new System.Drawing.Size(1030, 381);
            this.gcMA.TabIndex = 0;
            this.gcMA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMA});
            // 
            // gvMA
            // 
            this.gvMA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltenMA,
            this.coltrangThai,
            this.colgia});
            this.gvMA.GridControl = this.gcMA;
            this.gvMA.Name = "gvMA";
            this.gvMA.OptionsBehavior.Editable = false;
            this.gvMA.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvMA_RowClick);
            // 
            // coltenMA
            // 
            this.coltenMA.Caption = "TÊN MÓN ĂN";
            this.coltenMA.FieldName = "tenMA";
            this.coltenMA.MinWidth = 25;
            this.coltenMA.Name = "coltenMA";
            this.coltenMA.Visible = true;
            this.coltenMA.VisibleIndex = 0;
            this.coltenMA.Width = 94;
            // 
            // coltrangThai
            // 
            this.coltrangThai.Caption = "TRẠNG THÁI";
            this.coltrangThai.FieldName = "trangThai";
            this.coltrangThai.MinWidth = 25;
            this.coltrangThai.Name = "coltrangThai";
            this.coltrangThai.Visible = true;
            this.coltrangThai.VisibleIndex = 1;
            this.coltrangThai.Width = 94;
            // 
            // colgia
            // 
            this.colgia.Caption = "GIÁ";
            this.colgia.DisplayFormat.FormatString = "n0";
            this.colgia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgia.FieldName = "gia";
            this.colgia.MinWidth = 25;
            this.colgia.Name = "colgia";
            this.colgia.Visible = true;
            this.colgia.VisibleIndex = 2;
            this.colgia.Width = 94;
            // 
            // gcTDGM
            // 
            this.gcTDGM.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTDGM.Location = new System.Drawing.Point(2, 2);
            this.gcTDGM.MainView = this.gvTDGM;
            this.gcTDGM.MenuManager = this.barManager1;
            this.gcTDGM.Name = "gcTDGM";
            this.gcTDGM.Size = new System.Drawing.Size(738, 381);
            this.gcTDGM.TabIndex = 0;
            this.gcTDGM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTDGM});
            // 
            // gvTDGM
            // 
            this.gvTDGM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colgia1,
            this.colngay,
            this.colmama,
            this.colhoTenNV});
            this.gvTDGM.GridControl = this.gcTDGM;
            this.gvTDGM.Name = "gvTDGM";
            this.gvTDGM.OptionsBehavior.Editable = false;
            this.gvTDGM.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvTDGM_RowClick);
            // 
            // colgia1
            // 
            this.colgia1.Caption = "GIÁ";
            this.colgia1.DisplayFormat.FormatString = "n0";
            this.colgia1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgia1.FieldName = "gia";
            this.colgia1.MinWidth = 25;
            this.colgia1.Name = "colgia1";
            this.colgia1.Visible = true;
            this.colgia1.VisibleIndex = 2;
            this.colgia1.Width = 94;
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
            // colmama
            // 
            this.colmama.Caption = "MÃ MÓN ĂN";
            this.colmama.FieldName = "mama";
            this.colmama.MinWidth = 25;
            this.colmama.Name = "colmama";
            this.colmama.Visible = true;
            this.colmama.VisibleIndex = 0;
            this.colmama.Width = 94;
            // 
            // colhoTenNV
            // 
            this.colhoTenNV.Caption = "NHÂN VIÊN";
            this.colhoTenNV.FieldName = "hoTenNV";
            this.colhoTenNV.MinWidth = 25;
            this.colhoTenNV.Name = "colhoTenNV";
            this.colhoTenNV.Visible = true;
            this.colhoTenNV.VisibleIndex = 3;
            this.colhoTenNV.Width = 94;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.gcTDGM);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(1034, 30);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(742, 720);
            this.panelControl.TabIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.gcMA);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1034, 720);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.de_Ngay);
            this.panelControl2.Controls.Add(ngayLabel);
            this.panelControl2.Controls.Add(giaLabel);
            this.panelControl2.Controls.Add(this.se_Gia);
            this.panelControl2.Controls.Add(tenMALabel);
            this.panelControl2.Controls.Add(this.txt_TenMA);
            this.panelControl2.Controls.Add(maMALabel);
            this.panelControl2.Controls.Add(this.txt_MaMA);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 383);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1030, 335);
            this.panelControl2.TabIndex = 1;
            // 
            // de_Ngay
            // 
            this.de_Ngay.EditValue = null;
            this.de_Ngay.Location = new System.Drawing.Point(187, 187);
            this.de_Ngay.MenuManager = this.barManager1;
            this.de_Ngay.Name = "de_Ngay";
            this.de_Ngay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_Ngay.Properties.Appearance.Options.UseFont = true;
            this.de_Ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Ngay.Size = new System.Drawing.Size(572, 32);
            this.de_Ngay.TabIndex = 16;
            // 
            // se_Gia
            // 
            this.se_Gia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTDGM, "gia", true));
            this.se_Gia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_Gia.Location = new System.Drawing.Point(187, 244);
            this.se_Gia.MenuManager = this.barManager1;
            this.se_Gia.Name = "se_Gia";
            this.se_Gia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_Gia.Properties.Appearance.Options.UseFont = true;
            this.se_Gia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_Gia.Properties.DisplayFormat.FormatString = "n0";
            this.se_Gia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.se_Gia.Size = new System.Drawing.Size(572, 32);
            this.se_Gia.TabIndex = 15;
            // 
            // bdsTDGM
            // 
            this.bdsTDGM.DataSource = typeof(NTH_Restaurant_Manager.Model.ThayDoiGiaMonModel);
            // 
            // txt_TenMA
            // 
            this.txt_TenMA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMA, "tenMA", true));
            this.txt_TenMA.Enabled = false;
            this.txt_TenMA.Location = new System.Drawing.Point(187, 135);
            this.txt_TenMA.MenuManager = this.barManager1;
            this.txt_TenMA.Name = "txt_TenMA";
            this.txt_TenMA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenMA.Properties.Appearance.Options.UseFont = true;
            this.txt_TenMA.Size = new System.Drawing.Size(572, 32);
            this.txt_TenMA.TabIndex = 14;
            // 
            // bdsMA
            // 
            this.bdsMA.DataSource = typeof(NTH_Restaurant_Manager.Model.MonAnModel);
            // 
            // txt_MaMA
            // 
            this.txt_MaMA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMA, "maMA", true));
            this.txt_MaMA.Enabled = false;
            this.txt_MaMA.Location = new System.Drawing.Point(187, 74);
            this.txt_MaMA.MenuManager = this.barManager1;
            this.txt_MaMA.Name = "txt_MaMA";
            this.txt_MaMA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaMA.Properties.Appearance.Options.UseFont = true;
            this.txt_MaMA.Size = new System.Drawing.Size(572, 32);
            this.txt_MaMA.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "QUẢN LÝ THAY ĐỔI GIÁ MÓN";
            // 
            // frmThayDoiGiaMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 750);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmThayDoiGiaMon";
            this.Text = "THAY ĐỔI GIÁ MÓN ĂN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTDGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTDGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTDGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaMA.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_CapNhat;
        private DevExpress.XtraBars.BarButtonItem btn_Luu;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraGrid.GridControl gcTDGM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTDGM;
        private DevExpress.XtraGrid.Columns.GridColumn colgia1;
        private DevExpress.XtraGrid.Columns.GridColumn colngay;
        private DevExpress.XtraGrid.Columns.GridColumn colmama;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenNV;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcMA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMA;
        private DevExpress.XtraGrid.Columns.GridColumn coltenMA;
        private DevExpress.XtraGrid.Columns.GridColumn coltrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colgia;
        private System.Windows.Forms.BindingSource bdsMA;
        private System.Windows.Forms.BindingSource bdsTDGM;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SpinEdit se_Gia;
        private DevExpress.XtraEditors.TextEdit txt_TenMA;
        private DevExpress.XtraEditors.TextEdit txt_MaMA;
        private DevExpress.XtraEditors.DateEdit de_Ngay;
    }
}