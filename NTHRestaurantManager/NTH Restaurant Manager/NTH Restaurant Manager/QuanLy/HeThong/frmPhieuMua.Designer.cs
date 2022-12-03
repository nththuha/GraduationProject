
namespace NTH_Restaurant_Manager
{
    partial class frmPhieuMua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuMua));
            this.de_Ngay = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Chuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcPM = new DevExpress.XtraGrid.GridControl();
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.gvPM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidnv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTPM = new System.Windows.Forms.BindingSource(this.components);
            this.gcCTPM = new DevExpress.XtraGrid.GridControl();
            this.gvCTPM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCTPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidpm1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ngayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPM)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayLabel
            // 
            ngayLabel.AutoSize = true;
            ngayLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayLabel.Location = new System.Drawing.Point(18, 491);
            ngayLabel.Name = "ngayLabel";
            ngayLabel.Size = new System.Drawing.Size(63, 27);
            ngayLabel.TabIndex = 1;
            ngayLabel.Text = "Ngày";
            // 
            // de_Ngay
            // 
            this.de_Ngay.EditValue = null;
            this.de_Ngay.Location = new System.Drawing.Point(103, 488);
            this.de_Ngay.Margin = new System.Windows.Forms.Padding(4);
            this.de_Ngay.Name = "de_Ngay";
            this.de_Ngay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_Ngay.Properties.Appearance.Options.UseFont = true;
            this.de_Ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Ngay.Size = new System.Drawing.Size(409, 32);
            this.de_Ngay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "PHIẾU MUA NGUYÊN LIỆU";
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
            this.btn_Chuyen,
            this.btn_Reload,
            this.btn_Thoat});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Chuyen),
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
            // btn_Chuyen
            // 
            this.btn_Chuyen.Caption = "Chuyển thành phiếu nhập nguyên liệu";
            this.btn_Chuyen.Id = 1;
            this.btn_Chuyen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Chuyen.ImageOptions.SvgImage")));
            this.btn_Chuyen.Name = "btn_Chuyen";
            this.btn_Chuyen.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Chuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Chuyen_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1432, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 719);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1432, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 689);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1432, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 689);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcPM);
            this.panelControl1.Controls.Add(this.de_Ngay);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(ngayLabel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 689);
            this.panelControl1.TabIndex = 16;
            // 
            // gcPM
            // 
            this.gcPM.DataSource = this.bdsPM;
            this.gcPM.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPM.Location = new System.Drawing.Point(2, 2);
            this.gcPM.MainView = this.gvPM;
            this.gcPM.MenuManager = this.barManager1;
            this.gcPM.Name = "gcPM";
            this.gcPM.Size = new System.Drawing.Size(796, 400);
            this.gcPM.TabIndex = 0;
            this.gcPM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPM});
            // 
            // bdsPM
            // 
            this.bdsPM.DataSource = typeof(NTH_Restaurant_Manager.Model.PhieuMuaNguyenLieuModel);
            // 
            // gvPM
            // 
            this.gvPM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPM,
            this.colngay,
            this.colidnv,
            this.colhoTenNV});
            this.gvPM.GridControl = this.gcPM;
            this.gvPM.Name = "gvPM";
            this.gvPM.OptionsBehavior.Editable = false;
            this.gvPM.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPM_RowClick);
            // 
            // colidPM
            // 
            this.colidPM.FieldName = "idPM";
            this.colidPM.MinWidth = 25;
            this.colidPM.Name = "colidPM";
            this.colidPM.Width = 94;
            // 
            // colngay
            // 
            this.colngay.Caption = "NGÀY";
            this.colngay.FieldName = "ngay";
            this.colngay.MinWidth = 25;
            this.colngay.Name = "colngay";
            this.colngay.Visible = true;
            this.colngay.VisibleIndex = 0;
            this.colngay.Width = 94;
            // 
            // colidnv
            // 
            this.colidnv.FieldName = "idnv";
            this.colidnv.MinWidth = 25;
            this.colidnv.Name = "colidnv";
            this.colidnv.Width = 94;
            // 
            // colhoTenNV
            // 
            this.colhoTenNV.Caption = "NHÂN VIÊN LẬP";
            this.colhoTenNV.FieldName = "hoTenNV";
            this.colhoTenNV.MinWidth = 25;
            this.colhoTenNV.Name = "colhoTenNV";
            this.colhoTenNV.Visible = true;
            this.colhoTenNV.VisibleIndex = 1;
            this.colhoTenNV.Width = 94;
            // 
            // bdsCTPM
            // 
            this.bdsCTPM.DataSource = typeof(NTH_Restaurant_Manager.Model.CTPhieuMuaModel);
            // 
            // gcCTPM
            // 
            this.gcCTPM.DataSource = this.bdsCTPM;
            this.gcCTPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPM.Location = new System.Drawing.Point(800, 30);
            this.gcCTPM.MainView = this.gvCTPM;
            this.gcCTPM.MenuManager = this.barManager1;
            this.gcCTPM.Name = "gcCTPM";
            this.gcCTPM.Size = new System.Drawing.Size(632, 689);
            this.gcCTPM.TabIndex = 16;
            this.gcCTPM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPM});
            // 
            // gvCTPM
            // 
            this.gvCTPM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCTPM,
            this.colsoLuong,
            this.colmanl,
            this.coltennl,
            this.coldonVi,
            this.colidpm1});
            this.gvCTPM.GridControl = this.gcCTPM;
            this.gvCTPM.Name = "gvCTPM";
            this.gvCTPM.OptionsBehavior.Editable = false;
            // 
            // colidCTPM
            // 
            this.colidCTPM.FieldName = "idCTPM";
            this.colidCTPM.MinWidth = 25;
            this.colidCTPM.Name = "colidCTPM";
            this.colidCTPM.Width = 94;
            // 
            // colsoLuong
            // 
            this.colsoLuong.Caption = "SỐ LƯỢNG";
            this.colsoLuong.DisplayFormat.FormatString = "n0";
            this.colsoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsoLuong.FieldName = "soLuong";
            this.colsoLuong.MinWidth = 25;
            this.colsoLuong.Name = "colsoLuong";
            this.colsoLuong.Visible = true;
            this.colsoLuong.VisibleIndex = 1;
            this.colsoLuong.Width = 94;
            // 
            // colmanl
            // 
            this.colmanl.FieldName = "manl";
            this.colmanl.MinWidth = 25;
            this.colmanl.Name = "colmanl";
            this.colmanl.Width = 94;
            // 
            // coltennl
            // 
            this.coltennl.Caption = "NGUYÊN LIỆU";
            this.coltennl.FieldName = "tennl";
            this.coltennl.MinWidth = 25;
            this.coltennl.Name = "coltennl";
            this.coltennl.Visible = true;
            this.coltennl.VisibleIndex = 0;
            this.coltennl.Width = 94;
            // 
            // coldonVi
            // 
            this.coldonVi.Caption = "ĐƠN VỊ";
            this.coldonVi.FieldName = "donVi";
            this.coldonVi.MinWidth = 25;
            this.coldonVi.Name = "coldonVi";
            this.coldonVi.Visible = true;
            this.coldonVi.VisibleIndex = 2;
            this.coldonVi.Width = 94;
            // 
            // colidpm1
            // 
            this.colidpm1.FieldName = "idpm";
            this.colidpm1.MinWidth = 25;
            this.colidpm1.Name = "colidpm1";
            this.colidpm1.Width = 94;
            // 
            // frmPhieuMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 719);
            this.Controls.Add(this.gcCTPM);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuMua";
            this.Text = "PHIẾU MUA NGUYÊN LIỆU";
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit de_Ngay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_Chuyen;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcPM;
        private System.Windows.Forms.BindingSource bdsPM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPM;
        private DevExpress.XtraGrid.GridControl gcCTPM;
        private System.Windows.Forms.BindingSource bdsCTPM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPM;
        private DevExpress.XtraGrid.Columns.GridColumn colidPM;
        private DevExpress.XtraGrid.Columns.GridColumn colngay;
        private DevExpress.XtraGrid.Columns.GridColumn colidnv;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colidCTPM;
        private DevExpress.XtraGrid.Columns.GridColumn colsoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colmanl;
        private DevExpress.XtraGrid.Columns.GridColumn coltennl;
        private DevExpress.XtraGrid.Columns.GridColumn coldonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colidpm1;
    }
}