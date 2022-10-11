
namespace NTH_Restaurant_Manager.QuanLy.DanhMuc
{
    partial class mesPhongBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Phong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Ban = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn muốn thêm Phòng hay Bàn?";
            // 
            // btn_Phong
            // 
            this.btn_Phong.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phong.Appearance.Options.UseFont = true;
            this.btn_Phong.Location = new System.Drawing.Point(41, 147);
            this.btn_Phong.Name = "btn_Phong";
            this.btn_Phong.Size = new System.Drawing.Size(162, 57);
            this.btn_Phong.TabIndex = 1;
            this.btn_Phong.Text = "Phòng";
            // 
            // btn_Ban
            // 
            this.btn_Ban.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ban.Appearance.Options.UseFont = true;
            this.btn_Ban.Location = new System.Drawing.Point(294, 147);
            this.btn_Ban.Name = "btn_Ban";
            this.btn_Ban.Size = new System.Drawing.Size(162, 57);
            this.btn_Ban.TabIndex = 2;
            this.btn_Ban.Text = "Bàn";
            // 
            // mesPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 264);
            this.Controls.Add(this.btn_Ban);
            this.Controls.Add(this.btn_Phong);
            this.Controls.Add(this.label1);
            this.Name = "mesPhongBan";
            this.Text = "Xác nhận";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Phong;
        private DevExpress.XtraEditors.SimpleButton btn_Ban;
    }
}