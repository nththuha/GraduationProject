
namespace NTH_Restaurant_Manager
{
    partial class frmKhachHang
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
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label cmndLabel;
            System.Windows.Forms.Label sdtLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
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
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.gcKH = new DevExpress.XtraGrid.GridControl();
            this.gvKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colhoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_CMND = new DevExpress.XtraEditors.TextEdit();
            this.txt_HoTen = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            cmndLabel = new System.Windows.Forms.Label();
            sdtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HoTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoTenLabel.Location = new System.Drawing.Point(24, 70);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(106, 27);
            hoTenLabel.TabIndex = 9;
            hoTenLabel.Text = "Họ và tên";
            // 
            // cmndLabel
            // 
            cmndLabel.AutoSize = true;
            cmndLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmndLabel.Location = new System.Drawing.Point(24, 126);
            cmndLabel.Name = "cmndLabel";
            cmndLabel.Size = new System.Drawing.Size(83, 27);
            cmndLabel.TabIndex = 10;
            cmndLabel.Text = "CMND";
            // 
            // sdtLabel
            // 
            sdtLabel.AutoSize = true;
            sdtLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sdtLabel.Location = new System.Drawing.Point(24, 181);
            sdtLabel.Name = "sdtLabel";
            sdtLabel.Size = new System.Drawing.Size(137, 27);
            sdtLabel.TabIndex = 11;
            sdtLabel.Text = "Số điện thoại";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1446, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 720);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1446, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 690);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1446, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 690);
            // 
            // bdsKH
            // 
            this.bdsKH.DataSource = typeof(NTH_Restaurant_Manager.Model.KhachHangModel);
            // 
            // gcKH
            // 
            this.gcKH.DataSource = this.bdsKH;
            this.gcKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKH.Location = new System.Drawing.Point(0, 30);
            this.gcKH.MainView = this.gvKH;
            this.gcKH.MenuManager = this.barManager1;
            this.gcKH.Name = "gcKH";
            this.gcKH.Size = new System.Drawing.Size(1446, 362);
            this.gcKH.TabIndex = 5;
            this.gcKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKH});
            // 
            // gvKH
            // 
            this.gvKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colhoTen,
            this.colcmnd,
            this.colsdt});
            this.gvKH.GridControl = this.gcKH;
            this.gvKH.Name = "gvKH";
            this.gvKH.OptionsBehavior.Editable = false;
            this.gvKH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvKH_RowClick);
            // 
            // colhoTen
            // 
            this.colhoTen.Caption = "HỌ TÊN KHÁCH HÀNG";
            this.colhoTen.FieldName = "hoTen";
            this.colhoTen.MinWidth = 25;
            this.colhoTen.Name = "colhoTen";
            this.colhoTen.Visible = true;
            this.colhoTen.VisibleIndex = 0;
            this.colhoTen.Width = 94;
            // 
            // colcmnd
            // 
            this.colcmnd.Caption = "CMND";
            this.colcmnd.FieldName = "cmnd";
            this.colcmnd.MinWidth = 25;
            this.colcmnd.Name = "colcmnd";
            this.colcmnd.Visible = true;
            this.colcmnd.VisibleIndex = 1;
            this.colcmnd.Width = 94;
            // 
            // colsdt
            // 
            this.colsdt.Caption = "SỐ ĐIỆN THOẠI";
            this.colsdt.FieldName = "sdt";
            this.colsdt.MinWidth = 25;
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 2;
            this.colsdt.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(sdtLabel);
            this.panelControl2.Controls.Add(this.txt_SDT);
            this.panelControl2.Controls.Add(cmndLabel);
            this.panelControl2.Controls.Add(this.txt_CMND);
            this.panelControl2.Controls.Add(hoTenLabel);
            this.panelControl2.Controls.Add(this.txt_HoTen);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 392);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1446, 328);
            this.panelControl2.TabIndex = 6;
            // 
            // txt_SDT
            // 
            this.txt_SDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "sdt", true));
            this.txt_SDT.Location = new System.Drawing.Point(203, 178);
            this.txt_SDT.MenuManager = this.barManager1;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Properties.Appearance.Options.UseFont = true;
            this.txt_SDT.Size = new System.Drawing.Size(564, 32);
            this.txt_SDT.TabIndex = 12;
            // 
            // txt_CMND
            // 
            this.txt_CMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "cmnd", true));
            this.txt_CMND.Location = new System.Drawing.Point(203, 123);
            this.txt_CMND.MenuManager = this.barManager1;
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.Properties.Appearance.Options.UseFont = true;
            this.txt_CMND.Size = new System.Drawing.Size(564, 32);
            this.txt_CMND.TabIndex = 11;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "hoTen", true));
            this.txt_HoTen.Location = new System.Drawing.Point(203, 67);
            this.txt_HoTen.MenuManager = this.barManager1;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Properties.Appearance.Options.UseFont = true;
            this.txt_HoTen.Size = new System.Drawing.Size(564, 32);
            this.txt_HoTen.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 720);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcKH);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKhachHang";
            this.Text = "KHÁCH HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HoTen.Properties)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcKH;
        private System.Windows.Forms.BindingSource bdsKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKH;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colcmnd;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.TextEdit txt_CMND;
        private DevExpress.XtraEditors.TextEdit txt_HoTen;
    }
}