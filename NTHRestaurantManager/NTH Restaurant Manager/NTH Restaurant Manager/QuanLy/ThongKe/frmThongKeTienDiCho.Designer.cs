
namespace NTH_Restaurant_Manager
{
    partial class frmThongKeTienDiCho
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
            System.Windows.Forms.Label ngayKTLabel;
            System.Windows.Forms.Label ngayBDLabel;
            this.btn_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.de_NgayKT = new DevExpress.XtraEditors.DateEdit();
            this.de_NgayBD = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            ngayKTLabel = new System.Windows.Forms.Label();
            ngayBDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayBD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.Appearance.Options.UseFont = true;
            this.btn_XacNhan.Location = new System.Drawing.Point(455, 436);
            this.btn_XacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(242, 70);
            this.btn_XacNhan.TabIndex = 20;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // de_NgayKT
            // 
            this.de_NgayKT.EditValue = null;
            this.de_NgayKT.Location = new System.Drawing.Point(455, 326);
            this.de_NgayKT.Margin = new System.Windows.Forms.Padding(4);
            this.de_NgayKT.Name = "de_NgayKT";
            this.de_NgayKT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_NgayKT.Properties.Appearance.Options.UseFont = true;
            this.de_NgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayKT.Size = new System.Drawing.Size(501, 32);
            this.de_NgayKT.TabIndex = 19;
            // 
            // de_NgayBD
            // 
            this.de_NgayBD.EditValue = null;
            this.de_NgayBD.Location = new System.Drawing.Point(455, 241);
            this.de_NgayBD.Margin = new System.Windows.Forms.Padding(4);
            this.de_NgayBD.Name = "de_NgayBD";
            this.de_NgayBD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_NgayBD.Properties.Appearance.Options.UseFont = true;
            this.de_NgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayBD.Size = new System.Drawing.Size(501, 32);
            this.de_NgayBD.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "THỐNG KÊ TIỀN ĐI CHỢ";
            // 
            // ngayKTLabel
            // 
            ngayKTLabel.AutoSize = true;
            ngayKTLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayKTLabel.Location = new System.Drawing.Point(223, 329);
            ngayKTLabel.Name = "ngayKTLabel";
            ngayKTLabel.Size = new System.Drawing.Size(147, 27);
            ngayKTLabel.TabIndex = 16;
            ngayKTLabel.Text = "Ngày kết thúc";
            // 
            // ngayBDLabel
            // 
            ngayBDLabel.AutoSize = true;
            ngayBDLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayBDLabel.Location = new System.Drawing.Point(223, 244);
            ngayBDLabel.Name = "ngayBDLabel";
            ngayBDLabel.Size = new System.Drawing.Size(140, 27);
            ngayBDLabel.TabIndex = 15;
            ngayBDLabel.Text = "Ngày bắt đầu";
            // 
            // frmThongKeTienDiCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 695);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.de_NgayKT);
            this.Controls.Add(this.de_NgayBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(ngayKTLabel);
            this.Controls.Add(ngayBDLabel);
            this.Name = "frmThongKeTienDiCho";
            this.Text = "THỐNG KÊ TIỀN ĐI CHỢ";
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayBD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_XacNhan;
        private DevExpress.XtraEditors.DateEdit de_NgayKT;
        private DevExpress.XtraEditors.DateEdit de_NgayBD;
        private System.Windows.Forms.Label label1;
    }
}