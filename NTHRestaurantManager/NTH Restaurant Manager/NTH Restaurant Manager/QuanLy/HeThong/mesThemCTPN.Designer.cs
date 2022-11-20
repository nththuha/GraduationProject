
namespace NTH_Restaurant_Manager
{
    partial class mesThemCTPN
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label tennlLabel;
            this.txt_DonVi = new DevExpress.XtraEditors.TextEdit();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.se_Gia = new DevExpress.XtraEditors.SpinEdit();
            this.se_SoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txt_TenNL = new DevExpress.XtraEditors.TextEdit();
            this.bdsNL = new System.Windows.Forms.BindingSource(this.components);
            this.gcNL = new DevExpress.XtraGrid.GridControl();
            this.gvNL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colslTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colslToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            label2 = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            tennlLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_SoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNL)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(37, 504);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 27);
            label2.TabIndex = 19;
            label2.Text = "Đơn vị";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaLabel.Location = new System.Drawing.Point(37, 608);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(46, 27);
            giaLabel.TabIndex = 15;
            giaLabel.Text = "Giá";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongLabel.Location = new System.Drawing.Point(37, 557);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(97, 27);
            soLuongLabel.TabIndex = 13;
            soLuongLabel.Text = "Số lượng";
            // 
            // tennlLabel
            // 
            tennlLabel.AutoSize = true;
            tennlLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tennlLabel.Location = new System.Drawing.Point(37, 450);
            tennlLabel.Name = "tennlLabel";
            tennlLabel.Size = new System.Drawing.Size(166, 27);
            tennlLabel.TabIndex = 11;
            tennlLabel.Text = "Tên nguyên liệu";
            // 
            // txt_DonVi
            // 
            this.txt_DonVi.Enabled = false;
            this.txt_DonVi.Location = new System.Drawing.Point(232, 501);
            this.txt_DonVi.Name = "txt_DonVi";
            this.txt_DonVi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonVi.Properties.Appearance.Options.UseFont = true;
            this.txt_DonVi.Size = new System.Drawing.Size(389, 32);
            this.txt_DonVi.TabIndex = 20;
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Location = new System.Drawing.Point(261, 662);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(123, 43);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.Text = "Xác nhận";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "THÊM CHI TIẾT PHIẾU NHẬP";
            // 
            // se_Gia
            // 
            this.se_Gia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_Gia.Location = new System.Drawing.Point(232, 605);
            this.se_Gia.Name = "se_Gia";
            this.se_Gia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_Gia.Properties.Appearance.Options.UseFont = true;
            this.se_Gia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_Gia.Size = new System.Drawing.Size(389, 32);
            this.se_Gia.TabIndex = 16;
            // 
            // se_SoLuong
            // 
            this.se_SoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_SoLuong.Location = new System.Drawing.Point(232, 554);
            this.se_SoLuong.Name = "se_SoLuong";
            this.se_SoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_SoLuong.Properties.Appearance.Options.UseFont = true;
            this.se_SoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_SoLuong.Size = new System.Drawing.Size(389, 32);
            this.se_SoLuong.TabIndex = 14;
            // 
            // txt_TenNL
            // 
            this.txt_TenNL.Enabled = false;
            this.txt_TenNL.Location = new System.Drawing.Point(232, 447);
            this.txt_TenNL.Name = "txt_TenNL";
            this.txt_TenNL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNL.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNL.Size = new System.Drawing.Size(389, 32);
            this.txt_TenNL.TabIndex = 12;
            // 
            // bdsNL
            // 
            this.bdsNL.DataSource = typeof(NTH_Restaurant_Manager.Model.NguyenLieuModel);
            // 
            // gcNL
            // 
            this.gcNL.DataSource = this.bdsNL;
            this.gcNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNL.Location = new System.Drawing.Point(0, 0);
            this.gcNL.MainView = this.gvNL;
            this.gcNL.Name = "gcNL";
            this.gcNL.Size = new System.Drawing.Size(753, 373);
            this.gcNL.TabIndex = 21;
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
            // mesThemCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 742);
            this.Controls.Add(this.gcNL);
            this.Controls.Add(label2);
            this.Controls.Add(this.txt_DonVi);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label1);
            this.Controls.Add(giaLabel);
            this.Controls.Add(this.se_Gia);
            this.Controls.Add(soLuongLabel);
            this.Controls.Add(this.se_SoLuong);
            this.Controls.Add(tennlLabel);
            this.Controls.Add(this.txt_TenNL);
            this.Name = "mesThemCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM CHI TIẾT PHIẾU NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mesThemCTPN_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_SoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_DonVi;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit se_Gia;
        private DevExpress.XtraEditors.SpinEdit se_SoLuong;
        private DevExpress.XtraEditors.TextEdit txt_TenNL;
        private System.Windows.Forms.BindingSource bdsNL;
        private DevExpress.XtraGrid.GridControl gcNL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNL;
        private DevExpress.XtraGrid.Columns.GridColumn colmaNL;
        private DevExpress.XtraGrid.Columns.GridColumn coltenNL;
        private DevExpress.XtraGrid.Columns.GridColumn coldonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colslTon;
        private DevExpress.XtraGrid.Columns.GridColumn colslToiThieu;
    }
}