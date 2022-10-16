
namespace NTH_Restaurant_Manager
{
    partial class frmLoaiMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiMonAn));
            System.Windows.Forms.Label hinhAnhLabel;
            System.Windows.Forms.Label tenLMALabel;
            System.Windows.Forms.Label maLMALabel;
            this.bdsLMA = new System.Windows.Forms.BindingSource(this.components);
            this.gcLMA = new DevExpress.XtraGrid.GridControl();
            this.gvLMA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaLMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenLMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.txt_HinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenLMA = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaLMA = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            hinhAnhLabel = new System.Windows.Forms.Label();
            tenLMALabel = new System.Windows.Forms.Label();
            maLMALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenLMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaLMA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsLMA
            // 
            this.bdsLMA.DataSource = typeof(NTH_Restaurant_Manager.Model.LoaiMonAnModel);
            // 
            // gcLMA
            // 
            this.gcLMA.DataSource = this.bdsLMA;
            this.gcLMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLMA.Location = new System.Drawing.Point(2, 2);
            this.gcLMA.MainView = this.gvLMA;
            this.gcLMA.Name = "gcLMA";
            this.gcLMA.Size = new System.Drawing.Size(1461, 371);
            this.gcLMA.TabIndex = 5;
            this.gcLMA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLMA});
            // 
            // gvLMA
            // 
            this.gvLMA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaLMA,
            this.coltenLMA,
            this.colhinhAnh});
            this.gvLMA.GridControl = this.gcLMA;
            this.gvLMA.Name = "gvLMA";
            this.gvLMA.OptionsBehavior.Editable = false;
            this.gvLMA.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvLMA_RowClick);
            // 
            // colmaLMA
            // 
            this.colmaLMA.Caption = "MÃ LOẠI MÓN ĂN";
            this.colmaLMA.FieldName = "maLMA";
            this.colmaLMA.MinWidth = 25;
            this.colmaLMA.Name = "colmaLMA";
            this.colmaLMA.Visible = true;
            this.colmaLMA.VisibleIndex = 0;
            this.colmaLMA.Width = 94;
            // 
            // coltenLMA
            // 
            this.coltenLMA.Caption = "TÊN LOẠI MÓN ĂN";
            this.coltenLMA.FieldName = "tenLMA";
            this.coltenLMA.MinWidth = 25;
            this.coltenLMA.Name = "coltenLMA";
            this.coltenLMA.Visible = true;
            this.coltenLMA.VisibleIndex = 1;
            this.coltenLMA.Width = 94;
            // 
            // colhinhAnh
            // 
            this.colhinhAnh.Caption = "HÌNH ẢNH";
            this.colhinhAnh.FieldName = "hinhAnh";
            this.colhinhAnh.MinWidth = 25;
            this.colhinhAnh.Name = "colhinhAnh";
            this.colhinhAnh.Visible = true;
            this.colhinhAnh.VisibleIndex = 2;
            this.colhinhAnh.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pb_HinhAnh);
            this.panelControl2.Controls.Add(hinhAnhLabel);
            this.panelControl2.Controls.Add(this.txt_HinhAnh);
            this.panelControl2.Controls.Add(tenLMALabel);
            this.panelControl2.Controls.Add(this.txt_TenLMA);
            this.panelControl2.Controls.Add(maLMALabel);
            this.panelControl2.Controls.Add(this.txt_MaLMA);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 30);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1465, 711);
            this.panelControl2.TabIndex = 6;
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
            this.bar2.FloatLocation = new System.Drawing.Point(120, 174);
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
            this.btn_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Them_ItemClick_1);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Caption = "Cập nhật";
            this.btn_CapNhat.Id = 1;
            this.btn_CapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_CapNhat.ImageOptions.SvgImage")));
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_CapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CapNhat_ItemClick_1);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Caption = "Lưu";
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Id = 2;
            this.btn_Luu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Luu.ImageOptions.SvgImage")));
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Luu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Luu_ItemClick_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.Id = 3;
            this.btn_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xoa.ImageOptions.SvgImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick_1);
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Caption = "Phục Hồi";
            this.btn_PhucHoi.Id = 6;
            this.btn_PhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_PhucHoi.ImageOptions.SvgImage")));
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_PhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PhucHoi_ItemClick_1);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Caption = "Reload";
            this.btn_Reload.Id = 4;
            this.btn_Reload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Reload.ImageOptions.SvgImage")));
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Reload_ItemClick_1);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 5;
            this.btn_Thoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Thoat.ImageOptions.SvgImage")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thoat_ItemClick_1);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1465, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 741);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1465, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1465, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 711);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcLMA);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1465, 375);
            this.panelControl1.TabIndex = 11;
            // 
            // pb_HinhAnh
            // 
            this.pb_HinhAnh.Location = new System.Drawing.Point(798, 397);
            this.pb_HinhAnh.Name = "pb_HinhAnh";
            this.pb_HinhAnh.Size = new System.Drawing.Size(270, 270);
            this.pb_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_HinhAnh.TabIndex = 15;
            this.pb_HinhAnh.TabStop = false;
            // 
            // hinhAnhLabel
            // 
            hinhAnhLabel.AutoSize = true;
            hinhAnhLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hinhAnhLabel.Location = new System.Drawing.Point(23, 554);
            hinhAnhLabel.Name = "hinhAnhLabel";
            hinhAnhLabel.Size = new System.Drawing.Size(100, 27);
            hinhAnhLabel.TabIndex = 13;
            hinhAnhLabel.Text = "Hình ảnh";
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLMA, "hinhAnh", true));
            this.txt_HinhAnh.Location = new System.Drawing.Point(236, 551);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HinhAnh.Properties.Appearance.Options.UseFont = true;
            this.txt_HinhAnh.Size = new System.Drawing.Size(487, 32);
            this.txt_HinhAnh.TabIndex = 14;
            // 
            // tenLMALabel
            // 
            tenLMALabel.AutoSize = true;
            tenLMALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLMALabel.Location = new System.Drawing.Point(23, 502);
            tenLMALabel.Name = "tenLMALabel";
            tenLMALabel.Size = new System.Drawing.Size(167, 27);
            tenLMALabel.TabIndex = 11;
            tenLMALabel.Text = "Tên loại món ăn";
            // 
            // txt_TenLMA
            // 
            this.txt_TenLMA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLMA, "tenLMA", true));
            this.txt_TenLMA.Location = new System.Drawing.Point(236, 499);
            this.txt_TenLMA.Name = "txt_TenLMA";
            this.txt_TenLMA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLMA.Properties.Appearance.Options.UseFont = true;
            this.txt_TenLMA.Size = new System.Drawing.Size(487, 32);
            this.txt_TenLMA.TabIndex = 12;
            // 
            // maLMALabel
            // 
            maLMALabel.AutoSize = true;
            maLMALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLMALabel.Location = new System.Drawing.Point(23, 447);
            maLMALabel.Name = "maLMALabel";
            maLMALabel.Size = new System.Drawing.Size(162, 27);
            maLMALabel.TabIndex = 9;
            maLMALabel.Text = "Mã loại món ăn";
            // 
            // txt_MaLMA
            // 
            this.txt_MaLMA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLMA, "maLMA", true));
            this.txt_MaLMA.Location = new System.Drawing.Point(236, 444);
            this.txt_MaLMA.Name = "txt_MaLMA";
            this.txt_MaLMA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLMA.Properties.Appearance.Options.UseFont = true;
            this.txt_MaLMA.Size = new System.Drawing.Size(487, 32);
            this.txt_MaLMA.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ LOẠI MÓN ĂN";
            // 
            // frmLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 741);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLoaiMonAn";
            this.Text = "LOẠI MÓN ĂN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bdsLMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_HinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenLMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaLMA.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcLMA;
        private System.Windows.Forms.BindingSource bdsLMA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLMA;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colmaLMA;
        private DevExpress.XtraGrid.Columns.GridColumn coltenLMA;
        private DevExpress.XtraGrid.Columns.GridColumn colhinhAnh;
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
        private System.Windows.Forms.PictureBox pb_HinhAnh;
        private DevExpress.XtraEditors.TextEdit txt_HinhAnh;
        private DevExpress.XtraEditors.TextEdit txt_TenLMA;
        private DevExpress.XtraEditors.TextEdit txt_MaLMA;
        private System.Windows.Forms.Label label1;
    }
}