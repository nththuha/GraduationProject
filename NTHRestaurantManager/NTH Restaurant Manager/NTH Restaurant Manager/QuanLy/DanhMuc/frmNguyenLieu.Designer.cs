
namespace NTH_Restaurant_Manager
{
    partial class frmNguyenLieu
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
            System.Windows.Forms.Label slTonLabel;
            System.Windows.Forms.Label donViLabel;
            System.Windows.Forms.Label tenNLLabel;
            System.Windows.Forms.Label maNLLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguyenLieu));
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
            this.bdsNL = new System.Windows.Forms.BindingSource(this.components);
            this.gcNL = new DevExpress.XtraGrid.GridControl();
            this.gvNL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colslTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colslToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.se_SLToiThieu = new DevExpress.XtraEditors.SpinEdit();
            this.se_SLTon = new DevExpress.XtraEditors.SpinEdit();
            this.txt_DonVi = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenNL = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaNL = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            slTonLabel = new System.Windows.Forms.Label();
            donViLabel = new System.Windows.Forms.Label();
            tenNLLabel = new System.Windows.Forms.Label();
            maNLLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.se_SLToiThieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_SLTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slTonLabel
            // 
            slTonLabel.AutoSize = true;
            slTonLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            slTonLabel.Location = new System.Drawing.Point(17, 603);
            slTonLabel.Name = "slTonLabel";
            slTonLabel.Size = new System.Drawing.Size(134, 27);
            slTonLabel.TabIndex = 22;
            slTonLabel.Text = "Số lượng tồn";
            // 
            // donViLabel
            // 
            donViLabel.AutoSize = true;
            donViLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            donViLabel.Location = new System.Drawing.Point(17, 553);
            donViLabel.Name = "donViLabel";
            donViLabel.Size = new System.Drawing.Size(78, 27);
            donViLabel.TabIndex = 20;
            donViLabel.Text = "Đơn vị";
            // 
            // tenNLLabel
            // 
            tenNLLabel.AutoSize = true;
            tenNLLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenNLLabel.Location = new System.Drawing.Point(17, 501);
            tenNLLabel.Name = "tenNLLabel";
            tenNLLabel.Size = new System.Drawing.Size(166, 27);
            tenNLLabel.TabIndex = 18;
            tenNLLabel.Text = "Tên nguyên liệu";
            // 
            // maNLLabel
            // 
            maNLLabel.AutoSize = true;
            maNLLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maNLLabel.Location = new System.Drawing.Point(17, 446);
            maNLLabel.Name = "maNLLabel";
            maNLLabel.Size = new System.Drawing.Size(161, 27);
            maNLLabel.TabIndex = 16;
            maNLLabel.Text = "Mã nguyên liệu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(17, 654);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(182, 27);
            label2.TabIndex = 25;
            label2.Text = "Số lượng tối thiểu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1406, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 733);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1406, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 703);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1406, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 703);
            // 
            // bdsNL
            // 
            this.bdsNL.DataSource = typeof(NTH_Restaurant_Manager.Model.NguyenLieuModel);
            // 
            // gcNL
            // 
            this.gcNL.DataSource = this.bdsNL;
            this.gcNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNL.Location = new System.Drawing.Point(2, 2);
            this.gcNL.MainView = this.gvNL;
            this.gcNL.MenuManager = this.barManager1;
            this.gcNL.Name = "gcNL";
            this.gcNL.Size = new System.Drawing.Size(1402, 370);
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
            this.colslToiThieu,
            this.gridColumn1});
            this.gvNL.GridControl = this.gcNL;
            this.gvNL.Name = "gvNL";
            this.gvNL.OptionsBehavior.Editable = false;
            this.gvNL.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvNL_RowClick);
            // 
            // colmaNL
            // 
            this.colmaNL.Caption = "MÃ NGUYÊN LIỆU";
            this.colmaNL.FieldName = "maNL";
            this.colmaNL.MinWidth = 25;
            this.colmaNL.Name = "colmaNL";
            this.colmaNL.Visible = true;
            this.colmaNL.VisibleIndex = 0;
            this.colmaNL.Width = 94;
            // 
            // coltenNL
            // 
            this.coltenNL.Caption = "TÊN NGUYÊN LIỆU";
            this.coltenNL.FieldName = "tenNL";
            this.coltenNL.MinWidth = 25;
            this.coltenNL.Name = "coltenNL";
            this.coltenNL.Visible = true;
            this.coltenNL.VisibleIndex = 1;
            this.coltenNL.Width = 94;
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
            // colslTon
            // 
            this.colslTon.Caption = "SỐ LƯỢNG TỒN";
            this.colslTon.DisplayFormat.FormatString = "{0:0,0}";
            this.colslTon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colslTon.FieldName = "slTon";
            this.colslTon.MinWidth = 25;
            this.colslTon.Name = "colslTon";
            this.colslTon.Visible = true;
            this.colslTon.VisibleIndex = 3;
            this.colslTon.Width = 94;
            // 
            // colslToiThieu
            // 
            this.colslToiThieu.Caption = "SỐ LƯỢNG TỐI THIỂU";
            this.colslToiThieu.DisplayFormat.FormatString = "{0:0,0}";
            this.colslToiThieu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colslToiThieu.FieldName = "slToiThieu";
            this.colslToiThieu.MinWidth = 25;
            this.colslToiThieu.Name = "colslToiThieu";
            this.colslToiThieu.Visible = true;
            this.colslToiThieu.VisibleIndex = 4;
            this.colslToiThieu.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "CHÊNH LỆCH";
            this.gridColumn1.DisplayFormat.FormatString = "{0:0,0}";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundExpression = "[slTon] - [slToiThieu]";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(label2);
            this.panelControl2.Controls.Add(this.se_SLToiThieu);
            this.panelControl2.Controls.Add(slTonLabel);
            this.panelControl2.Controls.Add(this.se_SLTon);
            this.panelControl2.Controls.Add(donViLabel);
            this.panelControl2.Controls.Add(this.txt_DonVi);
            this.panelControl2.Controls.Add(tenNLLabel);
            this.panelControl2.Controls.Add(this.txt_TenNL);
            this.panelControl2.Controls.Add(maNLLabel);
            this.panelControl2.Controls.Add(this.txt_MaNL);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 30);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1406, 703);
            this.panelControl2.TabIndex = 6;
            // 
            // se_SLToiThieu
            // 
            this.se_SLToiThieu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNL, "slTon", true));
            this.se_SLToiThieu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_SLToiThieu.Location = new System.Drawing.Point(251, 651);
            this.se_SLToiThieu.MenuManager = this.barManager1;
            this.se_SLToiThieu.Name = "se_SLToiThieu";
            this.se_SLToiThieu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_SLToiThieu.Properties.Appearance.Options.UseFont = true;
            this.se_SLToiThieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_SLToiThieu.Size = new System.Drawing.Size(561, 32);
            this.se_SLToiThieu.TabIndex = 26;
            // 
            // se_SLTon
            // 
            this.se_SLTon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNL, "slTon", true));
            this.se_SLTon.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_SLTon.Location = new System.Drawing.Point(251, 600);
            this.se_SLTon.MenuManager = this.barManager1;
            this.se_SLTon.Name = "se_SLTon";
            this.se_SLTon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_SLTon.Properties.Appearance.Options.UseFont = true;
            this.se_SLTon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_SLTon.Size = new System.Drawing.Size(561, 32);
            this.se_SLTon.TabIndex = 24;
            // 
            // txt_DonVi
            // 
            this.txt_DonVi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNL, "donVi", true));
            this.txt_DonVi.Location = new System.Drawing.Point(251, 550);
            this.txt_DonVi.MenuManager = this.barManager1;
            this.txt_DonVi.Name = "txt_DonVi";
            this.txt_DonVi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonVi.Properties.Appearance.Options.UseFont = true;
            this.txt_DonVi.Size = new System.Drawing.Size(561, 32);
            this.txt_DonVi.TabIndex = 23;
            // 
            // txt_TenNL
            // 
            this.txt_TenNL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNL, "tenNL", true));
            this.txt_TenNL.Location = new System.Drawing.Point(251, 498);
            this.txt_TenNL.MenuManager = this.barManager1;
            this.txt_TenNL.Name = "txt_TenNL";
            this.txt_TenNL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNL.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNL.Size = new System.Drawing.Size(561, 32);
            this.txt_TenNL.TabIndex = 21;
            // 
            // txt_MaNL
            // 
            this.txt_MaNL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNL, "maNL", true));
            this.txt_MaNL.Location = new System.Drawing.Point(251, 443);
            this.txt_MaNL.MenuManager = this.barManager1;
            this.txt_MaNL.Name = "txt_MaNL";
            this.txt_MaNL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNL.Properties.Appearance.Options.UseFont = true;
            this.txt_MaNL.Size = new System.Drawing.Size(561, 32);
            this.txt_MaNL.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "QUẢN LÝ NGUYÊN LIỆU";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcNL);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1406, 374);
            this.panelControl1.TabIndex = 11;
            // 
            // frmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 733);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNguyenLieu";
            this.Text = "NGUYÊN LIỆU";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.se_SLToiThieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_SLTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNL.Properties)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcNL;
        private System.Windows.Forms.BindingSource bdsNL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNL;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit se_SLTon;
        private DevExpress.XtraEditors.TextEdit txt_DonVi;
        private DevExpress.XtraEditors.TextEdit txt_TenNL;
        private DevExpress.XtraEditors.TextEdit txt_MaNL;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colmaNL;
        private DevExpress.XtraGrid.Columns.GridColumn coltenNL;
        private DevExpress.XtraGrid.Columns.GridColumn coldonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colslTon;
        private DevExpress.XtraGrid.Columns.GridColumn colslToiThieu;
        private DevExpress.XtraEditors.SpinEdit se_SLToiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}