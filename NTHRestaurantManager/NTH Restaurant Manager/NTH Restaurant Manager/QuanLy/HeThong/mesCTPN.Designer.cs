
namespace NTH_Restaurant_Manager
{
    partial class mesCTPN
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
            System.Windows.Forms.Label tennlLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label label2;
            this.txt_TenNL = new DevExpress.XtraEditors.TextEdit();
            this.se_SoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.se_Gia = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_DonVi = new DevExpress.XtraEditors.TextEdit();
            tennlLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_SoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonVi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tennlLabel
            // 
            tennlLabel.AutoSize = true;
            tennlLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tennlLabel.Location = new System.Drawing.Point(54, 148);
            tennlLabel.Name = "tennlLabel";
            tennlLabel.Size = new System.Drawing.Size(166, 27);
            tennlLabel.TabIndex = 1;
            tennlLabel.Text = "Tên nguyên liệu";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongLabel.Location = new System.Drawing.Point(54, 255);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(97, 27);
            soLuongLabel.TabIndex = 3;
            soLuongLabel.Text = "Số lượng";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaLabel.Location = new System.Drawing.Point(54, 306);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(46, 27);
            giaLabel.TabIndex = 5;
            giaLabel.Text = "Giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(54, 202);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 27);
            label2.TabIndex = 9;
            label2.Text = "Đơn vị";
            // 
            // txt_TenNL
            // 
            this.txt_TenNL.Enabled = false;
            this.txt_TenNL.Location = new System.Drawing.Point(249, 145);
            this.txt_TenNL.Name = "txt_TenNL";
            this.txt_TenNL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNL.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNL.Size = new System.Drawing.Size(389, 32);
            this.txt_TenNL.TabIndex = 2;
            // 
            // se_SoLuong
            // 
            this.se_SoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_SoLuong.Location = new System.Drawing.Point(249, 252);
            this.se_SoLuong.Name = "se_SoLuong";
            this.se_SoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_SoLuong.Properties.Appearance.Options.UseFont = true;
            this.se_SoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_SoLuong.Size = new System.Drawing.Size(389, 32);
            this.se_SoLuong.TabIndex = 4;
            // 
            // se_Gia
            // 
            this.se_Gia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_Gia.Location = new System.Drawing.Point(249, 303);
            this.se_Gia.Name = "se_Gia";
            this.se_Gia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_Gia.Properties.Appearance.Options.UseFont = true;
            this.se_Gia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_Gia.Size = new System.Drawing.Size(389, 32);
            this.se_Gia.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "THÊM CHI TIẾT PHIẾU NHẬP";
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Location = new System.Drawing.Point(276, 414);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(123, 43);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Xác nhận";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_DonVi
            // 
            this.txt_DonVi.Enabled = false;
            this.txt_DonVi.Location = new System.Drawing.Point(249, 199);
            this.txt_DonVi.Name = "txt_DonVi";
            this.txt_DonVi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonVi.Properties.Appearance.Options.UseFont = true;
            this.txt_DonVi.Size = new System.Drawing.Size(389, 32);
            this.txt_DonVi.TabIndex = 10;
            // 
            // mesCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 539);
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
            this.Name = "mesCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM CHI TIẾT PHIẾU NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mesCTPN_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_SoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonVi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txt_TenNL;
        private DevExpress.XtraEditors.SpinEdit se_SoLuong;
        private DevExpress.XtraEditors.SpinEdit se_Gia;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.TextEdit txt_DonVi;
    }
}