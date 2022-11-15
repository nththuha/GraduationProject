
namespace NTH_Restaurant_Manager
{
    partial class frmMonAn
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
            System.Windows.Forms.Label tenlmaLabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label hinhAnhLabel;
            System.Windows.Forms.Label trangThaiLabel;
            System.Windows.Forms.Label chuThichLabel;
            System.Windows.Forms.Label tenMALabel;
            System.Windows.Forms.Label maMALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonAn));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bdsMA = new System.Windows.Forms.BindingSource(this.components);
            this.gcMA = new DevExpress.XtraGrid.GridControl();
            this.gvMA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenlma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.cbb_TenLMA = new System.Windows.Forms.ComboBox();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.se_Gia = new DevExpress.XtraEditors.SpinEdit();
            this.txt_HinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.txt_ChuThich = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenMA = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaMA = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            tenlmaLabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            hinhAnhLabel = new System.Windows.Forms.Label();
            trangThaiLabel = new System.Windows.Forms.Label();
            chuThichLabel = new System.Windows.Forms.Label();
            tenMALabel = new System.Windows.Forms.Label();
            maMALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ChuThich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tenlmaLabel
            // 
            tenlmaLabel.AutoSize = true;
            tenlmaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenlmaLabel.Location = new System.Drawing.Point(810, 547);
            tenlmaLabel.Name = "tenlmaLabel";
            tenlmaLabel.Size = new System.Drawing.Size(167, 27);
            tenlmaLabel.TabIndex = 33;
            tenlmaLabel.Text = "Tên loại món ăn";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaLabel.Location = new System.Drawing.Point(811, 502);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(46, 27);
            giaLabel.TabIndex = 31;
            giaLabel.Text = "Giá";
            // 
            // hinhAnhLabel
            // 
            hinhAnhLabel.AutoSize = true;
            hinhAnhLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hinhAnhLabel.Location = new System.Drawing.Point(811, 454);
            hinhAnhLabel.Name = "hinhAnhLabel";
            hinhAnhLabel.Size = new System.Drawing.Size(100, 27);
            hinhAnhLabel.TabIndex = 30;
            hinhAnhLabel.Text = "Hình ảnh";
            // 
            // trangThaiLabel
            // 
            trangThaiLabel.AutoSize = true;
            trangThaiLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trangThaiLabel.Location = new System.Drawing.Point(21, 607);
            trangThaiLabel.Name = "trangThaiLabel";
            trangThaiLabel.Size = new System.Drawing.Size(109, 27);
            trangThaiLabel.TabIndex = 28;
            trangThaiLabel.Text = "Trạng thái";
            // 
            // chuThichLabel
            // 
            chuThichLabel.AutoSize = true;
            chuThichLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chuThichLabel.Location = new System.Drawing.Point(21, 555);
            chuThichLabel.Name = "chuThichLabel";
            chuThichLabel.Size = new System.Drawing.Size(106, 27);
            chuThichLabel.TabIndex = 26;
            chuThichLabel.Text = "Chú thích";
            // 
            // tenMALabel
            // 
            tenMALabel.AutoSize = true;
            tenMALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenMALabel.Location = new System.Drawing.Point(21, 504);
            tenMALabel.Name = "tenMALabel";
            tenMALabel.Size = new System.Drawing.Size(126, 27);
            tenMALabel.TabIndex = 24;
            tenMALabel.Text = "Tên món ăn";
            // 
            // maMALabel
            // 
            maMALabel.AutoSize = true;
            maMALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMALabel.Location = new System.Drawing.Point(21, 455);
            maMALabel.Name = "maMALabel";
            maMALabel.Size = new System.Drawing.Size(121, 27);
            maMALabel.TabIndex = 22;
            maMALabel.Text = "Mã món ăn";
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_CapNhat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Luu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_PhucHoi),
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
            // btn_CapNhat
            // 
            this.btn_CapNhat.Caption = "Cập nhật";
            this.btn_CapNhat.Id = 1;
            this.btn_CapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_CapNhat.ImageOptions.SvgImage")));
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_CapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CapNhat_ItemClick);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Caption = "Lưu";
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Id = 2;
            this.btn_Luu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Luu.ImageOptions.SvgImage")));
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Luu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Luu_ItemClick);
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
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Caption = "Phục Hồi";
            this.btn_PhucHoi.Id = 6;
            this.btn_PhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_PhucHoi.ImageOptions.SvgImage")));
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_PhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PhucHoi_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 840);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 810);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 810);
            // 
            // bdsMA
            // 
            this.bdsMA.DataSource = typeof(NTH_Restaurant_Manager.Model.MonAnModel);
            // 
            // gcMA
            // 
            this.gcMA.DataSource = this.bdsMA;
            this.gcMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMA.Location = new System.Drawing.Point(2, 2);
            this.gcMA.MainView = this.gvMA;
            this.gcMA.MenuManager = this.barManager1;
            this.gcMA.Name = "gcMA";
            this.gcMA.Size = new System.Drawing.Size(1920, 376);
            this.gcMA.TabIndex = 9;
            this.gcMA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMA});
            // 
            // gvMA
            // 
            this.gvMA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaMA,
            this.coltenMA,
            this.colchuThich,
            this.coltrangThai,
            this.colhinhAnh,
            this.colgia,
            this.coltenlma});
            this.gvMA.GridControl = this.gcMA;
            this.gvMA.Name = "gvMA";
            this.gvMA.OptionsBehavior.Editable = false;
            this.gvMA.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvMA_RowClick);
            // 
            // colmaMA
            // 
            this.colmaMA.Caption = "MÃ MÓN ĂN";
            this.colmaMA.FieldName = "maMA";
            this.colmaMA.MinWidth = 25;
            this.colmaMA.Name = "colmaMA";
            this.colmaMA.Visible = true;
            this.colmaMA.VisibleIndex = 0;
            this.colmaMA.Width = 94;
            // 
            // coltenMA
            // 
            this.coltenMA.Caption = "TÊN MÓN ĂN";
            this.coltenMA.FieldName = "tenMA";
            this.coltenMA.MinWidth = 25;
            this.coltenMA.Name = "coltenMA";
            this.coltenMA.Visible = true;
            this.coltenMA.VisibleIndex = 1;
            this.coltenMA.Width = 94;
            // 
            // colchuThich
            // 
            this.colchuThich.Caption = "CHÚ THÍCH";
            this.colchuThich.FieldName = "chuThich";
            this.colchuThich.MinWidth = 25;
            this.colchuThich.Name = "colchuThich";
            this.colchuThich.Visible = true;
            this.colchuThich.VisibleIndex = 2;
            this.colchuThich.Width = 94;
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
            // colhinhAnh
            // 
            this.colhinhAnh.Caption = "HÌNH ẢNH";
            this.colhinhAnh.FieldName = "hinhAnh";
            this.colhinhAnh.MinWidth = 25;
            this.colhinhAnh.Name = "colhinhAnh";
            this.colhinhAnh.Visible = true;
            this.colhinhAnh.VisibleIndex = 4;
            this.colhinhAnh.Width = 94;
            // 
            // colgia
            // 
            this.colgia.Caption = "GIÁ";
            this.colgia.DisplayFormat.FormatString = "{0:0,0}";
            this.colgia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgia.FieldName = "gia";
            this.colgia.MinWidth = 25;
            this.colgia.Name = "colgia";
            this.colgia.Visible = true;
            this.colgia.VisibleIndex = 5;
            this.colgia.Width = 94;
            // 
            // coltenlma
            // 
            this.coltenlma.Caption = "TÊN LOẠI MÓN ĂN";
            this.coltenlma.FieldName = "tenlma";
            this.coltenlma.MinWidth = 25;
            this.coltenlma.Name = "coltenlma";
            this.coltenlma.Visible = true;
            this.coltenlma.VisibleIndex = 6;
            this.coltenlma.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pb_HinhAnh);
            this.panelControl2.Controls.Add(this.cbb_TenLMA);
            this.panelControl2.Controls.Add(this.cbb_TrangThai);
            this.panelControl2.Controls.Add(tenlmaLabel);
            this.panelControl2.Controls.Add(giaLabel);
            this.panelControl2.Controls.Add(this.se_Gia);
            this.panelControl2.Controls.Add(hinhAnhLabel);
            this.panelControl2.Controls.Add(this.txt_HinhAnh);
            this.panelControl2.Controls.Add(trangThaiLabel);
            this.panelControl2.Controls.Add(chuThichLabel);
            this.panelControl2.Controls.Add(this.txt_ChuThich);
            this.panelControl2.Controls.Add(tenMALabel);
            this.panelControl2.Controls.Add(this.txt_TenMA);
            this.panelControl2.Controls.Add(maMALabel);
            this.panelControl2.Controls.Add(this.txt_MaMA);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 30);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1924, 810);
            this.panelControl2.TabIndex = 10;
            // 
            // pb_HinhAnh
            // 
            this.pb_HinhAnh.Location = new System.Drawing.Point(1581, 412);
            this.pb_HinhAnh.Name = "pb_HinhAnh";
            this.pb_HinhAnh.Size = new System.Drawing.Size(270, 270);
            this.pb_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_HinhAnh.TabIndex = 37;
            this.pb_HinhAnh.TabStop = false;
            // 
            // cbb_TenLMA
            // 
            this.cbb_TenLMA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMA, "tenlma", true));
            this.cbb_TenLMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TenLMA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TenLMA.FormattingEnabled = true;
            this.cbb_TenLMA.Location = new System.Drawing.Point(1005, 544);
            this.cbb_TenLMA.Name = "cbb_TenLMA";
            this.cbb_TenLMA.Size = new System.Drawing.Size(478, 34);
            this.cbb_TenLMA.TabIndex = 36;
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMA, "trangThai", true));
            this.cbb_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TrangThai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Items.AddRange(new object[] {
            "Còn món",
            "Hết món"});
            this.cbb_TrangThai.Location = new System.Drawing.Point(215, 604);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(478, 34);
            this.cbb_TrangThai.TabIndex = 35;
            // 
            // se_Gia
            // 
            this.se_Gia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMA, "gia", true));
            this.se_Gia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_Gia.Location = new System.Drawing.Point(1005, 499);
            this.se_Gia.MenuManager = this.barManager1;
            this.se_Gia.Name = "se_Gia";
            this.se_Gia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_Gia.Properties.Appearance.Options.UseFont = true;
            this.se_Gia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_Gia.Size = new System.Drawing.Size(478, 32);
            this.se_Gia.TabIndex = 34;
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMA, "hinhAnh", true));
            this.txt_HinhAnh.Location = new System.Drawing.Point(1005, 451);
            this.txt_HinhAnh.MenuManager = this.barManager1;
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HinhAnh.Properties.Appearance.Options.UseFont = true;
            this.txt_HinhAnh.Size = new System.Drawing.Size(478, 32);
            this.txt_HinhAnh.TabIndex = 32;
            // 
            // txt_ChuThich
            // 
            this.txt_ChuThich.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMA, "chuThich", true));
            this.txt_ChuThich.Location = new System.Drawing.Point(215, 552);
            this.txt_ChuThich.MenuManager = this.barManager1;
            this.txt_ChuThich.Name = "txt_ChuThich";
            this.txt_ChuThich.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChuThich.Properties.Appearance.Options.UseFont = true;
            this.txt_ChuThich.Size = new System.Drawing.Size(478, 32);
            this.txt_ChuThich.TabIndex = 29;
            // 
            // txt_TenMA
            // 
            this.txt_TenMA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMA, "tenMA", true));
            this.txt_TenMA.Location = new System.Drawing.Point(215, 501);
            this.txt_TenMA.MenuManager = this.barManager1;
            this.txt_TenMA.Name = "txt_TenMA";
            this.txt_TenMA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenMA.Properties.Appearance.Options.UseFont = true;
            this.txt_TenMA.Size = new System.Drawing.Size(478, 32);
            this.txt_TenMA.TabIndex = 27;
            // 
            // txt_MaMA
            // 
            this.txt_MaMA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMA, "maMA", true));
            this.txt_MaMA.Location = new System.Drawing.Point(215, 452);
            this.txt_MaMA.MenuManager = this.barManager1;
            this.txt_MaMA.Name = "txt_MaMA";
            this.txt_MaMA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaMA.Properties.Appearance.Options.UseFont = true;
            this.txt_MaMA.Size = new System.Drawing.Size(478, 32);
            this.txt_MaMA.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 35);
            this.label1.TabIndex = 23;
            this.label1.Text = "QUẢN LÝ MÓN ĂN";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcMA);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1924, 380);
            this.panelControl1.TabIndex = 15;
            // 
            // frmMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 840);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMonAn";
            this.Text = "MÓN ĂN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ChuThich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource bdsMA;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcMA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMA;
        private DevExpress.XtraGrid.Columns.GridColumn colmaMA;
        private DevExpress.XtraGrid.Columns.GridColumn coltenMA;
        private DevExpress.XtraGrid.Columns.GridColumn colchuThich;
        private DevExpress.XtraGrid.Columns.GridColumn coltrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colhinhAnh;
        private DevExpress.XtraGrid.Columns.GridColumn colgia;
        private DevExpress.XtraGrid.Columns.GridColumn coltenlma;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pb_HinhAnh;
        private System.Windows.Forms.ComboBox cbb_TenLMA;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
        private DevExpress.XtraEditors.SpinEdit se_Gia;
        private DevExpress.XtraEditors.TextEdit txt_HinhAnh;
        private DevExpress.XtraEditors.TextEdit txt_ChuThich;
        private DevExpress.XtraEditors.TextEdit txt_TenMA;
        private DevExpress.XtraEditors.TextEdit txt_MaMA;
        private System.Windows.Forms.Label label1;
    }
}