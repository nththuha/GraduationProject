
namespace NTH_Restaurant_Manager
{
    partial class frmPhieuDatTruoc
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
            System.Windows.Forms.Label ngayDatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuDatTruoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_CapNhatDatBan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bdsPDT = new System.Windows.Forms.BindingSource(this.components);
            this.gcPDT = new DevExpress.XtraGrid.GridControl();
            this.gvPDT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngayDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidnv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.de_NgayDat = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.de_Ngay = new DevExpress.XtraEditors.DateEdit();
            this.btn_InHopDong = new DevExpress.XtraBars.BarButtonItem();
            ngayDatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayDat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayDatLabel
            // 
            ngayDatLabel.AutoSize = true;
            ngayDatLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayDatLabel.Location = new System.Drawing.Point(16, 94);
            ngayDatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ngayDatLabel.Name = "ngayDatLabel";
            ngayDatLabel.Size = new System.Drawing.Size(99, 27);
            ngayDatLabel.TabIndex = 10;
            ngayDatLabel.Text = "Ngày đặt";
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
            this.btn_CapNhatDatBan,
            this.btn_CapNhat,
            this.btn_Luu,
            this.btn_Xoa,
            this.btn_Reload,
            this.btn_Thoat,
            this.btn_PhucHoi,
            this.barButtonItem1,
            this.btn_InHopDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(120, 174);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_CapNhatDatBan),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_CapNhat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Luu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_InHopDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_PhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Thoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_CapNhatDatBan
            // 
            this.btn_CapNhatDatBan.Caption = "Cập nhật đặt bàn";
            this.btn_CapNhatDatBan.Id = 0;
            this.btn_CapNhatDatBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_CapNhatDatBan.ImageOptions.SvgImage")));
            this.btn_CapNhatDatBan.Name = "btn_CapNhatDatBan";
            this.btn_CapNhatDatBan.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_CapNhatDatBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CapNhatDatBan_ItemClick);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Caption = "Cập nhật phiếu đặt";
            this.btn_CapNhat.Id = 1;
            this.btn_CapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_CapNhat.ImageOptions.SvgImage")));
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Hủy phiếu đặt";
            this.btn_Xoa.Id = 3;
            this.btn_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xoa.ImageOptions.SvgImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Cọc tiền";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1447, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 709);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1447, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 679);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1447, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 679);
            // 
            // bdsPDT
            // 
            this.bdsPDT.DataSource = typeof(NTH_Restaurant_Manager.Model.PhieuDatTruocModel);
            // 
            // gcPDT
            // 
            this.gcPDT.DataSource = this.bdsPDT;
            this.gcPDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPDT.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcPDT.Location = new System.Drawing.Point(0, 30);
            this.gcPDT.MainView = this.gvPDT;
            this.gcPDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcPDT.MenuManager = this.barManager1;
            this.gcPDT.Name = "gcPDT";
            this.gcPDT.Size = new System.Drawing.Size(1447, 438);
            this.gcPDT.TabIndex = 5;
            this.gcPDT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPDT});
            // 
            // gvPDT
            // 
            this.gvPDT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPDT,
            this.colngayTao,
            this.colngayDat,
            this.colidnv,
            this.colhoTenNV,
            this.colidkh,
            this.colhoTenKH,
            this.colsdt});
            this.gvPDT.DetailHeight = 437;
            this.gvPDT.GridControl = this.gcPDT;
            this.gvPDT.Name = "gvPDT";
            this.gvPDT.OptionsBehavior.Editable = false;
            this.gvPDT.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPDT_RowClick);
            // 
            // colidPDT
            // 
            this.colidPDT.FieldName = "idPDT";
            this.colidPDT.MinWidth = 31;
            this.colidPDT.Name = "colidPDT";
            this.colidPDT.Width = 117;
            // 
            // colngayTao
            // 
            this.colngayTao.Caption = "NGÀY TẠO";
            this.colngayTao.FieldName = "ngayTao";
            this.colngayTao.MinWidth = 31;
            this.colngayTao.Name = "colngayTao";
            this.colngayTao.Visible = true;
            this.colngayTao.VisibleIndex = 2;
            this.colngayTao.Width = 117;
            // 
            // colngayDat
            // 
            this.colngayDat.Caption = "NGÀY ĐẶT";
            this.colngayDat.FieldName = "ngayDat";
            this.colngayDat.MinWidth = 31;
            this.colngayDat.Name = "colngayDat";
            this.colngayDat.Visible = true;
            this.colngayDat.VisibleIndex = 3;
            this.colngayDat.Width = 117;
            // 
            // colidnv
            // 
            this.colidnv.FieldName = "idnv";
            this.colidnv.MinWidth = 31;
            this.colidnv.Name = "colidnv";
            this.colidnv.Width = 117;
            // 
            // colhoTenNV
            // 
            this.colhoTenNV.Caption = "HỌ TÊN NHÂN VIÊN LẬP PHIẾU";
            this.colhoTenNV.FieldName = "hoTenNV";
            this.colhoTenNV.MinWidth = 31;
            this.colhoTenNV.Name = "colhoTenNV";
            this.colhoTenNV.Visible = true;
            this.colhoTenNV.VisibleIndex = 4;
            this.colhoTenNV.Width = 117;
            // 
            // colidkh
            // 
            this.colidkh.FieldName = "idkh";
            this.colidkh.MinWidth = 31;
            this.colidkh.Name = "colidkh";
            this.colidkh.Width = 117;
            // 
            // colhoTenKH
            // 
            this.colhoTenKH.Caption = "HỌ TÊN KHÁCH HÀNG";
            this.colhoTenKH.FieldName = "hoTenKH";
            this.colhoTenKH.MinWidth = 31;
            this.colhoTenKH.Name = "colhoTenKH";
            this.colhoTenKH.Visible = true;
            this.colhoTenKH.VisibleIndex = 0;
            this.colhoTenKH.Width = 117;
            // 
            // colsdt
            // 
            this.colsdt.Caption = "SỐ ĐIỆN THOẠI KHÁCH HÀNG";
            this.colsdt.FieldName = "sdt";
            this.colsdt.MinWidth = 31;
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 1;
            this.colsdt.Width = 117;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.de_Ngay);
            this.panelControl2.Controls.Add(ngayDatLabel);
            this.panelControl2.Controls.Add(this.de_NgayDat);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 468);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1447, 241);
            this.panelControl2.TabIndex = 6;
            // 
            // de_NgayDat
            // 
            this.de_NgayDat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPDT, "ngayDat", true));
            this.de_NgayDat.EditValue = null;
            this.de_NgayDat.Location = new System.Drawing.Point(182, 90);
            this.de_NgayDat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.de_NgayDat.MenuManager = this.barManager1;
            this.de_NgayDat.Name = "de_NgayDat";
            this.de_NgayDat.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_NgayDat.Properties.Appearance.Options.UseFont = true;
            this.de_NgayDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayDat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayDat.Size = new System.Drawing.Size(578, 32);
            this.de_NgayDat.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUẢN LÝ PHIẾU ĐẶT TRƯỚC";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 7;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // de_Ngay
            // 
            this.de_Ngay.EditValue = null;
            this.de_Ngay.Location = new System.Drawing.Point(962, 63);
            this.de_Ngay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.de_Ngay.MenuManager = this.barManager1;
            this.de_Ngay.Name = "de_Ngay";
            this.de_Ngay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_Ngay.Properties.Appearance.Options.UseFont = true;
            this.de_Ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Ngay.Size = new System.Drawing.Size(339, 32);
            this.de_Ngay.TabIndex = 7;
            this.de_Ngay.EditValueChanged += new System.EventHandler(this.de_Ngay_EditValueChanged);
            // 
            // btn_InHopDong
            // 
            this.btn_InHopDong.Caption = "In hợp đồng";
            this.btn_InHopDong.Id = 9;
            this.btn_InHopDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.btn_InHopDong.Name = "btn_InHopDong";
            this.btn_InHopDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_InHopDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_InHopDong_ItemClick);
            // 
            // frmPhieuDatTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 709);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcPDT);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuDatTruoc";
            this.Text = "PHIẾU ĐẶT TRƯỚC";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayDat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_CapNhatDatBan;
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
        private DevExpress.XtraGrid.GridControl gcPDT;
        private System.Windows.Forms.BindingSource bdsPDT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPDT;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraEditors.DateEdit de_Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn colidPDT;
        private DevExpress.XtraGrid.Columns.GridColumn colngayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colngayDat;
        private DevExpress.XtraGrid.Columns.GridColumn colidnv;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colidkh;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.DateEdit de_NgayDat;
        private DevExpress.XtraBars.BarButtonItem btn_InHopDong;
    }
}