
namespace NTH_Restaurant_Manager
{
    partial class frmChitietMonAn
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
            System.Windows.Forms.Label soLuongLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChitietMonAn));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcNL = new DevExpress.XtraGrid.GridControl();
            this.bdsNL = new System.Windows.Forms.BindingSource(this.components);
            this.gvNL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colslTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMA = new DevExpress.XtraGrid.GridControl();
            this.bdsMA = new System.Windows.Forms.BindingSource(this.components);
            this.gvMA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltenMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.se_SoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.bdsCTMA = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gcCTMA = new DevExpress.XtraGrid.GridControl();
            this.gvCTMA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennl1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonVi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            soLuongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.se_SoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTMA)).BeginInit();
            this.SuspendLayout();
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongLabel.Location = new System.Drawing.Point(28, 430);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(97, 27);
            soLuongLabel.TabIndex = 13;
            soLuongLabel.Text = "Số lượng";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1657, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 702);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1657, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 672);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1657, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 672);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gcNL);
            this.panel1.Controls.Add(this.gcMA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 672);
            this.panel1.TabIndex = 4;
            // 
            // gcNL
            // 
            this.gcNL.DataSource = this.bdsNL;
            this.gcNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNL.Location = new System.Drawing.Point(0, 356);
            this.gcNL.MainView = this.gvNL;
            this.gcNL.MenuManager = this.barManager1;
            this.gcNL.Name = "gcNL";
            this.gcNL.Size = new System.Drawing.Size(1022, 316);
            this.gcNL.TabIndex = 1;
            this.gcNL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNL});
            // 
            // bdsNL
            // 
            this.bdsNL.DataSource = typeof(NTH_Restaurant_Manager.Model.NguyenLieuModel);
            // 
            // gvNL
            // 
            this.gvNL.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltenNL,
            this.coldonVi,
            this.colslTon});
            this.gvNL.GridControl = this.gcNL;
            this.gvNL.Name = "gvNL";
            this.gvNL.OptionsBehavior.Editable = false;
            this.gvNL.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvNL_RowClick);
            // 
            // coltenNL
            // 
            this.coltenNL.Caption = "TÊN NGUYÊN LIỆU";
            this.coltenNL.FieldName = "tenNL";
            this.coltenNL.MinWidth = 25;
            this.coltenNL.Name = "coltenNL";
            this.coltenNL.Visible = true;
            this.coltenNL.VisibleIndex = 0;
            this.coltenNL.Width = 94;
            // 
            // coldonVi
            // 
            this.coldonVi.Caption = "ĐƠN VỊ";
            this.coldonVi.FieldName = "donVi";
            this.coldonVi.MinWidth = 25;
            this.coldonVi.Name = "coldonVi";
            this.coldonVi.Visible = true;
            this.coldonVi.VisibleIndex = 1;
            this.coldonVi.Width = 94;
            // 
            // colslTon
            // 
            this.colslTon.Caption = "SỐ LƯỢNG TỒN";
            this.colslTon.DisplayFormat.FormatString = "{0:0,0}";
            this.colslTon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colslTon.FieldName = "slTon";
            this.colslTon.MinWidth = 25;
            this.colslTon.Name = "colslTon";
            this.colslTon.Visible = true;
            this.colslTon.VisibleIndex = 2;
            this.colslTon.Width = 94;
            // 
            // gcMA
            // 
            this.gcMA.DataSource = this.bdsMA;
            this.gcMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMA.Location = new System.Drawing.Point(0, 0);
            this.gcMA.MainView = this.gvMA;
            this.gcMA.MenuManager = this.barManager1;
            this.gcMA.Name = "gcMA";
            this.gcMA.Size = new System.Drawing.Size(1022, 356);
            this.gcMA.TabIndex = 0;
            this.gcMA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMA});
            // 
            // bdsMA
            // 
            this.bdsMA.DataSource = typeof(NTH_Restaurant_Manager.Model.MonAnModel);
            // 
            // gvMA
            // 
            this.gvMA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltenMA,
            this.colchuThich,
            this.coltrangThai});
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
            // colchuThich
            // 
            this.colchuThich.Caption = "CHÚ THÍCH";
            this.colchuThich.FieldName = "chuThich";
            this.colchuThich.MinWidth = 25;
            this.colchuThich.Name = "colchuThich";
            this.colchuThich.Visible = true;
            this.colchuThich.VisibleIndex = 1;
            this.colchuThich.Width = 94;
            // 
            // coltrangThai
            // 
            this.coltrangThai.Caption = "TRẠNG THÁI";
            this.coltrangThai.FieldName = "trangThai";
            this.coltrangThai.MinWidth = 25;
            this.coltrangThai.Name = "coltrangThai";
            this.coltrangThai.Visible = true;
            this.coltrangThai.VisibleIndex = 2;
            this.coltrangThai.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(soLuongLabel);
            this.panelControl1.Controls.Add(this.se_SoLuong);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.gcCTMA);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(1022, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(635, 672);
            this.panelControl1.TabIndex = 5;
            // 
            // se_SoLuong
            // 
            this.se_SoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTMA, "soLuong", true));
            this.se_SoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_SoLuong.Location = new System.Drawing.Point(159, 427);
            this.se_SoLuong.MenuManager = this.barManager1;
            this.se_SoLuong.Name = "se_SoLuong";
            this.se_SoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_SoLuong.Properties.Appearance.Options.UseFont = true;
            this.se_SoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_SoLuong.Size = new System.Drawing.Size(435, 32);
            this.se_SoLuong.TabIndex = 14;
            // 
            // bdsCTMA
            // 
            this.bdsCTMA.DataSource = typeof(NTH_Restaurant_Manager.Model.CTMonAnModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "QUẢN LÝ CÔNG THỨC MÓN ĂN";
            // 
            // gcCTMA
            // 
            this.gcCTMA.DataSource = this.bdsCTMA;
            this.gcCTMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTMA.Location = new System.Drawing.Point(2, 2);
            this.gcCTMA.MainView = this.gvCTMA;
            this.gcCTMA.MenuManager = this.barManager1;
            this.gcCTMA.Name = "gcCTMA";
            this.gcCTMA.Size = new System.Drawing.Size(631, 354);
            this.gcCTMA.TabIndex = 0;
            this.gcCTMA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTMA});
            // 
            // gvCTMA
            // 
            this.gvCTMA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsoLuong,
            this.coltennl1,
            this.coldonVi1});
            this.gvCTMA.GridControl = this.gcCTMA;
            this.gvCTMA.Name = "gvCTMA";
            this.gvCTMA.OptionsBehavior.Editable = false;
            this.gvCTMA.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCTMA_RowClick);
            // 
            // colsoLuong
            // 
            this.colsoLuong.Caption = "SỐ LƯỢNG";
            this.colsoLuong.DisplayFormat.FormatString = "{0:0,0}";
            this.colsoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsoLuong.FieldName = "soLuong";
            this.colsoLuong.MinWidth = 25;
            this.colsoLuong.Name = "colsoLuong";
            this.colsoLuong.Visible = true;
            this.colsoLuong.VisibleIndex = 2;
            this.colsoLuong.Width = 94;
            // 
            // coltennl1
            // 
            this.coltennl1.Caption = "TÊN NGUYÊN LIỆU";
            this.coltennl1.FieldName = "tennl";
            this.coltennl1.MinWidth = 25;
            this.coltennl1.Name = "coltennl1";
            this.coltennl1.Visible = true;
            this.coltennl1.VisibleIndex = 0;
            this.coltennl1.Width = 94;
            // 
            // coldonVi1
            // 
            this.coldonVi1.Caption = "ĐƠN VỊ";
            this.coldonVi1.FieldName = "donVi";
            this.coldonVi1.MinWidth = 25;
            this.coldonVi1.Name = "coldonVi1";
            this.coldonVi1.Visible = true;
            this.coldonVi1.VisibleIndex = 1;
            this.coldonVi1.Width = 94;
            // 
            // frmChitietMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 702);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChitietMonAn";
            this.Text = "CÔNG THỨC MÓN ĂN";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.se_SoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTMA)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcNL;
        private System.Windows.Forms.BindingSource bdsNL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNL;
        private DevExpress.XtraGrid.GridControl gcMA;
        private System.Windows.Forms.BindingSource bdsMA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMA;
        private DevExpress.XtraGrid.GridControl gcCTMA;
        private System.Windows.Forms.BindingSource bdsCTMA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTMA;
        private DevExpress.XtraGrid.Columns.GridColumn coltenMA;
        private DevExpress.XtraGrid.Columns.GridColumn colchuThich;
        private DevExpress.XtraGrid.Columns.GridColumn coltrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn coltenNL;
        private DevExpress.XtraGrid.Columns.GridColumn coldonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colslTon;
        private DevExpress.XtraGrid.Columns.GridColumn colsoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn coltennl1;
        private DevExpress.XtraGrid.Columns.GridColumn coldonVi1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit se_SoLuong;
    }
}