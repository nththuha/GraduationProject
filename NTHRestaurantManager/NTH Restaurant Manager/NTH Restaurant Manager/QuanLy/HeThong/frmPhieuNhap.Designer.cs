
namespace NTH_Restaurant_Manager
{
    partial class frmPhieuNhap
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
            System.Windows.Forms.Label ngayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.bdsNL = new System.Windows.Forms.BindingSource(this.components);
            this.gcNL = new DevExpress.XtraGrid.GridControl();
            this.gvNL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colslTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colslToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.de_Ngay = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gcCTPN = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCTPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanl1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennl1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidpn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btn_ThemPhieuMua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Load = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThemChiTietPhieuMua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XoaChiTietPhieuMua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ngayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayLabel
            // 
            ngayLabel.AutoSize = true;
            ngayLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayLabel.Location = new System.Drawing.Point(20, 78);
            ngayLabel.Name = "ngayLabel";
            ngayLabel.Size = new System.Drawing.Size(63, 27);
            ngayLabel.TabIndex = 13;
            ngayLabel.Text = "Ngày";
            // 
            // bdsNL
            // 
            this.bdsNL.DataSource = typeof(NTH_Restaurant_Manager.Model.NguyenLieuModel);
            // 
            // gcNL
            // 
            this.gcNL.DataSource = this.bdsNL;
            this.gcNL.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcNL.Location = new System.Drawing.Point(0, 30);
            this.gcNL.MainView = this.gvNL;
            this.gcNL.Name = "gcNL";
            this.gcNL.Size = new System.Drawing.Size(781, 682);
            this.gcNL.TabIndex = 5;
            this.gcNL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNL});
            // 
            // gvNL
            // 
            this.gvNL.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaNL,
            this.coltenNL,
            this.coldonVi,
            this.colslTon,
            this.colslToiThieu});
            this.gvNL.GridControl = this.gcNL;
            this.gvNL.Name = "gvNL";
            this.gvNL.OptionsBehavior.Editable = false;
            this.gvNL.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvNL_RowClick);
            // 
            // colmaNL
            // 
            this.colmaNL.FieldName = "maNL";
            this.colmaNL.MinWidth = 25;
            this.colmaNL.Name = "colmaNL";
            this.colmaNL.Width = 94;
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
            this.colslTon.FieldName = "slTon";
            this.colslTon.MinWidth = 25;
            this.colslTon.Name = "colslTon";
            this.colslTon.Width = 94;
            // 
            // colslToiThieu
            // 
            this.colslToiThieu.FieldName = "slToiThieu";
            this.colslToiThieu.MinWidth = 25;
            this.colslToiThieu.Name = "colslToiThieu";
            this.colslToiThieu.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.gcCTPN);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(781, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(849, 682);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(ngayLabel);
            this.panelControl2.Controls.Add(this.de_Ngay);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 346);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(845, 334);
            this.panelControl2.TabIndex = 1;
            // 
            // de_Ngay
            // 
            this.de_Ngay.EditValue = null;
            this.de_Ngay.Location = new System.Drawing.Point(108, 75);
            this.de_Ngay.Name = "de_Ngay";
            this.de_Ngay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_Ngay.Properties.Appearance.Options.UseFont = true;
            this.de_Ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Ngay.Size = new System.Drawing.Size(480, 32);
            this.de_Ngay.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "QUẢN LÝ PHIẾU NHẬP NGUYÊN LIỆU";
            // 
            // gcCTPN
            // 
            this.gcCTPN.DataSource = this.bdsCTPN;
            this.gcCTPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTPN.Location = new System.Drawing.Point(2, 2);
            this.gcCTPN.MainView = this.gvCTPN;
            this.gcCTPN.Name = "gcCTPN";
            this.gcCTPN.Size = new System.Drawing.Size(845, 344);
            this.gcCTPN.TabIndex = 0;
            this.gcCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPN});
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataSource = typeof(NTH_Restaurant_Manager.Model.CTPhieuNhapModel);
            // 
            // gvCTPN
            // 
            this.gvCTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCTPN,
            this.colsoLuong,
            this.colgia,
            this.colmanl1,
            this.coltennl1,
            this.colidpn});
            this.gvCTPN.GridControl = this.gcCTPN;
            this.gvCTPN.Name = "gvCTPN";
            this.gvCTPN.OptionsBehavior.Editable = false;
            this.gvCTPN.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCTPN_RowClick);
            // 
            // colidCTPN
            // 
            this.colidCTPN.FieldName = "idCTPN";
            this.colidCTPN.MinWidth = 25;
            this.colidCTPN.Name = "colidCTPN";
            this.colidCTPN.Width = 94;
            // 
            // colsoLuong
            // 
            this.colsoLuong.Caption = "SỐ LƯỢNG";
            this.colsoLuong.FieldName = "soLuong";
            this.colsoLuong.MinWidth = 25;
            this.colsoLuong.Name = "colsoLuong";
            this.colsoLuong.Visible = true;
            this.colsoLuong.VisibleIndex = 0;
            this.colsoLuong.Width = 94;
            // 
            // colgia
            // 
            this.colgia.Caption = "GIÁ";
            this.colgia.FieldName = "gia";
            this.colgia.MinWidth = 25;
            this.colgia.Name = "colgia";
            this.colgia.Visible = true;
            this.colgia.VisibleIndex = 1;
            this.colgia.Width = 94;
            // 
            // colmanl1
            // 
            this.colmanl1.FieldName = "manl";
            this.colmanl1.MinWidth = 25;
            this.colmanl1.Name = "colmanl1";
            this.colmanl1.Width = 94;
            // 
            // coltennl1
            // 
            this.coltennl1.Caption = "TÊN NGUYÊN LIỆU";
            this.coltennl1.FieldName = "tennl";
            this.coltennl1.MinWidth = 25;
            this.coltennl1.Name = "coltennl1";
            this.coltennl1.Visible = true;
            this.coltennl1.VisibleIndex = 2;
            this.coltennl1.Width = 94;
            // 
            // colidpn
            // 
            this.colidpn.FieldName = "idpn";
            this.colidpn.MinWidth = 25;
            this.colidpn.Name = "colidpn";
            this.colidpn.Width = 94;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(189, 199);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(189, 199);
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_ThemPhieuMua,
            this.btn_Load,
            this.btn_ThemChiTietPhieuMua,
            this.btn_XoaChiTietPhieuMua,
            this.btn_Thoat});
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(29, 139);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ThemPhieuMua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Load),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ThemChiTietPhieuMua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_XoaChiTietPhieuMua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Thoat)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btn_ThemPhieuMua
            // 
            this.btn_ThemPhieuMua.Caption = "Thêm phiếu mua";
            this.btn_ThemPhieuMua.Id = 0;
            this.btn_ThemPhieuMua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ThemPhieuMua.ImageOptions.SvgImage")));
            this.btn_ThemPhieuMua.Name = "btn_ThemPhieuMua";
            this.btn_ThemPhieuMua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_ThemPhieuMua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThemPhieuMua_ItemClick);
            // 
            // btn_Load
            // 
            this.btn_Load.Caption = "Reload";
            this.btn_Load.Enabled = false;
            this.btn_Load.Id = 7;
            this.btn_Load.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Load.ImageOptions.SvgImage")));
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Load.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Load_ItemClick);
            // 
            // btn_ThemChiTietPhieuMua
            // 
            this.btn_ThemChiTietPhieuMua.Caption = "Thêm chi tiết phiếu mua";
            this.btn_ThemChiTietPhieuMua.Enabled = false;
            this.btn_ThemChiTietPhieuMua.Id = 1;
            this.btn_ThemChiTietPhieuMua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ThemChiTietPhieuMua.ImageOptions.SvgImage")));
            this.btn_ThemChiTietPhieuMua.Name = "btn_ThemChiTietPhieuMua";
            this.btn_ThemChiTietPhieuMua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_ThemChiTietPhieuMua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThemChiTietPhieuMua_ItemClick);
            // 
            // btn_XoaChiTietPhieuMua
            // 
            this.btn_XoaChiTietPhieuMua.Caption = "Xóa chi tiết phiếu mua";
            this.btn_XoaChiTietPhieuMua.Enabled = false;
            this.btn_XoaChiTietPhieuMua.Id = 3;
            this.btn_XoaChiTietPhieuMua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_XoaChiTietPhieuMua.ImageOptions.SvgImage")));
            this.btn_XoaChiTietPhieuMua.Name = "btn_XoaChiTietPhieuMua";
            this.btn_XoaChiTietPhieuMua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_XoaChiTietPhieuMua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_XoaChiTietPhieuMua_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1630, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 712);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1630, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 682);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1630, 30);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 682);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1630, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 682);
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 712);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcNL);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuNhap";
            this.Text = "PHIẾU NHẬP NGUYÊN LIỆU";
            ((System.ComponentModel.ISupportInitialize)(this.bdsNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcNL;
        private System.Windows.Forms.BindingSource bdsNL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNL;
        private DevExpress.XtraGrid.GridControl gcCTPN;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPN;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit de_Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn colmaNL;
        private DevExpress.XtraGrid.Columns.GridColumn coltenNL;
        private DevExpress.XtraGrid.Columns.GridColumn coldonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colslTon;
        private DevExpress.XtraGrid.Columns.GridColumn colslToiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn colidCTPN;
        private DevExpress.XtraGrid.Columns.GridColumn colsoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colgia;
        private DevExpress.XtraGrid.Columns.GridColumn colmanl1;
        private DevExpress.XtraGrid.Columns.GridColumn coltennl1;
        private DevExpress.XtraGrid.Columns.GridColumn colidpn;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btn_ThemPhieuMua;
        private DevExpress.XtraBars.BarButtonItem btn_Load;
        private DevExpress.XtraBars.BarButtonItem btn_ThemChiTietPhieuMua;
        private DevExpress.XtraBars.BarButtonItem btn_XoaChiTietPhieuMua;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}