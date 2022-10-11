
namespace NTH_Restaurant_Manager
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
            this.lb_TieuDe = new DevExpress.XtraEditors.LabelControl();
            this.btn_Phong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Ban = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.Appearance.Options.UseFont = true;
            this.lb_TieuDe.Location = new System.Drawing.Point(75, 68);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(417, 35);
            this.lb_TieuDe.TabIndex = 0;
            this.lb_TieuDe.Text = "Bạn muốn thêm Phòng hay Bàn?";
            // 
            // btn_Phong
            // 
            this.btn_Phong.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phong.Appearance.Options.UseFont = true;
            this.btn_Phong.Location = new System.Drawing.Point(121, 156);
            this.btn_Phong.Name = "btn_Phong";
            this.btn_Phong.Size = new System.Drawing.Size(125, 46);
            this.btn_Phong.TabIndex = 1;
            this.btn_Phong.Text = "Phòng";
            this.btn_Phong.Click += new System.EventHandler(this.btn_Phong_Click);
            // 
            // btn_Ban
            // 
            this.btn_Ban.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ban.Appearance.Options.UseFont = true;
            this.btn_Ban.Location = new System.Drawing.Point(329, 156);
            this.btn_Ban.Name = "btn_Ban";
            this.btn_Ban.Size = new System.Drawing.Size(125, 46);
            this.btn_Ban.TabIndex = 2;
            this.btn_Ban.Text = "Bàn";
            this.btn_Ban.Click += new System.EventHandler(this.btn_Ban_Click);
            // 
            // mesPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 264);
            this.Controls.Add(this.btn_Ban);
            this.Controls.Add(this.btn_Phong);
            this.Controls.Add(this.lb_TieuDe);
            this.Name = "mesPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mesPhongBan_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_Phong;
        private DevExpress.XtraEditors.SimpleButton btn_Ban;
        public DevExpress.XtraEditors.LabelControl lb_TieuDe;
    }
}