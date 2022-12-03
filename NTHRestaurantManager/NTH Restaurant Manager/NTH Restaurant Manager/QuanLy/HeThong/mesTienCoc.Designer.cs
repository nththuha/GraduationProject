
namespace NTH_Restaurant_Manager
{
    partial class mesTienCoc
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
            System.Windows.Forms.Label hoTenKHLabel;
            System.Windows.Forms.Label sdtLabel;
            System.Windows.Forms.Label triGiaLabel;
            this.txt_HoTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.se_SoTien = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            hoTenKHLabel = new System.Windows.Forms.Label();
            sdtLabel = new System.Windows.Forms.Label();
            triGiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HoTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_SoTien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenKHLabel
            // 
            hoTenKHLabel.AutoSize = true;
            hoTenKHLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoTenKHLabel.Location = new System.Drawing.Point(114, 143);
            hoTenKHLabel.Name = "hoTenKHLabel";
            hoTenKHLabel.Size = new System.Drawing.Size(193, 27);
            hoTenKHLabel.TabIndex = 1;
            hoTenKHLabel.Text = "Họ tên khách hàng";
            // 
            // sdtLabel
            // 
            sdtLabel.AutoSize = true;
            sdtLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sdtLabel.Location = new System.Drawing.Point(114, 209);
            sdtLabel.Name = "sdtLabel";
            sdtLabel.Size = new System.Drawing.Size(137, 27);
            sdtLabel.TabIndex = 3;
            sdtLabel.Text = "Số điện thoại";
            // 
            // triGiaLabel
            // 
            triGiaLabel.AutoSize = true;
            triGiaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            triGiaLabel.Location = new System.Drawing.Point(114, 278);
            triGiaLabel.Name = "triGiaLabel";
            triGiaLabel.Size = new System.Drawing.Size(78, 27);
            triGiaLabel.TabIndex = 5;
            triGiaLabel.Text = "Số tiền";
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.Location = new System.Drawing.Point(343, 140);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenKH.Properties.Appearance.Options.UseFont = true;
            this.txt_HoTenKH.Size = new System.Drawing.Size(471, 32);
            this.txt_HoTenKH.TabIndex = 2;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(343, 206);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Properties.Appearance.Options.UseFont = true;
            this.txt_SDT.Size = new System.Drawing.Size(471, 32);
            this.txt_SDT.TabIndex = 4;
            // 
            // se_SoTien
            // 
            this.se_SoTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_SoTien.Location = new System.Drawing.Point(343, 275);
            this.se_SoTien.Name = "se_SoTien";
            this.se_SoTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_SoTien.Properties.Appearance.Options.UseFont = true;
            this.se_SoTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_SoTien.Properties.DisplayFormat.FormatString = "n0";
            this.se_SoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.se_SoTien.Size = new System.Drawing.Size(471, 32);
            this.se_SoTien.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "ĐẶT CỌC TIỀN";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.Appearance.Options.UseFont = true;
            this.btn_XacNhan.Location = new System.Drawing.Point(396, 367);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(129, 49);
            this.btn_XacNhan.TabIndex = 8;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // mesTienCoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 505);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(triGiaLabel);
            this.Controls.Add(this.se_SoTien);
            this.Controls.Add(sdtLabel);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(hoTenKHLabel);
            this.Controls.Add(this.txt_HoTenKH);
            this.Name = "mesTienCoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIỀN CỌC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mesTienCoc_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txt_HoTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_SoTien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_HoTenKH;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.SpinEdit se_SoTien;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_XacNhan;
    }
}