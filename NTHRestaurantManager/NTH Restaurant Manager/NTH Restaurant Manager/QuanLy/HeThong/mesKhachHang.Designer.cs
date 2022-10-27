
namespace NTH_Restaurant_Manager
{
    partial class mesKhachHang
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
            this.gcKH = new DevExpress.XtraGrid.GridControl();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.gvKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // gcKH
            // 
            this.gcKH.DataSource = this.bdsKH;
            this.gcKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKH.Location = new System.Drawing.Point(0, 0);
            this.gcKH.MainView = this.gvKH;
            this.gcKH.Name = "gcKH";
            this.gcKH.Size = new System.Drawing.Size(1198, 429);
            this.gcKH.TabIndex = 1;
            this.gcKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKH});
            // 
            // bdsKH
            // 
            this.bdsKH.DataSource = typeof(NTH_Restaurant_Manager.Model.KhachHangModel);
            // 
            // gvKH
            // 
            this.gvKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidKH,
            this.colhoTen,
            this.colcmnd,
            this.colsdt});
            this.gvKH.GridControl = this.gcKH;
            this.gvKH.Name = "gvKH";
            this.gvKH.OptionsBehavior.Editable = false;
            this.gvKH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvKH_RowClick);
            // 
            // colidKH
            // 
            this.colidKH.FieldName = "idKH";
            this.colidKH.MinWidth = 25;
            this.colidKH.Name = "colidKH";
            this.colidKH.Width = 94;
            // 
            // colhoTen
            // 
            this.colhoTen.Caption = "HỌ TÊN KHÁCH HẦNG";
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
            // btn_XacNhan
            // 
            this.btn_XacNhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.Appearance.Options.UseFont = true;
            this.btn_XacNhan.Location = new System.Drawing.Point(489, 469);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(164, 41);
            this.btn_XacNhan.TabIndex = 2;
            this.btn_XacNhan.Text = "XÁC NHẬN";
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // mesKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 546);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.gcKH);
            this.Name = "mesKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN KHÁCH HÀNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mesKhachHang_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsKH;
        private DevExpress.XtraGrid.GridControl gcKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKH;
        private DevExpress.XtraEditors.SimpleButton btn_XacNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colidKH;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colcmnd;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
    }
}