
namespace NTH_Restaurant_Manager
{
    partial class mesKhacHang_HD_PDT
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_MaSoThue = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HoTenKH = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSoThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HoTenKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(403, 289);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(145, 48);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Xác nhận";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_MaSoThue
            // 
            this.txt_MaSoThue.Location = new System.Drawing.Point(372, 197);
            this.txt_MaSoThue.Name = "txt_MaSoThue";
            this.txt_MaSoThue.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSoThue.Properties.Appearance.Options.UseFont = true;
            this.txt_MaSoThue.Size = new System.Drawing.Size(401, 32);
            this.txt_MaSoThue.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(761, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "NHẬP THÔNG TIN KHÁCH HÀNG ĐỂ LẬP HÓA ĐƠN";
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.Location = new System.Drawing.Point(372, 121);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenKH.Properties.Appearance.Options.UseFont = true;
            this.txt_HoTenKH.Size = new System.Drawing.Size(401, 32);
            this.txt_HoTenKH.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã số thuế";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ tên khách hàng";
            // 
            // mesKhacHang_HD_PDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 383);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txt_MaSoThue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_HoTenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mesKhacHang_HD_PDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHẬP THÔNG TIN KHÁCH HÀNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mesKhacHang_HD_PDT_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSoThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HoTenKH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txt_MaSoThue;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_HoTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}